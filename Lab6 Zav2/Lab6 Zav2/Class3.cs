using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Zav2
{
    public interface IRecordable
    {
        void Record();

        void Pause();

        void Stop();
    }
}