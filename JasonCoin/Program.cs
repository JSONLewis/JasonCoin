using System;
using System.Collections.Generic;

namespace JasonCoin
{
    class Program
    {
        List<Block> blockChain = new List<Block>();
        static void Main(string[] args)
        {
            string[] genesisTransactions = { "satoshi sent 1 BTC to Jason", "Satoshi gave 5 BTC to Hal Finney" };
            Block genesisBlock = new Block("Chancellor on the brink...", genesisTransactions); 
            string[] block2Transactions = { "jason sent 1000 bitcoins to satoshi", "Jason sent 11 bitcoin to starbucks" };
            Block block2 = new Block(genesisBlock.BlockHash, block2Transactions);
            string[] block3Transactions = { "jason sent 100000 bitcoins to satoshi", "Jason sent 11 bitcoin to starbucks" };
            Block block3 = new Block(block2.BlockHash, block3Transactions);
            Console.WriteLine("Genesis block hash");
            Console.WriteLine(genesisBlock.BlockHash);
            Console.WriteLine("Block 2 hash");
            Console.WriteLine(block2.BlockHash);
            Console.WriteLine("Block 3 hash");
            Console.WriteLine(block3.BlockHash);
        }
    }
}
