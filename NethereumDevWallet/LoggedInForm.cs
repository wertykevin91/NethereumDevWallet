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

        private protected async Task InitializeData()
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

        private protected async Task InitializeBalance()
        {
            Balance = await Web3.Eth.GetBalance.SendRequestAsync(Account.Address);
            var b = UnitConversion.Convert.FromWei(Balance, UnitConversion.EthUnit.Ether);

            var decimalPlaces = NumberUtil.GetDecimalPlaces(b);

            balanceTextBox.Text = $"{b.ToString($"N{decimalPlaces.ToString()}")}";
        }

        private protected async Task InitializeGas()
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

        private protected void InitializeSendTab()
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
                sentTransactionHashTextBox.Text = txSigned;

                // sanity check because Ganache UI was displaying rounded up numbers which was truly killing me inside.
                {
                    var gasssss = BigInteger.Subtract(Balance, BigInteger.Multiply(gasInWeiHex, gasPriceInWeiHex));
                    var final = BigInteger.Subtract(gasssss, ethInWeiHex);

                    Console.WriteLine($"{Balance.ToString()} = {final.ToString()} + {BigInteger.Multiply(gasInWeiHex, gasPriceInWeiHex).ToString()} + {ethInWeiHex.Value.ToString()}");
                }

                var txInfo = await Web3.Eth.TransactionManager.SendTransactionAsync(tx);
                sentTransactionHashTextBox.AppendText($"{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}Transaction Hash: {txInfo}");
                InitializeBalance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(JsonConvert.SerializeObject(ex));
            }
        }

        public void PrepareTransaction(object sender, EventArgs e)
        {
            var valid = ValidateTransaction();

            if (!valid)
            {
                return;
            }
        }

        private protected bool ValidateTransaction()
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

        #endregion

        
    }
}
