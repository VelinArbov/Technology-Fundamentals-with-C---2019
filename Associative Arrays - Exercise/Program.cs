using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var minersInfo = new Dictionary<string, int>();
            
            while (true)
            {

                string product = Console.ReadLine();
                if (product == "stop")
                {
                    break;
                }
                int numbers = int.Parse(Console.ReadLine());
               

                if ( !minersInfo.ContainsKey(product))
                {
                    minersInfo[product] = numbers;
                   
                }
                else
                {
                    minersInfo[product] += numbers;
                }
              

            }
            foreach (var key in minersInfo)
            {


                Console.WriteLine($"{key.Key} -> {string.Join(", ", key.Value)}");
            }







        }
    }
}
