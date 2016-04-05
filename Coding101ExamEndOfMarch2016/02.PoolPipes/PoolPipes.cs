namespace _02.PoolPipes
{
    using System;

    public class PoolPipes
    {
        public static void Main()
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int firstPipeLitrePerHour = int.Parse(Console.ReadLine());
            int secondPipeLitrePerHour = int.Parse(Console.ReadLine());
            double abscentTime = double.Parse(Console.ReadLine());

            double firstPipeFill = firstPipeLitrePerHour*abscentTime;
            double secondPipeFill = secondPipeLitrePerHour*abscentTime;
            double poolVolumeFilled = firstPipeFill + secondPipeFill;

            if (poolVolumeFilled <= poolVolume)
            {
                int poolFillPercentage = (int)(poolVolumeFilled/poolVolume*100);
                int firstPipeFillPercentage = (int)(firstPipeFill/poolVolumeFilled*100);
                int secondPipeFillPercentage = (int)(secondPipeFill/poolVolumeFilled*100);
                Console.WriteLine(
                    "The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    poolFillPercentage,
                    firstPipeFillPercentage,
                    secondPipeFillPercentage);
            }
            else
            {
                double overflowAmount = poolVolumeFilled - poolVolume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", abscentTime, overflowAmount);
            }
        }
    }
}
