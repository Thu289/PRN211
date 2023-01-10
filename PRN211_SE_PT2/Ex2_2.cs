using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE_PT2
{
    internal class Ex2_2
    {
        class NhanVien
        {
            string name;
            int age;
            string address;
            double salary;
            int workingHour;

            public NhanVien() { }

            public NhanVien(string name, int age, string address, double salary, int workingHour)
            {
                this.name = name;
                this.age = age;
                this.address = address;
                this.salary = salary;
                this.workingHour = workingHour;
            }
            
            public string Name
            {
                get { return name;}
                set { name = value; }
            }

            public int Age
            {
                get { return age; } 
                set { age = value; }
            }

            public string Address
            {
                get { return address; }
                set
                {
                    address = value;
                }
            }

            public double Salary
            {
                get { return salary; }
                set
                {
                    salary = value;
                }
            }

            public int WorkingHour
            {
                get { return workingHour; }
                set { workingHour = value;}
            }

            public void inputInfor()
            {
                bool invalidInput = false;
                while(!invalidInput)
                {
                    Console.Write("Input name: ");
                    name = Console.ReadLine();
                    Console.Write("Input age: ");
                    if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                    {
                        Console.Write("Input address: ");
                        address = Console.ReadLine();
                        Console.Write("Salary: ");
                        if (double.TryParse(Console.ReadLine(), out salary) && salary > 0)
                        {
                            Console.Write("Sum hours working: ");
                            if (int.TryParse(Console.ReadLine(), out workingHour))
                            {
                                invalidInput= true;
                            }
                        }
                    }
                    if (!invalidInput)
                    {
                        Console.WriteLine("Invalid input, try again!");
                    }
                }
            }

            public void printInfo()
            {
                Console.WriteLine("Name: ", name);
                Console.WriteLine("Age: ", age); 
                Console.WriteLine("Address: ", address);
                Console.WriteLine("Salary: ", salary);
                Console.WriteLine("Sum working hour: ", workingHour);
            }

            public double tinhThuong()
            {
                if (workingHour >= 200)
                {
                    return 0.2 * salary;
                }
                else if (workingHour < 200 && workingHour >= 100)
                {
                    return 0.1 * salary;
                }
                else return 0;
            }
        }
    }
}
