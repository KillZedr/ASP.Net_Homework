using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPeople.decPeople
{
    public class ItalianPeople : People
    {
        public ItalianPeople() 
        {
            this.sayMyHello = "chao";
        }
    }
}
