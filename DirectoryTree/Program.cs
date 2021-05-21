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
        static List<string> DirectoriesTree(string path, List<string> resultList = null)
        {
            string[] dirs = Directory.GetDirectories(path);

            if (resultList == null)
            {
                resultList = new List<string>();
            }

            if (dirs.Length != 0)
            {
                foreach (string dir in dirs)
                {
                    resultList.Add(dir);
                    DirectoriesTree(dir, resultList);
                }
            }
            return resultList;
        }

    static void Main(string[] args)
        {
            Console.WriteLine("Enter path:");
            string path = Console.ReadLine();
           // List<string> resultList = new List<string>();
            foreach (string dirPath in DirectoriesTree(path))
            {
                Console.WriteLine(dirPath);
            }
            Console.ReadKey();
        }

    }
}
