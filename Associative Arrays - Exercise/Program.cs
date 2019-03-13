using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("motes", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("shards", 0);
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            while(true)
           {
                string[] input = Console.ReadLine().Split();
                bool hasTobreak = false;
                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i+1].ToLower();
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;
                        if ( keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            if ( material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if ( material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if ( material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            hasTobreak = true;
                            break;

                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }
                        
                        
                            junkMaterials[material]+=quantity;
                        
                    }


                }

                if (hasTobreak)
                {
                    break;
                }

          }
            foreach (var kvp in keyMaterials.OrderByDescending(x=> x.Value).ThenBy(x=> x.Key))
            {
                int quantity = kvp.Value;
                string material = kvp.Key;
                Console.WriteLine($"{material}: {quantity} ");
            }
            foreach (var kvp in junkMaterials.OrderBy(x=> x.Key ))
            {
                int quantity = kvp.Value;
                string material = kvp.Key;
                Console.WriteLine($"{material}: {quantity} ");
            }



        }
    }
}
