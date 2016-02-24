namespace _02.EncodedAnswers
{
    using System;

    public class EncodedAnswers
    {
        public static void Main()
        {
            int numberOfQuestions = int.Parse(Console.ReadLine());
            string[] answers = new string[numberOfQuestions];
            int numberOfAAnswers = 0;
            int numberOfBAnswers = 0;
            int numberOfCAnswers = 0;
            int numberOfDAnswers = 0;

            for (int i = 0; i < numberOfQuestions; i++)
            {
                uint encodedAnswer = uint.Parse(Console.ReadLine());
                if (encodedAnswer % 4 == 0)
                {
                    answers[i] = "a";
                    numberOfAAnswers++;
                }
                else if (encodedAnswer % 4 == 1)
                {
                    answers[i] = "b";
                    numberOfBAnswers++;
                }
                else if (encodedAnswer % 4 == 2)
                {
                    answers[i] = "c";
                    numberOfCAnswers++;
                }
                else
                {
                    answers[i] = "d";
                    numberOfDAnswers++;
                }
            }

            Console.WriteLine(
                "{0}\nAnswer A: {1}\nAnswer B: {2}\nAnswer C: {3}\nAnswer D: {4}",
                string.Join(" ", answers),
                numberOfAAnswers,
                numberOfBAnswers,
                numberOfCAnswers,
                numberOfDAnswers);
        }
    }
}
