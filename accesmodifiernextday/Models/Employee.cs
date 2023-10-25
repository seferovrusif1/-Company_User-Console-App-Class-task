using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace accesmodifiernextday.Models
{
    internal class Employee
    {
        private string _name;
        private string _surname;
        private string _username;
        private byte _age;
        public string Name { get=> _name; set{ _name = char.ToUpper(value[0]) + value.Substring(1); } }
        public string SurName { get => _surname; set { _surname = char.ToUpper(value[0]) + value.Substring(1); } }
        public byte Agee
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age 0 dan boyuk olmalidir!!");
                }
            }
        }
        public string UserName { get => _username; set { _username = _name+"_"+_surname; } }

       

        public Employee(string name, string surname,byte age )
        {
            Name = name;
            SurName = surname;
            Agee=age;
            UserName= UserName; //property ni caqirmaq ucun yazdim olmayanda property caqrilmir

        }

        
    }
}
