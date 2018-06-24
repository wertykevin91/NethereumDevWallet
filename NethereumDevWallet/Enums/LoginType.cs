using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NethereumDevWallet.Enums
{
    public enum LoginType : byte
    {
        Json = 0,
        Mnemonic = 1,
        PrivateKey = 2
    }
}
