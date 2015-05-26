using System;
using System.Text;

namespace ParceTags
{
    class Tags
    {
        static void Main()
        {
            Console.WriteLine("enter the text");
            String text =  Console.ReadLine();

            string upCase = "<upcase>";
            string upCaseEnd = "</upcase>";


            StringBuilder  result = new StringBuilder();
            result.Append(text);
            


           while(true)
            {
                int indexUpCaseStart = result.ToString().IndexOf(upCase, 0);   // the index where <upcase> start
                if(indexUpCaseStart>=0)
                {
                   StringBuilder oldValue = new StringBuilder();
                    StringBuilder newValue= new StringBuilder();

                    int indexUpCaseEnd = result.ToString().IndexOf(upCaseEnd, 0) - upCaseEnd.Length+1;   // the index where </upcase> start

                    for (int i = indexUpCaseStart+upCase.Length; i < indexUpCaseEnd+upCaseEnd.Length-1; i++)
                    {
                        oldValue.Append(result[i].ToString());
                    }

              
                    newValue.Append(oldValue.ToString().ToUpper());
               
                    result = result.Remove(indexUpCaseStart, upCase.Length);
                    
                    result = result.Remove(indexUpCaseEnd, upCaseEnd.Length);

                    result.Replace(oldValue.ToString(), newValue.ToString(), indexUpCaseStart, newValue.Length);
                    

                  
                   
                }
                else
                {
                    break;
                }

               
            }
            
            Console.WriteLine(result);



        }
    }
}
