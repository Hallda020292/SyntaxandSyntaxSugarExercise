namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + "greater than nine";
            }
            Console.WriteLine(response);

            var answer = 4;
            var reponse = (answer < 9) ? $"{answer}is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(reponse);
        }
    }
}
