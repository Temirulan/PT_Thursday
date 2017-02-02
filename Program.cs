using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Person
    {
        string name;
        int age;
        bool canBuyCigarette;

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
            if (this.age >= 18)
            {
                this.canBuyCigarette = true;
            } else
            {
                this.canBuyCigarette = false;
            }
        }

        public override string ToString()
        {
            return "Name: " + this.name + ". Age: " + this.age + ". canBuyCigarette: " + this.canBuyCigarette;
        }
    }

    class Rectangle
    {
        int w, h;
        int area;

        public Rectangle (int w, int h)
        {
            this.w = w;
            this.h = h;
            this.area = this.w * this.h;
        }

        public int H
        {
            get
            {
                return this.h;
            }
            set
            {
                this.h = value;
                this.area = this.w * this.h;
            }
        }
        public int W
        {
            get
            {
                return this.w;
            }
            set
            {
                this.w = value;
                this.area = this.w * this.h;
            }
        }
        public int Area
        {
            get
            {
                return this.area;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Person enteredPerson = new Person(name, age);
            Console.WriteLine(enteredPerson);
            Console.ReadKey();

            Rectangle rectangle1 = new Rectangle(3, 4);
            Console.WriteLine(rectangle1.H);
            rectangle1.Area = 36;
            Console.WriteLine(rectangle1.H);
            Console.ReadKey();
        }
    }
}
