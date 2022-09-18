using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryHomework
{
    class Directory
    {
        public string pathDirectory = @"C:\Users\Buxanka\source\repos\2022\С#\DirectoryHomework\bin\Debug\";
        public string myLogDirectory0 = "Directory0";
        public string myLogDirectory1 = "Directory1";
        public string myLogFile = "DirInfo.txt";
        public DateTime date = DateTime.Now;
        public void CreateDirectory(string Name)
        {
            try
            {
                DirectoryInfo _directory = new DirectoryInfo(pathDirectory + Name);
                _directory.Create();
                Console.WriteLine("Каталог успешно создан!");
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так при создании каталога!");
            }
        }
        public void CreateFile(string NameDirectory)
        {
            try
            {
                StreamWriter myStream = new StreamWriter(pathDirectory + NameDirectory + "\\" + myLogFile);
                Console.WriteLine("Файл успешно создан!");
                myStream.WriteLine("Время создания каталога:" + date);
                myStream.Close();

            }
            catch 
            {
                Console.WriteLine("Что-то пошло не так при создании файла!");
                throw;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var directory0 = new Directory();
            directory0.CreateDirectory(directory0.myLogDirectory0);
            directory0.CreateFile(directory0.myLogDirectory0);
            var directory1 = new Directory();
            directory1.CreateDirectory(directory1.myLogDirectory1);
            directory1.CreateFile(directory1.myLogDirectory1);
     
}
    }
}
