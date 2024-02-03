using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1   //fileSystemLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = (int)'0'; i <= (int)'9'; i++)
            {
                Console.WriteLine(((char)i).ToString() + "имеет код" + i);
            }
            string path;
            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                path = Environment.CurrentDirectory;
             
            }
      


            DirectoryInfo myDirInfo = new DirectoryInfo(path);
            foreach (var item in myDirInfo.EnumerateDirectories())
            {
                Console.WriteLine($"Каталог {item}");
            }
            {
                foreach (var item in myDirInfo.EnumerateFiles())
                {
                    Console.WriteLine($"Файл {item} имеет размер {item.Length} байт был изменен {item.LastWriteTime}");
                    var LastModified = myDirInfo.LastWriteTime;

                    int year = int.Parse(LastModified.ToString("yyyy"));        
                }
            }

            //тоже самой с try....catch


            //try (args.Length > 0)   // выше сделали решение с if else, здесь сжедади решение с tru ...catch
            //{
            //    path = args[0];
            //}
            //catch (Exception e00)
            //{
            //    Console.WriteLine(e00.Message);
            //    path = Environment.CurrentDirectory;
            //}
           
            Console.ReadKey();
            }
        }
    }

