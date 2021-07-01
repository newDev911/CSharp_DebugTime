using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_debugTime.com.ClassAndObjects
{
    // Computer memory is divided into two parts : STACK --- HEAP
    // Stack memory is much more smaller than Heap memory
    // Value types are stored in Stack Memory
    // Reference types are stored in Heap Memory
    class ValueType_ReferenceType
    {
        int val = 1; // An 'int' is a Value Type -> Stack Memory

        // ValueType_ReferenceType obj = new ValueType_ReferenceType(); // Class Object is a Reference type -> Heap Memory
        public int age;
        public void valueTypeExample()
        {
            Console.WriteLine("Age is : {0}", age);
        }
        public void referenceTypeExample()
        {
            Console.WriteLine("Age is : {0}", age);
        }
    }
}
