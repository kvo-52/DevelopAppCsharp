
namespace AppHW_08_SeachFile
{

    //поиск файла и поиск текста в файле написав утилиту, которая ищет файлы определенного расширения с указанным текстом. Рекурсивно.
    internal class Program
    {
        static void Main(string[] args)
        {
            string directory = "D:\\GeekBrains\\БЛОК-3_Developer\\Developer_C#\\2.Csharp_Application\\AppHomeWork\\AppHW_08_SeachFile"; //Путь_к_директории
            string fileName = "testHW08.txt"; //Имя_файла
            string searchText = "hello world"; //поиск текста

            UtilitySeachFile.SearchForFile(directory, fileName); // поиск файла
            UtilitySeachFile.SearchForTextInFile(fileName, searchText); //поиск текста
        }

    }
}