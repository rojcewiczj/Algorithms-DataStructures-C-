using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class test
    {

        private string name;

        public test(string name)
        {
            this.name = name;
        }

        public void changeName()
        {
            string new_name = this.name;
            new_name += " addition";
            this.name = new_name;
            Console.WriteLine(this.name);
           
        }
        
    }
}
