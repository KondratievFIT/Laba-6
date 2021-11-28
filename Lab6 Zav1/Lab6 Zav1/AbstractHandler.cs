using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab6Work1
{
    class AbstractHandler
    {
        public static string directory, direct, type, name, basic = @"C:\Users\user\Desktop\", FinalDirectory, NewText, OldText;
        public static string FirstStepInput = "";
        public static string SecondStepDirectoryInput = "";
        public AbstractHandler()
        {
            FirstStep();
        }
        public static void FirstStep()
        {
            Console.WriteLine("Выберите один из следующих вариантов действий: ");
            Console.WriteLine("================================================================================");
            Console.WriteLine("Нажмите на цифру '1', если вы хотите ввести директорию существующего документа");
            Console.WriteLine("для дальнейших с ним операций");
            Console.WriteLine("================================================================================");
            Console.WriteLine("Нажмите на цифру '2', если вы хотите создать новый документ");
            Console.WriteLine("================================================================================");
            FirstStepInput = Console.ReadLine();
            if (FirstStepInput == "1")
            {
                Directory();
                SecondStepDirectory();
            }
            else if (FirstStepInput == "2")
            {
                SecondStepCreate();
            }
        }
        public static void SecondStepDirectory()
        {
            Console.WriteLine("Что делать с выбраным файлом? ");
            Console.WriteLine("Нажмите на цифру '1', если вы хотите определить тип файла");
            Console.WriteLine("Нажмите на цифру '2', если вы хотите удалить файл");
            Console.WriteLine("Нажмите на цифру '3', если вы хотите открыть файл");
            SecondStepDirectoryInput = Console.ReadLine();
            if (SecondStepDirectoryInput == "1")
            {
                direct = directory;
                directory = directory.Trim('"');
                directory = directory.Substring(directory.Length - 3);
                direct = direct.Trim('"');
                direct = direct.Substring(direct.Length - 4);
                if (directory == "txt")
                {
                    Console.WriteLine("Тип файла: txt");
                }
                else if (directory == "png")
                {
                    Console.WriteLine("Тип файла: png");
                }
                else if (directory == "pdf")
                {
                    Console.WriteLine("Тип файла: pdf");
                }
                if (direct == "docx")
                {
                    Console.WriteLine("Тип файла: docx");
                }
                else if (direct == "pptx")
                {
                    Console.WriteLine("Тип файла: pptx");
                }
                else if (direct == "xlsx")
                {
                    Console.WriteLine("Тип файла: xlsx");
                }
            }
            else if (SecondStepDirectoryInput == "2")
            {
                File.Delete(directory);
                Console.WriteLine("Файл был успешно удален!");
            }
            else if (SecondStepDirectoryInput == "3")
            {
                OldText = Convert.ToString(File.ReadAllText(directory));
                Console.WriteLine("Информация внутри файла: " + OldText);
                Console.WriteLine("Введите текст, который хотите добавить в файл: ");
                NewText = Console.ReadLine();
                File.AppendAllText(directory, NewText);
            }
        }
        public static void SecondStepCreate()
        {
            Console.WriteLine("Какой тип файла создать? ");
            Console.WriteLine("Введите '1', - .txt");
            Console.WriteLine("Введите '2', - .docx");
            Console.WriteLine("Введите '3', - .png");
            Console.WriteLine("Введите '4', - .pptx");
            Console.WriteLine("Введите '5', - .pdf");
            Console.WriteLine("Введите '6', - .xlsx");
            type = Console.ReadLine();
            Console.WriteLine("Введите имя файла: ");
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
            FinalDirectory = basic + name + type;
            File.Create(FinalDirectory).Dispose();
            Console.WriteLine("Файл был успешно создан");
        }
        public static void Directory()
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("Введите директорию существующего файла: ");
            directory = Console.ReadLine();
        }
    }
}