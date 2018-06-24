using NethereumDevWallet.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NethereumDevWallet
{
    public partial class JsonEntryForm : Form
    {
        private string FileContent { get; set; }
        private EthereumServerClass EthereumServer { get; set; }

        public JsonEntryForm(EthereumServerClass ethereumServer)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            EthereumServer = ethereumServer;
        }

        private void backToEntry_Click(object sender, EventArgs e)
        {
            returnToMain();
        }

        private void returnToMain()
        {
            var main = new EntryForm();

            main.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;
                textBox1.Text = file;
                try
                {
                    var text = File.ReadAllText(file);
                    FileContent = text.Trim();
                    //Console.WriteLine(text);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("Can't display file.. For some reason.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var account = Nethereum.Web3.Accounts.Account.LoadFromKeyStore(FileContent, textBox2.Text.Trim());
            var f = new LoggedInForm(account, EthereumServer);
            f.Show();
            Close();
        }
    }
}
