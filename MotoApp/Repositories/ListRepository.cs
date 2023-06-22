using MotoApp.Enities;

namespace MotoApp.Repositories
{
    public class ListRepository<T> : IReposytory<T>
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
           

        }
        public T GetById(int id) => _items.Single(item => item.Id == id);

        public void Remove(T item )
        {
            _items.Remove(item);       
        }

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }
    }

}
