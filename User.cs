using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_HomeTask
{
    internal class User
    {
        public User()
        {
        }
        public User(string username, string password, int age)
        {
            Username = username;
            Password = password;
            Age = age;
        }
        private int _age;
        private string _password;
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }


            set
            {
                Console.WriteLine("#######################################");
                Console.WriteLine("Sizin Istifadeci Adiniz: "+(value));
            }
        }
        public string Password
        {
            get
            {
                
                return _password;
            }
            set
            {
                
                if (value == null)
                {
                    Console.WriteLine("Password Bos Ola Bilmez");
                    
                }
                else if (value.Length < 8)
                {
                    Console.WriteLine("Password-un uzunlugu 8-den qisa ola bilmez!");
                   
                }

                 else if (!FindLetterOrFindNumber(value))
                {
                    Console.WriteLine("Password Uygun Deyil. Yeniden Cehd Edin!");
                    
                }
                else
                {
                    Console.WriteLine("Sizin Sifreniz: " + value);
                    _password= value;
                }
                



            }

        }
        public int Age
        {

            get
            {
                return _age;
            }


            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yasiniz Menfi Ola Bilmez!");
                    Console.WriteLine("Yanlis Daxil Etdiniz...");
                }
                else
                {
                    Console.WriteLine("Sizin Yasiniz: " + (value));
                    Console.WriteLine("#######################################");


                }
            }
        }


        private bool FindLetterOrFindNumber(string value)
        {
            bool isLetter = value.Any(Char.IsLetter);
            bool IsNumber = value.Any(Char.IsNumber);
            return isLetter && IsNumber;
        }
        
        


    }
}
