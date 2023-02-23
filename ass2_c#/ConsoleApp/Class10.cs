using System.Text;

namespace ConsoleApp
{
    public static class Class10
    {
        public static void ParseUrl(string url)
        {
            StringBuilder protocol = new StringBuilder();
            StringBuilder server = new StringBuilder();
            StringBuilder resource = new StringBuilder();

            string[] firstSplit = url.Split("://");

            if (firstSplit.Length == 1)
            {
                server.Append(firstSplit[0]);
            }
            else if (firstSplit.Length == 2)
            {
                protocol.Append(firstSplit[0]);

                string[] secondSplit = firstSplit[1].Split('/');

                server.Append(secondSplit[0]);
                if (secondSplit.Length == 2)
                {
                    resource.Append(secondSplit[1]);
                }
            }

            Console.WriteLine($"[protocol] = \"{protocol.ToString()}\"");
            Console.WriteLine($"[server] = \"{server.ToString()}\"");
            Console.WriteLine($"[resource] = \"{resource.ToString()}\"");
        }
    }
}
