using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PRN211_SE_PT3
{
    internal class Ex2_2
    {

        class Person
        {
            string name;
            bool gender;
            string dob;
            string address;

            public Person() { }

            public Person(string name, bool gender, string dob, string address)
            {
                this.name = name;
                this.gender = gender;
                this.dob = dob;
                this.address = address;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public bool Gender
            {
                get => this.gender;
                set => this.gender = value;
            }

            public string Dob
            {
                get => this.dob;
                set => this.dob = value;
            }

            public string Address
            {
                get => this.address;
                set => this.address = value;
            }

            public virtual void inputInfo()
            {
                Console.Write("Input name: ");
                this.name = Console.ReadLine();
                Console.Write("Input gender: (0:Male, 1:Female) ");
                this.gender = (Console.ReadLine() == "1") ? true : false;
                string format = "dd/MM/yyyy";
                Console.Write($"Input DOB (format: {format}): ");
                DateTime dateTime = DateTime.Now;
                if (DateTime.TryParseExact(Console.ReadLine(), format,
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                {
                    this.dob = dateTime.ToString("dd/MM/yyyy");
                }
                Console.Write("Input address: ");
                this.address = Console.ReadLine();
            }

            public virtual void showInfo()
            {
                Console.WriteLine("Name: " + this.name);
                Console.WriteLine("Gender: " + ((this.gender) ? "Male" : "Female"));
                Console.WriteLine("Date of birth: " + this.dob);
                Console.WriteLine("Address: " + this.address);
            }
        }
        class student : Person
        {
            string mssv; //8ky tu
            double point;
            string email;

            public string MSSV
            {
                get=> mssv;
                set => mssv = value;
            }
            public double Point
            {
                get => point;
                set
                {
                    if (value >=0 && value <= 10)
                    {
                        point = value;
                    }
                    else
                    {
                        Console.WriteLine("Point is double and 0<=point<=100!");
                    }
                } 
            }
            public string Email
            {
                get => email;
                set 
                {
                    if (value.Contains("@") && !value.Contains(" "))
                    {
                        email= value;
                    }
                }
            }

            public student() { }

            public override void inputInfo()
            {
                base.inputInfo();
                Console.Write("Input student id: ");
                this.mssv = Console.ReadLine();
                Console.Write("Input student point: ");
                this.point=double.Parse(Console.ReadLine());
                Console.Write("Input email: ");
                this.email = Console.ReadLine();
            }

            public override void showInfo()
            {
                base.showInfo();
                Console.WriteLine("MSSV: "+this.mssv);
                Console.WriteLine("Point: " + this.point);
                Console.WriteLine("Email: " + this.email);
            }

            public bool hocBong()
            {
                if (this.point > 8.0) return true;
                return false;
            }
        }
    }
}
