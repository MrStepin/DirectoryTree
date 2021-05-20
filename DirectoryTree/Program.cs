using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTree
{
    class Program
    {
        static string DirectoriesTree(string path)
        {
            string[] dirs = Directory.GetDirectories(path);

            if (dirs.Length != 0)
            {
                foreach (string dir in dirs)
                {
                    DirectoriesTree(dir);
                    Console.WriteLine(dir);
                }
            }
            return path;
        }

    static void Main(string[] args)
        {
            Console.WriteLine("Enter path:");
            string path = Console.ReadLine();

            Console.WriteLine(DirectoriesTree(path));
            Console.ReadKey();
        }

    }
}
