namespace ConsoleApp
{
    public interface IPersonService
    {
        bool AddAddress(string address);
        bool RemoveAddress(string address);
        void RemoveAllAddresses();
        void PrintAddresses();
    }
}
