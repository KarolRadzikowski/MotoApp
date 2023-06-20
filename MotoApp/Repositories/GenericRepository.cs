using MotoApp.Enities;

namespace MotoApp.Repositories
{
    public class GenericRepository<T>
        where T : class, IEntitis, new()
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }

        }
        public T GetById(int id) => _items.Single(item => item.Id == id);

        public void Remove(T item )
        {
            _items.Remove(item);       
        }
    }

}
