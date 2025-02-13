using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarttoFinish._6_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
              // TV = TVRemote.GetDevice();
            //IElectronicDevice TV = new Television();
            Television TV = new Television();
            PowerButton tvRemote = new PowerButton(TV);
          
            tvRemote.Execute();
            tvRemote.Undo();
            tvRemote.VolumeDown();
            tvRemote.VolumeUp();

            HomeTheater homeTheater = new HomeTheater();
            PowerButton htRemote = new PowerButton(homeTheater);

            htRemote.Execute();
            htRemote.Undo();
            htRemote.VolumeDown();
            htRemote.VolumeUp();
        }
    }
}
