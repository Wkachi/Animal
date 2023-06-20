using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAssignment
{

    public  abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }


        public   string MakeSound()
        {
            Console.WriteLine("Sound");
            return MakeSound();
            
        }
        
           
    }

    
}
