using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode
{
    class EncDec
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            Console.Write("Enter a KEY (sequence of random characters without spaces): ");
            string key = Console.ReadLine();
            Console.WriteLine("\nEncryption: {0}", Encrypt(word, key));
            Console.WriteLine("\nEncryption + decryption: {0}\n", Decrypt(Encrypt(word, key), key));
        }
        static string Encrypt(string word, string key)
        {
            StringBuilder cipher = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
                cipher.Append((char)(word[i] ^ key[i % key.Length]));
            return cipher.ToString();
        }
        static string Decrypt(string word, string key)
        {
            return Encrypt(word, key);
        }
    }
}
