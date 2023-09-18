
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User l1 = new User();
            l1.setProfile("Sidharth", 23);
            l1.getProfile();
            Console.ReadLine();
        }
    }
    class User
    {
        public String name = "SAT";
        private int age;
        public void setProfile(String name, int age)
        {
            this.name = name;
            this.setAge(age);
        }
        private void setAge(int age)
        {
            this.age = age;
        }
        public void getProfile()
        {
            Console.WriteLine("NAME :" + name + " " + "Age :" + age);
        }
    }

}
