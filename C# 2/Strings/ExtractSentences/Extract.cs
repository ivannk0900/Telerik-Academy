using System;
using System.Text;

namespace ExtractSentences
{
    class Extract
    {
        static void Main()
        {
            Console.WriteLine("enter sentence");
            string sentence = Console.ReadLine();

             Console.WriteLine("enter word for searching");
             string word = (" " + Console.ReadLine() + " ");  
            
            
            

            string dot = ".";

            for (int i = 0; i < sentence.Length; i++)
            {

                    if ((int)sentence[i] >= 65 && (int)sentence[i] <= 90)
                    {
                            int dotIndex = sentence.IndexOf(dot, i);
                            StringBuilder sentenceToPrint = new StringBuilder();
                            for (int j = i; j <= dotIndex; j++)
                            {
                                sentenceToPrint.Append(sentence[j]);
                            }
                            bool b = false;
                            
                        if(sentenceToPrint.ToString().Contains(word))
                        {
                            Console.WriteLine(sentenceToPrint);
                        }

                         
                        
                    }



                
            }
        }
    }
}
