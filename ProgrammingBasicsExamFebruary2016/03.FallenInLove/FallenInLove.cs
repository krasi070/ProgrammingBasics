namespace _03.FallenInLove
{
    using System;

    public class FallenInLove
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int outsideFlowerDots = size * 2;
            int insideFlowerDots = 0;
            int insideLeaf = 0;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",
                    new string('~', insideLeaf),
                    new string('.', outsideFlowerDots),
                    new string('.', insideFlowerDots));

                insideLeaf++;
                outsideFlowerDots -= 2;
                insideFlowerDots += 2;
            }

            outsideFlowerDots = 1;

            for (int i = 0; i < size + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                    new string('.', outsideFlowerDots),
                    new string('~', insideLeaf),
                    new string('.', insideFlowerDots));

                outsideFlowerDots += 2;
                insideLeaf--;
                insideFlowerDots -= 2;
            }

            outsideFlowerDots--;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}##{0}", new string('.', outsideFlowerDots));
            }
        }
    }
}
