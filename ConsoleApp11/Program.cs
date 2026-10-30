namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name();
            user.Mail();
            user.Password();

            Console.WriteLine();

            ClientUser clientUser = user;

            if (clientUser.Authorization())
            {
                Console.WriteLine("Authorization successful.");
            }
            else
            {
                Console.WriteLine("Wrong mail or password.");
            }
        }
    }
}
