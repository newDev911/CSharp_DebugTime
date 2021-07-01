using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_debugTime.com.Encapsulation
{
    // The purpose of 'Encapsulation' is to prevent alteration of data from outside the class.
    // Encapsulated class has 'getter' and 'setter' functions that are used to read and write data
    
    class EncapsulationExample
    {
        private int age;
        private int marks;
        private string name;

        public void SetAgeData(int a) // Used to set 'age' outside the class
        {
            // It is easy to validate values in these 'getter_setter' functions
            if (age > 0)
            {
                age = a;
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }

        public void SetMarks(int m)
        {
            if (marks > 0)
            {
                marks = m;
            }
            else
            {
                Console.WriteLine("Error: Invalid Age Value");
            }
        }
            public void SetName(String n){
                if(!(string.IsNullOrEmpty(n))){
                    name = n;
                }
                 else
                {
                Console.WriteLine("Error: Invalid Marks Value");
                }
            }

            public void detail()
            {
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Name: {0}", age);
                Console.WriteLine("Name: {0}", marks);
            }
        }
}
