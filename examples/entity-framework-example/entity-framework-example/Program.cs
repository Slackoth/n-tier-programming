using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework_example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (entity_framework_example_connection_string db 
                = new entity_framework_example_connection_string()) 
            {
                // Table instance
                var people = db.people;

                // Create a new record
                /*person oPerson = new person();
                oPerson.name = "Jerry";
                oPerson.age = 15;
                oPerson.id_sex = 1;*/

                //people.Add(oPerson);

                person oPerson = db.people.Find(4);
                oPerson.age = 15;
                //db.people.Remove(oPerson);
                //db.Entry(oPerson).State = System.Data.Entity.EntityState.Deleted;
                db.Entry(oPerson).State = System.Data.Entity.EntityState.Modified;

                // Must do to perputuate changes 
                db.SaveChanges();

                foreach (var person in people)
                {
                    Console.WriteLine("Name: " + person.name);
                }

                Console.Read();
            }
        }
    }
}
