namespace ValidPass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = ValidPassword(password);
            bool noRuns = HasNoExcessiveRuns(password);

            Console.WriteLine(isValid);
        }
        // https://stackoverflow.com/questions/30047945/how-can-i-validate-a-password-to-contain-at-least-one-upper-case-or-lower-case-l
        public static bool ValidPassword(string pass)
        {
            return pass.Length >= 8 &&
                   pass.Length <= 15 &&
                   pass.Any(char.IsDigit) &&
                   pass.Any(char.IsLetter) &&
                   (pass.Any(char.IsSymbol) || pass.Any(char.IsPunctuation));
        }
        // Chrome Ai generated
        public static bool HasNoExcessiveRuns(string pass)
        {
            if (string.IsNullOrEmpty(pass) || pass.Length < 3)
                return true;

            for (int i = 0; i <= pass.Length - 3; i++)
            {
                char c1 = pass[i];
                char c2 = pass[i + 1];
                char c3 = pass[i + 2];

                // Check for 3 repeating identical characters (e.g., "aaa", "111")
                if (c1 == c2 && c2 == c3)
                    return false;

                // Check for 3 consecutive sequential numbers or letters (e.g., "123", "abc", "cba")
                if ((c2 == c1 + 1 && c3 == c2 + 1) || (c2 == c1 - 1 && c3 == c2 - 1))
                    return false;
            }

            return true;
        }
    }
}
