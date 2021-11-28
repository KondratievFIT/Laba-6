using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab6_Zav1
{
    class AbstractHandler
    {
        public static string directory, direct, type, name, EndofDirectory, after, before;
        public static string normal = @"C:\Users\user\Desktop\";
        public static string action1Input = "";
        public static string action2Input = "";
        public AbstractHandler()
        {
            action1();
        }
        public static void action1()
        {
            Console.WriteLine("Виберіть дію: ");
            Console.WriteLine("Введіть цифру -1-,щоб ввести директорію існуючого документа");
            Console.WriteLine();
            Console.WriteLine("Введіть цифру -2-, щоб створити документ");
            action1Input = Console.ReadLine();
            if (action1Input == "1")
            {
                Directory();
                SecondStepDirectory();
            }
            else if (action1Input == "2")
            {
                SecondStepCreate();
            }
        }
        public static void SecondStepDirectory()
        {
            Console.WriteLine("Виберіть дію для цього файла: ");
            Console.WriteLine("Введіть -1-, для визначення типу файла");
            Console.WriteLine("Введіть -2-, для видаоення файлу");
            Console.WriteLine("Введіть -3-, для відкриття файлу");
            action2Input = Console.ReadLine();
            if (action2Input == "1")
            {
                direct = directory;
                directory = directory.Trim('"');
                directory = directory.Substring(directory.Length - 3);
                direct = direct.Trim('"');
                direct = direct.Substring(direct.Length - 4);
                if (directory == "txt")
                {
                    Console.WriteLine("Тип файлу: txt");
                }
                else if (directory == "png")
                {
                    Console.WriteLine("Тип файлу: png");
                }
                else if (directory == "pdf")
                {
                    Console.WriteLine("Тип файлу: pdf");
                }
                if (direct == "docx")
                {
                    Console.WriteLine("Тип файлу: docx");
                }
                else if (direct == "pptx")
                {
                    Console.WriteLine("Тип файлу: pptx");
                }
                else if (direct == "xlsx")
                {
                    Console.WriteLine("Тип файлу: xlsx");
                }
            }
            else if (action2Input == "2")
            {
                File.Delete(directory);
                Console.WriteLine("Файл видалено.");
            }
            else if (action2Input == "3")
            {
                before = Convert.ToString(File.ReadAllText(directory));
                Console.WriteLine("Информація в файлі: " + before);
                Console.WriteLine("Введіте текст, для додавання його в файл: ");
                after = Console.ReadLine();
                File.AppendAllText(directory, after);
            }
        }
        public static void SecondStepCreate()
        {
            Console.WriteLine("Оберіть тип файлу для створення: ");
            Console.WriteLine("Введіть -1-, якщо це .txt");
            Console.WriteLine("Введіть -2-, якщо це .docx");
            Console.WriteLine("Введіть -3-, якщо це .png");
            Console.WriteLine("Введіть -4-, якщо це .pptx");
            Console.WriteLine("Введіть -5-, якщо це .pdf");
            Console.WriteLine("Введіть -6-, якщо це .xlsx");
            type = Console.ReadLine();
            Console.WriteLine("Введіть імя файла: ");
            name = Console.ReadLine();
            if (type == "1")
            {
                type = ".txt";
            }
            else if (type == "2")
            {
                type = ".docx";
            }
            else if (type == "3")
            {
                type = ".png";
            }
            else if (type == "4")
            {
                type = ".pptx";
            }
            else if (type == "5")
            {
                type = ".pdf";
            }
            else if (type == "6")
            {
                type = ".xlsx";
            }
            EndofDirectory = normal + name + type;
            File.Create(EndofDirectory).Dispose();
            Console.WriteLine("Файл створено");
        }
        public static void Directory()
        {
            Console.WriteLine("Введите директорию существующего файла: ");
            directory = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            AbstractHandler filesmanager = new AbstractHandler();
        }
    }
}
