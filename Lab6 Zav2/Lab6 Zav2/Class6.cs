using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Zav2
{
    class PlayerItem : IMedia
    {
        public PlayerItem()
        {
            DisplayInfo();
        }
        public static void DisplayInfo()
        {
            Console.WriteLine("Директорія файлу: " + IMedia.path);
        }
    }
}
