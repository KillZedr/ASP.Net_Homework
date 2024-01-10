using DecoratorPeople.decPeople;
using DecoratorPeople.decPeople.DecPeople;
using Domain;
using System.Xml.Linq;

namespace PeopleSayHello
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Italian people exemple
            ItalianPeople italianPeople = new ItalianPeople();
            italianPeople.Name = "Rikardo";
            Console.WriteLine(italianPeople.Name.ToString() + ":    " + italianPeople.sayMyHello);


            //Italian decPeople exemple

            ItalianDecPeople italianDecPeople = new ItalianDecPeople(italianPeople);
            
            ItalianDecPeople decPeople = new ItalianDecPeople(italianDecPeople);
            decPeople.Name = "Rikardo";

            Console.WriteLine(decPeople.Name + ":     " +  decPeople.sayMyHello);



            //English people exemple

            EnglishPeople englishPeople = new EnglishPeople();
            englishPeople.Name = "Bob";

            Console.WriteLine(englishPeople.Name + ":   " +  englishPeople.sayMyHello);


            // English decPeople exemple 

            EnglishDecPeople englishDecPeople = new EnglishDecPeople(englishPeople);
            EnglishDecPeople englishDec = new EnglishDecPeople(englishDecPeople);

            englishDec.Name = "Bob";

            Console.WriteLine(englishDec.Name + ":   " + englishDec.sayMyHello);

        }
    }
}
