using NethereumDevWallet.Classes;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Numerics;
using Nethereum.Util;
using NethereumDevWallet.Util;

namespace NethereumDevWallet
{
    public partial class LoggedInForm : Form
    {
        private Nethereum.Web3.Accounts.Account Account;
        private Nethereum.Web3.Web3 Web3;
        private EthereumServerClass EthereumServer;

        private BigInteger Balance;

        private const long StandardGasUsedForStandardTransaction = 21000;
        private BigInteger StandardGasPrice;

        public LoggedInForm(Nethereum.Web3.Accounts.Account account, EthereumServerClass ethereumServer)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            EthereumServer = ethereumServer;
            Account = account;
            Web3 = new Nethereum.Web3.Web3(account, ethereumServer.Url);
            InitializeData();
        }
        
        private void returnToMain()
        {
            var main = new EntryForm();

            main.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            returnToMain();
        }

        #region Initialize Data

        private async Task InitializeData()
        {
            try
            {
                addressTextBox.Text = Account.Address;
                networkTextBox.Text = EthereumServer.Url;
                await InitializeBalance();
                await InitializeGas();

                InitializeSendTab();
            }
            catch(Exception ex)
            {
                MessageBox.Show(JsonConvert.SerializeObject(ex));
            }
        }

        private async Task InitializeBalance()
        {
            Balance = await Web3.Eth.GetBalance.SendRequestAsync(Account.Address);
            var b = UnitConversion.Convert.FromWei(Balance, UnitConversion.EthUnit.Ether);

            var decimalPlaces = NumberUtil.GetDecimalPlaces(b);

            balanceTextBox.Text = $"{b.ToString($"N{decimalPlaces.ToString()}")}";
        }

        private async Task InitializeGas()
        {
            StandardGasPrice = await Web3.Eth.GasPrice.SendRequestAsync();
            gasPriceTextBox.Text = $"{UnitConversion.Convert.FromWei(StandardGasPrice, 9).ToString("N3")}";
        }

        private void refreshBalanceButton_Click(object sender, EventArgs e)
        {
            InitializeBalance();
        }

        private void refreshGasPriceButton_Click(object sender, EventArgs e)
        {
            InitializeGas();
        }

        #endregion

        #region Tabs

        #region Send Tab

        private void InitializeSendTab()
        {
            gasUsedToUseTextBox.Text = $"{StandardGasUsedForStandardTransaction.ToString("F0")}";
            gasPriceToUseTextBox.Text = $"{UnitConversion.Convert.FromWei(StandardGasPrice, 9).ToString("F3")}";
        }

