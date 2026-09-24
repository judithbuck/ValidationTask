namespace ValidAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            bool isValid = validAge(age);
            Console.WriteLine(isValid);
        }
        static bool validAge(int age)
        {
            //age must be between 11 and 18 inclusive
            if (age < 11 || age > 18)
            {
                return false;
            }
            return true;
        }
    }
}
