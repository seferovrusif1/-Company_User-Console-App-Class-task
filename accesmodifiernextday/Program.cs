using accesmodifiernextday.Models;
using Microsoft.VisualBasic;

namespace accesmodifiernextday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company x000 = new Company(null);
            string Name;
            string SurName;
            string UserName;
            byte age;
            Employee x001;
            bool iscontinue = true;
            while(iscontinue)
                {
                
                Console.WriteLine($"\n0: Create a company\n1: Create an employee\n2: Delete employee\n3: Update employee\n4: See all employees\n5: See employee\n6: End\n");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "0":
                        Console.WriteLine("Company name:");   x000 = new Company(Console.ReadLine());
                        break;

                //Methodlar companyde hazirlanib ve company ucun baza olaraq bir array yaratmadiqimiz ucun 
                //company created- yenii companynin adini deyisirik
                //ve eger consolda evvelce employee obyekti yaratmisiqsa ve company deyisdikden sonra evvelki
                // kompanyde olan employee objectleri gorunmur 

                    case "1":
                        Console.WriteLine("Name: ");           Name = Console.ReadLine();
                        Console.WriteLine("SurName: ");        SurName = Console.ReadLine();
                        Console.WriteLine("Age: ");            age = Convert.ToByte(Console.ReadLine());
                        
                        x001 = new Employee(Name, SurName, age);
                        x000.AddUser(x001);


                        break;

                    case "2":
                        Console.WriteLine("Write UserName");   UserName = Console.ReadLine();

                        x000.RemoveUser(UserName);
                        break;
                    case "3":
                        Console.WriteLine("Write UserName");   UserName = Console.ReadLine();

                        x000.UpdateUser(UserName);

                        break;
                    case "4":
                        x000.GetAllUsers();
                        break;
                    case "5":
                        Console.WriteLine("Write UserName");   UserName = Console.ReadLine();

                        x000.PrintUserInfo(x000.GetUser(UserName));

                //x000.GetUser(UserName) --  x000 companydeki  verilen USernamede olan obyekti qaytarir
                //x000.PrintUserInfo(employee) -- verilen byektin melumatlarini consola yazir

                        break;
                    case "6":
                        iscontinue = false;
                        break;
                   

                }

            }
        }
        }
    }
