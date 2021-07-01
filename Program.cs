using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP_debugTime.com.ClassAndObjects;
using CSharpOOP_debugTime.com.Encapsulation;
//using CSharpOOP_debugTime.Constructor_Destructor;

namespace CSharpOOP_debugTime
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassExample obj1 = new ClassExample();
            ValueType_ReferenceType obj2 = new ValueType_ReferenceType();
            ValueType_ReferenceType obj2_1 = new ValueType_ReferenceType();
            EncapsulationExample obj3 = new EncapsulationExample();
            

            /*
            obj1.name = "Hanks";
            obj1.age = 21;
            obj1.marks = 98;
            obj1.detail();
            */
            /*
            obj2.age = 22;
            obj2.valueTypeExample();
            obj2_1.age = 33;
            obj2.valueTypeExample(); // Changes in 'obj2_1.age' won't affect value of 'age' in obj2
            obj2_1 = obj2;
            obj2.age = 44; 
            obj2_1.referenceTypeExample(); // Now 'obj2_1.age' and 'obj2.age' is '44'
            */
            /*
            obj3.SetName("Mark");
            obj3.SetAgeData(-3);
            obj3.SetMarks(-9);

            obj3.detail();
            */

            
            Console.ReadKey();
        }
    }
}
