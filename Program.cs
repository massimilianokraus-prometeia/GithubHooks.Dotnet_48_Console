using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubHooks.Dotnet_48_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($".NET Framework \n- Commit Hash: {args[0]} \n - Author: {args[1]} \n - Message: {args[2]}");
        }
    }
}
