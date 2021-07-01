using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_debugTime.com.ClassAndObjects
{
    class ClassExample
    {
        // Declare variables and functions as 'public' to access them in other class with object referece
        public string name;
        public int age;
        public int marks;

        public void detail() {
            Console.WriteLine("User Name: {0}", name);
            Console.WriteLine("User Age: {0}", age);
            Console.WriteLine("User Marks: {0}", marks);
        }
    }
}
