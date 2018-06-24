using NethereumDevWallet.Classes;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace NethereumDevWallet
{
    public partial class PrivateKeyEntryForm : Form
    {
        private EthereumServerClass EthereumServer;

        public PrivateKeyEntryForm(EthereumServerClass ethereumServer)
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
            var pk = textBox1.Text.Trim();
            var account = new Nethereum.Web3.Accounts.Account(pk, EthereumServer.Chain);
            var login = new LoggedInForm(account, EthereumServer);
            login.Show();
            Close();
        }
    }
}
