using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPeople.decPeople.DecPeople
{
    public class ItalianDecPeople : DecoratorPeopleS
    {
        public ItalianDecPeople(People peopleDecorator) : base(peopleDecorator)
        {
            this.sayMyHello = "Chao Chicco";
        }
    }
}
