using System.Data;
using Data;
using Entities;

namespace Business
{
    class BCategory
    {
        public static DataTable List()
        {
            DCategory data = new DCategory();

            return data.List();
        }

        public static DataTable Search(string value)
        {
            DCategory data = new DCategory();

            return data.Search(value);
        }

        public static string Insert(string name, string description)
        {
            DCategory data = new DCategory();
            string exists = DCategory.Exists(name);

            if (exists.Equals("1"))
                return "Category already exists.";
            else 
            {
                Category obj = new Category
                {
                    Name = name,
                    Description = description
                };

                return data.Insert(obj);
            }
        }

        public static string Update(string name, string description)
        {
            DCategory data = new DCategory();
            string exists = DCategory.Exists(name);

            if (!exists.Equals("1"))
                return "Category does not exists.";
            else
            {
                Category obj = new Category
                {
                    Name = name,
                    Description = description
                };

                return data.Update(obj);
            }
        }

        public static string Delete(int id)
        {
            DCategory data = new DCategory();

            return data.Delete(id);
        }

        public static string Activate(int id)
        {
            DCategory data = new DCategory();

            return data.Activate(id);
        }

        public static string Deactivate(int id)
        {
            DCategory data = new DCategory();

            return data.Deactivate(id);
        }    
    }
}