        private async void sendEthTransactionButton_Click(object sender, EventArgs e)
        {
            try
            {
                var receipientAddress = receipientAddressTextBox.Text.Trim();

                var ethAmount = decimal.Parse(ethToSendTextBox.Text.Trim()); // exponent -18
                var ethInWei = UnitConversion.Convert.ToWeiFromUnit(ethAmount, UnitConversion.Convert.GetEthUnitValue(UnitConversion.EthUnit.Ether));
                var ethInWeiHex = new Nethereum.Hex.HexTypes.HexBigInteger(ethInWei);

                var gasPrice = decimal.Parse(gasPriceToUseTextBox.Text.Trim()); // exponent -9
                var gasPriceInWei = UnitConversion.Convert.ToWei(gasPrice, 9);
                var gasPriceInWeiHex = new Nethereum.Hex.HexTypes.HexBigInteger(gasPriceInWei);

                var gas = decimal.Parse(gasUsedToUseTextBox.Text.Trim()); // exponent 0
                var gasInWei = new BigInteger(gas);
                var gasInWeiHex = new Nethereum.Hex.HexTypes.HexBigInteger(gasInWei);
                
                var tx = new Nethereum.RPC.Eth.DTOs.TransactionInput(null, receipientAddress, Account.Address, gasInWeiHex, gasPriceInWeiHex, ethInWeiHex);
                sentTransactionDataTextBox.Text = JsonConvert.SerializeObject(tx);

                var txSigned = await Web3.Eth.TransactionManager.SignTransactionRetrievingNextNonceAsync(tx);
                sentTransactionHashTextBox.Text = $"Signed Tx: {txSigned}";

                // sanity check because Ganache UI was displaying rounded up numbers which was truly killing me inside.
                //{
                //    var gasssss = BigInteger.Subtract(Balance, BigInteger.Multiply(gasInWeiHex, gasPriceInWeiHex));
                //    var final = BigInteger.Subtract(gasssss, ethInWeiHex);

                //    Console.WriteLine($"{Balance.ToString()} = {final.ToString()} + {BigInteger.Multiply(gasInWeiHex, gasPriceInWeiHex).ToString()} + {ethInWeiHex.Value.ToString()}");
                //}

                var txHash = await Web3.Eth.TransactionManager.SendTransactionAsync(tx);
                var txReceipt = await Web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(txHash);

                // Give users a receipt

                //hashAndReceiptTextBox.Text = string.Empty;
                //hashAndReceiptTextBox.AppendText($"Transaction Hash: {txHash}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}");
                hashAndReceiptTextBox.Text = $"Receipt: {JsonConvert.SerializeObject(txReceipt)}";


                InitializeBalance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(JsonConvert.SerializeObject(ex));
            }
        }

        public void PrepareSendTransaction(object sender, EventArgs e)
        {
            var valid = ValidateSendTransaction();

            if (!valid)
            {
                return;
            }
        }

        private bool ValidateSendTransaction()
        {
            try
            {
                var receipientAddress = string.Empty;
                var ethAmount = string.Empty;
                var gasPrice = string.Empty;
                var garLimit = string.Empty;
            }
            catch (Exception ex)
            {
                sentTransactionDataTextBox.Text = JsonConvert.SerializeObject(ex);

                return false;
            }
            return true;
        }


        #endregion

        #region Drain Tab

        private void drainSendButton_Click(object sender, EventArgs e)
        {
            var receipientAddress = drainReceipientAddressTextBox.Text;
            DrainWalletToAddress(receipientAddress);
        }

        private async void DrainWalletToAddress(string receipientAddress)
        {
            // calculate

            var balance = await Web3.Eth.GetBalance.SendRequestAsync(Account.Address);

            var gasPrice = await Web3.Eth.GasPrice.SendRequestAsync();
            var gasPriceHex = new Nethereum.Hex.HexTypes.HexBigInteger(gasPrice);

            var gas = Web3.Eth.TransactionManager.DefaultGas;
            var gasHex = new Nethereum.Hex.HexTypes.HexBigInteger(gas);

            var balanceToTransfer = BigInteger.Subtract(balance, BigInteger.Multiply(gasPrice, gas));
            var balanceToTransferHex = new Nethereum.Hex.HexTypes.HexBigInteger(balanceToTransfer);

            var transactionInput = new Nethereum.RPC.Eth.DTOs.TransactionInput(null, receipientAddress, Account.Address, gasHex, gasPriceHex, balanceToTransferHex);
            drainTransactionRichTextBox.Text = JsonConvert.SerializeObject(transactionInput);

            drainSignedTransactionRichTextBox.Text = await Web3.TransactionManager.SignTransactionRetrievingNextNonceAsync(transactionInput);

            //var txHash = await Web3.TransactionManager.SignTransactionRetrievingNextNonceAsync(transactionInput);

            var txReceipt = await Web3.TransactionManager.TransactionReceiptService.SendRequestAndWaitForReceiptAsync(() => {
                return Web3.TransactionManager.SendTransactionAsync(transactionInput);
            });

            drainTransactionReceiptRichTextBox.Text = JsonConvert.SerializeObject(txReceipt);
        }

        #endregion

        #endregion
    }
}
