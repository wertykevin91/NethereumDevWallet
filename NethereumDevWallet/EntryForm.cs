using NethereumDevWallet.Classes;
using NethereumDevWallet.Helper;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NethereumDevWallet
{
    public partial class EntryForm : Form
    {
        private EthereumServerClass ServerSelected;

        public EntryForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void jsonButton_Click(object sender, EventArgs e)
        {
            var formNext = new JsonEntryForm(ServerSelected);
            Hide();
            formNext.Show();
            Close();
            Dispose();
        }

        private void mnemonicsButton_Click(object sender, EventArgs e)
        {
            var formNext = new MnemonicEntryForm(ServerSelected);
            Hide();
            formNext.Show();
            Close();
            Dispose();
        }

        private void privateKeyButton_Click(object sender, EventArgs e)
        {
            var formNext = new PrivateKeyEntryForm(ServerSelected);
            Hide();
            formNext.Show();
            Close();
            Dispose();
        }

        private void serverDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            var selectedServer = (string)cb.SelectedItem;

            ServerSelected = EthereumServers.GetEthereumServerClasses().FirstOrDefault(x => x.Name == selectedServer);
        }

        #region Initialize Data

        private void InitializeData()
        {
            var servers = EthereumServers.GetEthereumServerClasses();
            serverDropdownList.DropDownStyle = ComboBoxStyle.DropDownList;
            serverDropdownList.Items.AddRange(servers.Select(x => x.Name).ToArray());
            serverDropdownList.SelectedIndex = 0;

            ServerSelected = servers[0];
        }

        #endregion
    }
}
