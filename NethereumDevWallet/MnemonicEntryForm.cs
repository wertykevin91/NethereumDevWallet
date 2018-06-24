using NethereumDevWallet.Classes;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace NethereumDevWallet
{
    public partial class MnemonicEntryForm : Form
    {
        private EthereumServerClass EthereumServer;

        public MnemonicEntryForm(EthereumServerClass ethereumServer)
        {
            EthereumServer = ethereumServer;
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            returnToMain();
        }

        private void returnToMain()
        {
            var main = new EntryForm();

            main.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mnemonic = richTextBox1.Text.Trim();

            var wallet = new Nethereum.HdWallet.Wallet(mnemonic, string.Empty);
            var account = wallet.GetAccount(0);

            var loginForm = new LoggedInForm(account, EthereumServer);
            loginForm.Show();
            Close();
        }
    }
}
