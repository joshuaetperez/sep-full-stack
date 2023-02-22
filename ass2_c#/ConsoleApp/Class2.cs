namespace ConsoleApp
{
    public static class Class2
    {
        public static void ManageToDoList()
        {
            string[] toDoList = new string[100];
            int numOfElements = 0;
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, -- to clear, or press ENTER to exit)):");
                string? command = Console.ReadLine();

                if (String.IsNullOrEmpty(command))
                {
                    break;
                }

                if (command[0] == '+')
                {
                    toDoList[numOfElements] = command.Substring(2);
                    numOfElements++;
                }
                else if (command[0] == '-' && command[1] == '-')
                {
                    Array.Clear(toDoList);
                    numOfElements = 0;
                }
                else if (command[0] == '-')
                {
                    int deleteIndex = Array.IndexOf(toDoList, command.Substring(2));
                    if (deleteIndex > -1)
                    {
                        for (int i = deleteIndex; i <= numOfElements; i++)
                        {
                            toDoList[i] = toDoList[i + 1];
                        }
                        numOfElements--;
                    }
                }
                Console.WriteLine("Your To-Do List: ");
                for (int i = 0; i <= numOfElements; i++)
                {
                    Console.WriteLine(toDoList[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
