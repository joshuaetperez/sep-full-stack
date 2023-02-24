namespace ConsoleApp
{
    public abstract class Person : IPersonService
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Addresses { get; set; } = new List<string>();

        private double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0) salary = value;
                else
                {
                    Console.WriteLine("Error: salary cannot be a negative number");
                }
            }
        }

        public Person(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            this.salary = salary;
        }
        public bool AddAddress(string address)
        {
            if (Addresses.Contains(address))
            {
                return false;
            }
            Addresses.Add(address);
            return true;
        }

        public bool RemoveAddress(string address)
        {
            if (Addresses.Contains(address))
            {
                Addresses.Remove(address);
                return true;
            }
            return false;
        }

        public void RemoveAllAddresses()
        {
            Addresses.Clear();
        }

        public void PrintAddresses()
        {
            for (int i = 0; i < Addresses.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(Addresses[i]);
            }
            Console.WriteLine();
        }
    }
}
