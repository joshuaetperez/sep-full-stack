namespace ConsoleApp
{
    public class MyStack<T>
    {
        private List<T> stack = new List<T>();
        public int Count()
        {
            return stack.Count;
        }
        public T Pop()
        {
            T item = stack[0];
            stack.RemoveAt(0);
            return item;
        }
        public void Push(T item)
        {
            stack.Insert(0, item);
        }
    }
}
