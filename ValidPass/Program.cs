namespace ValidPass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = ValidPassword(password);

            Console.WriteLine(isValid);
        }
        static bool ValidPassword(string pass)
        {
            return pass.Length >= 8 &&
                   pass.Length <= 15 &&
                   pass.Any(char.IsDigit) &&
                   pass.Any(char.IsLetter) &&
                   (pass.Any(char.IsSymbol) || pass.Any(char.IsPunctuation));
        }
    }
}
