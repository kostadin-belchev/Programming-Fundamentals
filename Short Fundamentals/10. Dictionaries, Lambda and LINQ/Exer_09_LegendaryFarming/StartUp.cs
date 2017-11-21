namespace Exer_09_LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            bool isLegendary = false;
            string legendaryName = string.Empty;
            { }
            var keyMaterials = new Dictionary<string, int>();
            {
                keyMaterials["fragments"] = 0;
                keyMaterials["shards"] = 0;
                keyMaterials["motes"] = 0;
            }

            var junkMaterials = new SortedDictionary<string, int>();

            while (!isLegendary)
            {
                string[] materials = Console.ReadLine().ToLower().Split(' ');

                for (int i = 0; i < materials.Length; i += 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string material = materials[i + 1];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }

                    foreach (var mat in keyMaterials)
                    {
                        if (mat.Key == "shards" && mat.Value >= 250)
                        {
                            legendaryName = "Shadowmourne obtained!";
                            keyMaterials[material] -= 250;
                            isLegendary = true;
                            break;
                        }
                        else if (mat.Key == "fragments" && mat.Value >= 250)
                        {
                            legendaryName = "Valanyr obtained!";
                            keyMaterials[material] -= 250;
                            isLegendary = true;
                            break;
                        }
                        else if (mat.Key == "motes" && mat.Value >= 250)
                        {
                            legendaryName = "Dragonwrath obtained!";
                            keyMaterials[material] -= 250;
                            isLegendary = true;
                            break;
                        }
                    }

                    if (isLegendary)
                        break;
                }
            }

            var sortedKeyMats = keyMaterials.OrderByDescending(x => x.Value).ThenBy(y => y.Key);

            Console.WriteLine(legendaryName);

            foreach (var keyMaterial in sortedKeyMats)
            {
                Console.WriteLine("{0}: {1}", keyMaterial.Key, keyMaterial.Value);
            }
            foreach (var junkMaterial in junkMaterials)
            {
                Console.WriteLine("{0}: {1}", junkMaterial.Key, junkMaterial.Value);
            }
        }
    }
}
