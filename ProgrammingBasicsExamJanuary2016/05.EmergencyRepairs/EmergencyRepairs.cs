namespace _05.EmergencyRepairs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class EmergencyRepairs
    {
        static void Main()
        {
            ulong wall = ulong.Parse(Console.ReadLine());
            int repairKits = int.Parse(Console.ReadLine());
            int numberOfAttacks = int.Parse(Console.ReadLine());
            string[] bitRepresentationOfWall = ConvertToBits(wall).ToCharArray().Select(c => c.ToString()).ToArray();

            for (int i = 0; i < numberOfAttacks; i++)
            {
                int attackPosition = int.Parse(Console.ReadLine());
                bitRepresentationOfWall[attackPosition] = "0";
            }

            for (int i = 0; i < bitRepresentationOfWall.Length - 1 && repairKits > 0; i++)
            {
                if (bitRepresentationOfWall[i] == "0" && bitRepresentationOfWall[i + 1] == "0")
                {
                    for (int j = i; j < bitRepresentationOfWall.Length; j++)
                    {
                        if (bitRepresentationOfWall[j] == "0")
                        {
                            bitRepresentationOfWall[j] = "1";
                            repairKits--;
                            if (repairKits == 0)
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (repairKits == 0)
                {
                    break;
                }
            }

            ulong result = Convert.ToUInt64(string.Join("", bitRepresentationOfWall.Reverse()), 2);
            Console.WriteLine(result);
        }

        private static string ConvertToBits(ulong number)
        {
            string bitRepresentationOfWall = string.Empty;
            while (number > 0)
            {
                ulong bit = number % 2;
                number /= 2;

                bitRepresentationOfWall += bit.ToString();
            }

            return bitRepresentationOfWall.PadRight(64, '0');
        }
    }
}
