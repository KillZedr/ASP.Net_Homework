using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPeople.decPeople
{
    public class EnglishPeople : People
    {
        public EnglishPeople() 
        {
            this.sayMyHello = "Hi";
        }

    }
}
