using System;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
