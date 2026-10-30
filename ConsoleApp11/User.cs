using System;

namespace ConsoleApp11
{
    internal class User : ClientUser
    {
        private string name;
        private string mail;
        private string password;

        public User()
        {
            name = "";
            mail = "";
            password = "";
        }

        public User(string mail, string password)
        {
            name = "Unknown";
            this.mail = mail;
            this.password = password;
        }

        public User(string name, string mail, string password)
        {
            this.name = name;
            this.mail = mail;
            this.password = password;
        }

        public void Name()
        {
            Console.Write("Name: ");
            name = Console.ReadLine() ?? "";
        }

        public void Mail()
        {
            Console.Write("Mail: ");
            mail = Console.ReadLine() ?? "";
        }

        public void Password()
        {
            Console.Write("Password: ");
            password = Console.ReadLine() ?? "";
        }

        public override bool Authorization()
        {
            Console.Write("Mail: ");
            string enteredMail = Console.ReadLine() ?? "";

            Console.Write("Password: ");
            string enteredPassword = Console.ReadLine() ?? "";

            return enteredMail == mail && enteredPassword == password;
        }
    }
}
