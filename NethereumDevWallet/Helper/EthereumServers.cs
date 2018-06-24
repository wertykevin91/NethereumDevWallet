using NethereumDevWallet.Classes;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Text.RegularExpressions;

namespace NethereumDevWallet.Helper
{
    public static class EthereumServers
    {
        /// <summary>
        /// Get your Ethereum Server selection.
        /// Please link the infura links to your accounts
        /// </summary>
        /// <returns></returns>
        public static IList<EthereumServerClass> GetEthereumServerClasses()
        {
            return new[] {
                new EthereumServerClass("localhost:7545", "http://localhost:7545/", Nethereum.Signer.Chain.Private),
                new EthereumServerClass("localhost:8545", "http://localhost:8545/", Nethereum.Signer.Chain.Private),
                new EthereumServerClass("Rinkeby", "https://rinkeby.infura.io/", Nethereum.Signer.Chain.Rinkeby),
                new EthereumServerClass("Ropsten", "https://ropsten.infura.io/", Nethereum.Signer.Chain.Ropsten),
                /// Lets keep mainnet off the menu for now.
                //new EthereumServerClass("Mainnet", "https://mainnet.infura.io/", Nethereum.Signer.Chain.MainNet)
            };
        }
    }
}
