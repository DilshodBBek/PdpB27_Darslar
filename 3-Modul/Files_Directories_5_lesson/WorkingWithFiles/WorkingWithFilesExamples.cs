namespace _3_Modul.Files_Directories_5_lesson.WorkingWithFiles
{
    internal class WorkingWithFilesExamples
    {
        public static void Start()
        {
            DirectoryInfo? currentPath = Directory.GetParent(typeof(WorkingWithFilesExamples).Assembly.Location);
            string? _CurrentPath = currentPath?.Parent?.Parent?.Parent?.ToString();
            _CurrentPath += @"\Files_Directories_5_lesson\MyFolder";
            //_CurrentPath= @"C:\Users\Dilshod.Shodiyev\source\repos\PdpB27_Darslar\3-Modul\Files_Directories_5_lesson\MyFolder"
            
            string[] dirs = Directory.GetDirectories(_CurrentPath, "*", SearchOption.AllDirectories);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }

            string[] files = Directory.GetFiles(_CurrentPath, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                Console.WriteLine(Path.GetFullPath(file));
                var info=new FileInfo(file);
                Console.WriteLine(info.Length+" bytes");
            }

            Console.WriteLine(Directory.Exists(_CurrentPath + @"\mytext.txt"));
            if (!Directory.Exists(_CurrentPath + @"\mytext.txt"))
                Directory.CreateDirectory(_CurrentPath);

            //File.Copy(files[0], @$"{_CurrentPath}\yangiKopiya.txt", true);
            File.Move(files[0], @$"{_CurrentPath}\SubFolderA\sdfsdf.txt");
        }
    }
}
