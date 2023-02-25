namespace ConsoleApp
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        List<T> savedList = new List<T>();
        List<T> currentList = new List<T>();
        public void Add(T item)
        {
            currentList.Add(item);
        }
        public void Remove(T item)
        {
            foreach (T item2 in currentList)
            {
                if (item.Id == item2.Id)
                {
                    currentList.Remove(item2);
                    return;
                }
            }
        }
        public void Save()
        {
            savedList = currentList;
        }

        public IEnumerable<T> GetAll()
        {
            return savedList;
        }

        public T GetById(int id)
        {
            return savedList.Find(item => item.Id == id);
        }
    }
}
