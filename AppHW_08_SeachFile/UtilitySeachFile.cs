using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_08_SeachFile
{
    internal class UtilitySeachFile
    {
        public static void SearchForFile(string directory, string fileName)
        {
            var files = Directory.EnumerateFiles(directory, fileName, SearchOption.AllDirectories);
            foreach (var path in files)
            {
                Console.WriteLine($"Искомый файл {fileName} находится по пути: {path}");
            }
           
        }

        public static void SearchForTextInFile(string fileName, string searchText)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(searchText))
                        {
                            Console.WriteLine($"Найдено значение {searchText} в файле {fileName}: {line}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не существует");
            }
        }
    }
}
