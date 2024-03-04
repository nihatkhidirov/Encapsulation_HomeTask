namespace Encapsulation_HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Username Daxil Edin: ");
                string username = Console.ReadLine();
                Console.WriteLine("Password Daxil Edin: ");
                
                string password = Console.ReadLine();
                Console.WriteLine("Yasinizi Daxil Edin: ");
                int age = Convert.ToInt32(Console.ReadLine());
                User user = new User(username, password, age);
            }
              
           
            
           


        }
    }
}