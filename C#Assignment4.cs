using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    /*Create a custom Stack class MyStack<T> that can be used with any data type which
    has following methods
    1. int Count()
    2. T Pop()
    3. Void Push()*/

    public class MyStack<T>
    {
        private List<T> stack = new List<T>();
        public int count()
        {
            return stack.Count();
        }
        public T Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Pop Error: Cannot pop item from empty stack.");
            }
            T item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return item;
        }
        public void Push(T item)
        {
            stack.Add(item);
        }
    }

    /*Create a Generic List data structure MyList<T> that can store any data type.
    Implement the following methods.
    1. void Add (T element)
    2. T Remove (int index)
    3. bool Contains (T element)
    4. void Clear ()
    5. void InsertAt (T element, int index)
    6. void DeleteAt (int index)
    7. T Find (int index)*/
    public class MyList<T>
    {
        private List <T> list = new List<T>();
        public void Add(T element)
        {
            list.Add(element);
        }
        public T Remove(int index)
        {
            if(index <0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException("Remove Error: Index is out of range");
            }
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }
        public bool Contains(T element)
        {
            return list.Contains(element);
        }
        public void Clear()
        {
            list.Clear();
        }
        public void InsertAt(T element,  int index)
        {
            if(index <0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException("Tnsert Error: Index is out of range.");
            }
            list.Insert(index, element);
        }
        public void RemoveAt(int index) { 
            if( index <0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException("Delete Error: Index is our of range.");
            }
            list.RemoveAt(index);
        }
        public T Find(int index)
        {
            if(index < 0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException("Find Error: Index is our of range.");
            }
            return list[index];
        }
        /*Implement a GenericRepository<T> class that implements IRepository<T> interface
        that will have common /CRUD/ operations so that it can work with any data source
        such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
        on T were it should be of reference type and can be of type Entity which has one
        property called Id. IRepository<T> should have following methods
        1. void Add(T item)
        2. void Remove(T item)
        3. Void Save()
        4. IEnumerable<T> GetAll()
        5. T GetById(int id)
         */
        public abstract class Entity
        {
            public int Id { get; set; }
            public interface IRepository<T> where T : Entity
            {
            void Add(T item);
            void Remove(T item);
            }
            public class GenericRepository<T> : IRepository<T> where T : Entity
            {
                private readonly List<T> _items = new List<T>();

                public int Id { get; private set; }

                public GenericRepository(List<T> list)
                {
                    _items = list;
                }
                public void Add(T item)
                {
                    item.Id = !_items.Any() ? 1 : _items.Max(i => i.Id) + 1;
                    _items.Add(item);
                }
                public void Remove(T item)
                {
                    _items.Remove(item);
                }
                public void Save()
                {
                    Console.WriteLine("Saved");
                }
                public IEnumerable<T> GetAll()
                {
                    return _items;
                }

                public int GetId()
                {
                    return Id;
                }

                public T FindById(int id)
                {
                    return _items.FirstOrDefault(i=>i.Id ==id);
                }
            }
        }
    }
    private static void Main(string[] args)
    {
        MyStack<string> stack = new MyStack<string>();
        stack.Push("Hello");
        stack.Push("World!");
        Console.WriteLine("The stack contains "+stack.count()+" strings in stack.");

        MyList<string> list = new MyList<string>();
        list.Add("Hello");
        list.Add("World!");
    }
}