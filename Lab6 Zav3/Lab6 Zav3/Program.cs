using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Zav3
{
    public abstract class Person : Visits
    {
        public static string name;
        public static int normal = 15, visit, need;
        public abstract void Do();
    }
    interface Visits
    {
        static void NoDone()
        {
            Console.Write("Потрібно відходити 15 занять!!");
            Console.WriteLine();
        }
        static void Done()
        {
            Console.Write("Ви виконали норму за цей семестр, готуйтесь до здачі нормативів!!");
        }
    }
    class Visiting : Person
    {
        public Visiting()
        {
            Do();
        }
        public override void Do()
        {
            if (visit < 15)
            {
                need = normal - visit;
                Console.WriteLine();
                Console.Write(name);
                Console.WriteLine();
                Visits.NoDone();
                Console.WriteLine("Залишилось:" + (need));
                Console.WriteLine();
            }
            else if (visit >= 15)
            {
                Console.Write(name);
                Console.WriteLine();
                Visits.Done();
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Show();
            }
        }
        public static void Show()
        {
            Console.WriteLine("Введіть імя: ");
            Person.name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введіть к-ть відвідувань: ");
            try
            {
                Person.visit = int.Parse(Console.ReadLine());
                Visiting ws1 = new Visiting();
            }
            catch
            {
                Console.WriteLine("Перевірте правильність вводу к-ті відвідувань");
                Show();
            }
        }
    }
}
