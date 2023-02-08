namespace _3_Modul.Files_Directories_5_lesson.WorkingWithFiles
{
    internal class WorkingWithFilesExamples
    {
        public static void Start()
        {
            //Console.WriteLine(Directory.GetCurrentDirectory());

            //DirectoryInfo dirInfo = new(@"C:\Users\User\Desktop\Abstraction\MyFiles1\TestFiles\secondFolder");
            //Console.WriteLine("dirInfo.Name: "+dirInfo.Name);
            //Console.WriteLine("dirInfo.FullNam: "+dirInfo.FullName);
            //Console.WriteLine("dirInfo.CreationTime: "+ new FileInfo(@"C:\Users\User\Desktop\Abstraction\Shape\Circle.cs").CreationTime);
            //Console.WriteLine("dirInfo.Attributes: "+ new FileInfo(@"C:\Users\User\Desktop\Abstraction\Shape\Circle.cs").Attributes);
            //Console.WriteLine("dirInfo.Extension: "+new FileInfo(@"C:\Users\User\Desktop\Abstraction\Shape\Circle.cs").Extension);
            //Console.WriteLine("dirInfo.GetFiles(): "+dirInfo.GetFiles().Count());
            //Console.WriteLine("dirInfo.GetDirectories(): "+dirInfo.GetDirectories().Count());
            // DirectoryInfo directory=   dirInfo.CreateSubdirectory("dsfsfqas.txt");
            //directory.Delete(true);


            //DirectoryInfo? currentPath = Directory.GetParent(typeof(WorkingWithFilesExamples).Assembly.Location);
            //Console.WriteLine(currentPath);
            //DirectoryInfo? _CurrentPath = currentPath?.Parent?.Parent?.Parent;
            //Console.WriteLine(_CurrentPath);
            //_CurrentPath?.CreateSubdirectory(@"\Files_Directories_5_lesson\MyFolder");
            //_CurrentPath= @"C:\Users\Dilshod.Shodiyev\source\repos\PdpB27_Darslar\3-Modul\Files_Directories_5_lesson\MyFolder"






            DirectoryInfo MyFolderDirectoryInfo = new DirectoryInfo(@"C:\Users\User\Desktop\VS\PdpB27_Darslar\3-Modul\Files_Directories_5_lesson\MyFolder");

            FileInfo[] dirs = MyFolderDirectoryInfo.GetFiles("*", SearchOption.AllDirectories);
           
            foreach (FileInfo dir in dirs)
            {
                Console.WriteLine(dir);
            }

            //string[] files = Directory.GetFiles(_CurrentPath, "*", SearchOption.AllDirectories);
            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //    Console.WriteLine(Path.GetFileName(file));
            //    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    Console.WriteLine(Path.GetFullPath(file));
            //    var info=new FileInfo(file);
            //    Console.WriteLine(info.Length+" bytes");
            //}

            //Console.WriteLine(Directory.Exists(_CurrentPath + @"\mytext.txt"));
            //if (!Directory.Exists(_CurrentPath + @"\mytext.txt"))
            //    Directory.CreateDirectory(_CurrentPath);

            ////File.Copy(files[0], @$"{_CurrentPath}\yangiKopiya.txt", true);
            //File.Move(files[0], @$"{_CurrentPath}\SubFolderA\sdfsdf.txt");
        }
    }
}
