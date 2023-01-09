using DiamondKata;

public class Program
{
    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Write("Enter a letter (SPACE to exit): ");
            var input = Console.ReadLine()[0];
            if(input == ' ')
            {
                exit = true;
            }
            else
            {
                var result = Diamond.Create(input);
                Console.WriteLine(result);
                Console.WriteLine("------------");
            }
        }
    }
}