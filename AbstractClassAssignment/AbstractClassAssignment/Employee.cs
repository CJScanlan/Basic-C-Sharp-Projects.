using System;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }

        public static bool operator ==(Employee a, Employee b)
        {
            bool equal = a.Id == b.Id;
            return equal;

        }
        public static bool operator !=(Employee a, Employee b)
        {
            bool equal = a.Id != b.Id;
            return equal;
        }
    }
}
