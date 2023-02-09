using System.Security.AccessControl;
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






            //DirectoryInfo MyFolderDirectoryInfo = new DirectoryInfo(@"C:\Users\User\Desktop\VS\PdpB27_Darslar\3-Modul\Files_Directories_5_lesson\MyFolder");

            //FileInfo[] dirs = MyFolderDirectoryInfo.GetFiles("*", SearchOption.AllDirectories);

            //foreach (FileInfo dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            string path = @"C:\Users\User\Desktop\VS\PdpB27_Darslar\3-Modul\Files_Directories_5_lesson\MyFolder\";
            FileInfo fileInfo = new FileInfo(path+"123.txt");

            //Console.WriteLine(fileInfo.GetAccessControl(AccessControlSections.All).AuditRuleType);
            //Console.WriteLine(fileInfo.Replace(@"C:\Users\User\Desktop\Abstraction\NewDoc.DOCX", null));
            using (FileStream read = fileInfo.OpenRead())
            {
                //Console.WriteLine(read.Read());
                //Console.WriteLine(read.Read());
                //Console.WriteLine(read.Read());
                char[] buffer = new char[5];

                //Console.WriteLine(read.ReadBlock(buffer,0, 5));
                //Console.WriteLine(buffer[0]);
                //Console.WriteLine(buffer[1]);
                //Console.WriteLine(buffer[2]);
                //Console.WriteLine(buffer[3]);
                //Console.WriteLine(buffer[4]);
                //Console.WriteLine(read.ReadLine());
                //Console.WriteLine(read.ReadLine());
                //Console.WriteLine(read.ReadLine());


                //write.Write("sdgdfg");
                //Console.WriteLine("Salom");
                //string text = File.ReadAllText(path+"rootfile.txt");
                //write.WriteLine(text);
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

            //string text = File.ReadAllText("test.txt");
            //text = text.Replace("some text", "new value");
            //File.WriteAllText("test.txt", text);

            // Write file using StreamWriter  
            //using (StreamWriter writer = new StreamWriter(fullPath))
            //{
            //    writer.WriteLine("Monica Rathbun");
            //    writer.WriteLine("Vidya Agarwal");
            //    writer.WriteLine("Mahesh Chand");
            //    writer.WriteLine("Vijay Anand");
            //    writer.WriteLine("Jignesh Trivedi");
            //}

            //string folder = @"C:\Temp\";
            //// Filename  
            //string fileName = "Salom.txt";
            //string fullPath = folder + fileName;
            //string[] authors = { "Author1", "Author2", "Author3" };
            //File.WriteAllLines(fullPath, authors);

            //// Read entire text file content in one string
            //string text = File.ReadAllText(textFile);
            //Console.WriteLine(text);

            //// Read a text file line by line.
            //string[] lines = File.ReadAllLines(textFile);

            //foreach (string line in lines)
            //    Console.WriteLine(line);

            //// Read file using StreamReader. Reads file line by line
            //using (StreamReader file = new StreamReader(textFile))
            //{
            //    int counter = 0;
            //    string ln;

            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        Console.WriteLine(ln);
            //        counter++;
            //    }
            //    file.Close();
            //    Console.WriteLine($ "File has {counter} lines.");
            //}
        }
    }
}
