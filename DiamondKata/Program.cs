namespace DiamondKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Write("Enter a letter (SPACE to exit): ");
                var input = Console.ReadLine();
                if (input != null)
                {
                    if (input == " ")
                    {
                        exit = true;
                    }
                    else
                    {
                        try
                        {
                            var result = Diamond.Create(input);
                            Console.WriteLine(result);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input of '{input}'");
                }
                Console.WriteLine("------------");
            }
        }
    }
}