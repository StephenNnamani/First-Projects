using System.Collections;

namespace Authentication
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Choose a username");
            string? username = Console.ReadLine();

            Console.WriteLine(@"
Choose a password
NB: must contain a NUMBER be more than 8 characters");
            string? password = Console.ReadLine();

            var User = new Dictionary<string, string>(){
            { "Stephen", "Bezao2022"}
            };

            
            if (password.Length < 8 || !password.Any(c => char.IsDigit(c)))
            {
                Console.WriteLine("password should contain Numbers and must be more than 8 characters");

            }
            else if (User.Keys.Contains(username))
            {
                Console.WriteLine("username already exist");

            }
            else
            {
                User.Add(username, password);
            }


            Console.WriteLine("Login username");
            string lUsername = Console.ReadLine();

            Console.WriteLine("Login password");
            string lPassword = Console.ReadLine();

            foreach (KeyValuePair<string, string> userLogin in User)
            {
                if (!string.IsNullOrEmpty(lUsername) || !string.IsNullOrEmpty(lPassword))
                {
                    if (userLogin.Key == lUsername && userLogin.Value == lPassword)
                    {
                        Console.WriteLine("you have successfully logged in");
                        Console.WriteLine(userLogin.Value + " " + userLogin.Key);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid username or password");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("empty input");
                    break;
                }
            }
        }
    }
}