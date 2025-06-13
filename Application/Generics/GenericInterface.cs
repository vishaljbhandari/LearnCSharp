using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Generics
{
    /*
        Generic interfaces allow you to implement classes to specify the actual data types.
        Consider the following syntax to declare a generic interface −

        public class Repository<T> : IRepository<T>

     */

    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
    }

    public class Repository<T> : IRepository<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }

    class GenericInterface
    {
        public static void Example()
        {
            IRepository<string> stringRepo = new Repository<string>();
            stringRepo.Add("Item 1");
            stringRepo.Add("Item 2");

            foreach (var item in stringRepo.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
