using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesmodifiernextday.Models
{
    internal class Company
    {
        protected string _name;
        protected Employee[] _employees;
        private bool _isfound = false;
        
        public string Name { get => _name; set { _name = char.ToUpper(value[0]) + value.Substring(1);} }
        public Company(string Name)
        {
            _name = Name;
            _employees = new Employee[0];
        }



        public void AddUser(Employee user)
        {
            Array.Resize(ref _employees, _employees.Length+1);   //Resize eledik arrayi +1 uzunluqa getirdik
            _employees[_employees.Length - 1] = user;            //sonuncu indexe yeni obyekti add eledik

            Console.WriteLine("\nUser Aded\n");
        }
        
        
        public void GetAllUsers()
        {
            foreach (var item in _employees)
            {
                Console.WriteLine(item.UserName);
            }
        }
        

        public Employee GetUser(string username)  //username-i verilmis username olan obyekti return edirik
        {
            foreach (var item in _employees)
            {
                if (item.UserName == username) 
                {
                    return item;
                }              
            }
            Console.WriteLine("UserName tapilmadi!");
            return null;

        }  
        

        public void PrintUserInfo(Employee emp)   //verilen obyektin melumatlarini capa veririk
        {
            Console.WriteLine($"\nName: {emp.Name}\nSurname: {emp.SurName}\nUserName: {emp.UserName}\nAge: {emp.Agee}\n");
        }

        
        public void RemoveUser(string username)
        {
            _isfound = false;     //eger tapilmasa consola mesaj vermek ucun isledeceyik
            for (int j = 0; j < _employees.Length; j++)
            {
                if (_employees[j].UserName == username)
                {       
                    _isfound=true;
                    Employee[] _employeesTemp = new Employee[_employees.Length - 1];
                    // yeni temp array yaradib diger arrayda silinmesi gereken userden basqalarini bu arraya menimsedirik
                    //sonda evvelki arrayi resize edib temp arraya beraber edirik
                    int l = 0;
                    for (int i = 0; i < _employeesTemp.Length; i++)
                    { 
                        if (_employees[i].UserName == username)
                        {
                            l++;
                        }
                        _employeesTemp[i] = _employees[l];
                        l++;

                    }

                    Array.Resize(ref _employees, _employees.Length - 1);
                    _employees = _employeesTemp;
                    Console.WriteLine("\nUser Removed\n");
                }
                if (!_isfound)
                {
                    Console.WriteLine("Istifadechi tapilmadi!");
                }
            }
        }
        
        
        public void UpdateUser(string username)   //verilmis usernamin arraydaki indexini tapib diger methodlara otururuk
        {                                         //hemin metodlardadaki indexdeki obyektin adini yasini soyadini deyisirik
            _isfound=false;                       // ad ve ya soyad deyisende username de deyisir avtomatik      
            for (int i = 0; i < _employees.Length; i++)
            {

                if (_employees[i].UserName == username)
                {
                    _isfound = true;
                    Console.WriteLine("1.Update Name 2.Update Surname 3.Update Age");
                    string d = Console.ReadLine();
                    switch (d)
                    {
                        case "1":
                            UpdateName(i);
                            break;
                        case "2":
                            UpdateSurName(i);
                            break;
                        case "3":
                            UpdateAge(i);
                            break;
                    }
                }
                if (!_isfound)
                {
                    Console.WriteLine("Istifadechi tapilmadi!");
                }

            }
        }
        
        public void UpdateName(int i)
        {
            Console.WriteLine("\nWrite new name:");

            _employees[i].Name = Console.ReadLine();
            _employees[i].UserName = _employees[i].UserName;

            Console.WriteLine("\nName and UserName updated\n");
        }
        public void UpdateSurName(int i)
        {
            Console.WriteLine("\nWrite new surname:");

            _employees[i].SurName = Console.ReadLine();
            _employees[i].UserName = _employees[i].Name + "_" + _employees[i].SurName;

            Console.WriteLine("\nSurName and UserName updated\n");

        }
        public void UpdateAge(int i)
        {
            Console.WriteLine("\nWrite new age:");

            _employees[i].Agee = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("\nAge updated\n");

        }

    }
}
