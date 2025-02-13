using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarttoFinish._6_Interface
{
    class HomeTheater : IElectronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The HomeTheater is Off");
        }

        public void On()
        {
            Console.WriteLine("The HomeTheater is On");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The HomeTheater Volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The HomeTheater Volume is at {Volume}");
        }
    }
}
