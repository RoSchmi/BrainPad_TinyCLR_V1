using System;
using System.Collections;
using System.Text;
using System.Threading;
using GHIElectronics.TinyCLR.BrainPad;
using System.Diagnostics;


namespace BrainPad_TinyCLR_V1_Blinky
{
    class Program
    {
        static LightBulb lightBulb = new LightBulb();
        static int counter = 0;
        static void Main()
        {
            Thread.Sleep(1000);
            while (true)
            {
                Thread.Sleep(1000);
                lightBulb.TurnBlue();
                counter++;
                Debug.WriteLine("Hello TinyCLR " + counter);
                Thread.Sleep(1000);
                lightBulb.TurnGreen();
            }
        }
    }
}