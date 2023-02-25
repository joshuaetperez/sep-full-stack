// 1)
using ConsoleApp;

MyStack<int> stack = new MyStack<int>();
int initialStackLength = 10;
for (int i = 0; i < initialStackLength; i++)
{
    stack.Push(i);
}

Console.WriteLine($"There are {stack.Count()} values in the stack");

int numOfPops = 5;
for (int i = 0; i < numOfPops; i++)
{
    Console.WriteLine($"Value {i} popped off the stack is: {stack.Pop()}");
}
Console.WriteLine();

// 2)
MyList<int> list = new MyList<int>();
int initialListLength = 8;
for (int i = 0; i < initialListLength; i++)
{
    list.Add(i);
}
list.PrintList();

int removedIndex = 5;
Console.WriteLine($"Removing index {removedIndex} from list...");
list.Remove(removedIndex);
list.PrintList();

Console.WriteLine($"Does the list contain the number 1? {list.Contains(1)}");
Console.WriteLine($"Does the list contain the number {removedIndex}? {list.Contains(removedIndex)}");

Console.WriteLine($"Inserting the value 10 in index {removedIndex}...");
list.InsertAt(10, removedIndex);
Console.WriteLine($"Inserting the value 11 in index 0...");
list.InsertAt(11, 0);
list.PrintList();
Console.WriteLine($"Inserting the value 12 at the end of the list...");
list.InsertAt(12, list.Count());
list.PrintList();

Console.WriteLine($"Deleting element in index {removedIndex}...");
list.DeleteAt(removedIndex);
list.PrintList();
Console.WriteLine($"Deleting element in index 0...");
list.DeleteAt(0);
list.PrintList();
Console.WriteLine($"Deleting element in last index...");
list.DeleteAt(list.Count() - 1);
list.PrintList();

Console.WriteLine($"Element at index {removedIndex} is: {list.Find(removedIndex)}");

Console.WriteLine("Clearing list...");
list.Clear();
Console.WriteLine();

// 3)
GenericRepository<Entity> _repo = new GenericRepository<Entity>();

Console.WriteLine("Addingo to repo...");
_repo.Add(new Entity(1));
_repo.Add(new Entity(2));
_repo.Add(new Entity(3));
_repo.Save();
foreach(Entity item in _repo.GetAll())
{
    Console.WriteLine(item.Id);
}

Console.WriteLine("Removing Entity with Id 1");
_repo.Remove(new Entity(1));
_repo.Save();
foreach (Entity item in _repo.GetAll())
{
    Console.WriteLine(item.Id);
}
Console.WriteLine($"Entity with Id 1 exists? {_repo.GetById(1) != null}");
Console.WriteLine($"Entity with Id 2 exists? {_repo.GetById(2) != null}");





