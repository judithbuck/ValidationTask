namespace Username
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = "bob";
            string last = "smith";
            int age = 15;
            string userName = createUserName(first, last, age);
            Console.WriteLine(userName);
        }
        static string createUserName(string firstName, string lastName, int age)
        {
            // username is made up from:
            // first two characters of first name
            // last two characters of last name
            // age
            //e.g. Bob Smith aged 34 would have the username Both34
            string username = firstName.Substring(0, 2) + lastName.Substring(lastName.Length - 2) + age.ToString();

            return username;
        }
    }
}
