

class Programm
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: utility.exe <extension> <text>");
            return;
        }

        string extension = args[0];
        string searchPattern = "*" + extension;
        string searchText = args[1];
        string currentDirectory = Directory.GetCurrentDirectory();

        try
        {
            SearchFiles(currentDirectory, searchPattern, searchText);
        }
        catch (Exception ex) 
        {
            Console.WriteLine("An error occurred:"+ ex.Message);
        }


        static void SearchFiles (string directory, string searchPattern, string searchText)
        {
            foreach (string file in Directory.GetFiles(directory, searchPattern)) { 
            if (FileContainsText(file, searchText))
                {
                    Console.WriteLine(file);
                }
            }

            foreach (string subsirectory in Directory.GetDirectories(directory))
            {
                SearchFiles(subsirectory, searchPattern, searchText);
            }
        }


        static bool FileContainsText(string file, string searchText)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(searchText))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }

}