namespace Domain
{
    public abstract class People
    {
        
        public string Name { get; set; }
        public string sayMyHello { get; set; }

        public virtual string SayHello()
        {
            return this.sayMyHello;
        }

    }
}
