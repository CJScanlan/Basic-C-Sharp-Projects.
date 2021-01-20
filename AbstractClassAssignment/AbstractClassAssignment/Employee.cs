using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee/*<T>*/ : Person, IQuittable
    {
        //public List<T> Things { get; set; }
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }

        public static bool operator ==(Employee/*<T>*/ a, Employee/*<T>*/ b)
        {
            bool equal = a.Id == b.Id;
            return equal;

        }
        public static bool operator !=(Employee/*<T>*/ a, Employee/*<T>*/ b)
        {
            bool equal = a.Id != b.Id;
            return equal;
        }
    }
}
