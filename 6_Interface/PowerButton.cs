using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarttoFinish._6_Interface
{
    class PowerButton : ICommand
    {
        // Interface reference variable declared
        IElectronicDevice device;

        // Dependency Injection
        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }             
        
        public void Execute()
        {
            this.device.On();
        }

        public void Undo()
        {
            this.device.Off();
        }

        public void VolumeDown()
        {
            this.device.VolumeDown();
        }

        public void VolumeUp()
        {
            this.device.VolumeUp();
        }
    }
}
