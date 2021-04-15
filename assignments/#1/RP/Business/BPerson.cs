using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;
using Entities;

namespace Business
{
    public class BPerson
    {
        // Listing controller
        public DataTable List()
        {
            DPerson data = new();

            return data.List();
        }

        // Insertion controller
        public string Insert(string name, string lastname, int age, string phone)
        {
            DPerson data = new();
            Person person = new()
            {
                Name = name,
                Lastname = lastname,
                Age = age,
                Phone = phone
            };

            return data.Insert(person);
        }
    }
}
