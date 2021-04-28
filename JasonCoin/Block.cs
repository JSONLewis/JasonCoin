using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace JasonCoin
{
    [Serializable]
    public class Block
    {
        private string previousHash;
        private string[] transactions;
        private string blockHash;
        public Block(string previousHash, string[] transactions)
        {


            Object[] contents = { Helpers.ObjectToSHA256(transactions), previousHash };
            this.blockHash = Helpers.ObjectToSHA256(contents).ToHexString();

            this.previousHash = previousHash;
            this.transactions = transactions;

        }
        public string PreviousHash { get { return previousHash; } }
        public string[] Transaction { get { return transactions; } }
        public string BlockHash { get { return blockHash; } }

    }


}
