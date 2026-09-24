namespace ValidName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();

            bool isValid = ValidName(firstname);
            Console.WriteLine(isValid);
        }

        static bool ValidName(string name)
        {
            // name must be at least two characters and contain only letters
            if (name.Length < 2)
            {
                return false;
            }
            foreach (char c in name)
            {
                if (!Char.IsLetter(c))
                { return false; }
            }
            return true;
        }

    }
}
