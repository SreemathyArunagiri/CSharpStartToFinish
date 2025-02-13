using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarttoFinish._6_Interface
{
    interface ICommand
    {
        void Execute();
        void Undo();
        void VolumeDown();
        void VolumeUp();
    }
}
