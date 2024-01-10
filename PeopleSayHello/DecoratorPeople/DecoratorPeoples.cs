using Domain;

namespace DecoratorPeople
{
    public abstract class DecoratorPeopleS : People
    {
        protected People peopleBase;

        public DecoratorPeopleS(People peopleDecorator)
        {
            this.peopleBase = peopleDecorator;
        }
        public override string SayHello()
        {
            return  (this.peopleBase.SayHello() + this.sayMyHello);
        }
    }
}
