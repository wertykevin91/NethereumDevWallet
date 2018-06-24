using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NethereumDevWallet.Classes
{
    public class EthereumServerClass
    {
        public string Name { get; }
        public string Url { get; }
        public Nethereum.Signer.Chain Chain { get; }

        public EthereumServerClass(string Name, string Url, Nethereum.Signer.Chain Chain)
        {
            this.Name = Name;
            this.Url = Url;
            this.Chain = Chain;
        }
    }
}
