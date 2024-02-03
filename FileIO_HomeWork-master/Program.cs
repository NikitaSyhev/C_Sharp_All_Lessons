using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату последнего изменения (в формате дд.мм.гггг): ");
            DateTime lastModified = DateTime.Parse(Console.ReadLine()); // считали дату изменения

            Console.Write("Введите имя файла с идентификаторами: "); 
            string fileName = Console.ReadLine(); // считали имя файла

            string[] directories = { Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) };
            // переменная которая содержит путь к файлу "Мой документы" или "Рабочий стол"
            string[] extensions = { ".txt" };// строка записи расширения файла

            foreach (string directory in directories)
            {
                foreach (string extension in extensions)
                {
                    string[] files = Directory.GetFiles(directory, "*" + extension, SearchOption.AllDirectories); // массив который хранит имена всех файлов в directory с extension

                    foreach (string file in files) // цикл по массиву файлов
                    {
                        if (Path.GetFileName(file) == fileName && File.GetLastWriteTime(file) >= lastModified)
                        {
                            Console.WriteLine("Найден файл: " + file);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
    }

