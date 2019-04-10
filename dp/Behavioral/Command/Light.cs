using System;
namespace dp.Behavioral.Command
{
    public class Light
    {
     
        public void TurnOn()
        {
            Console.WriteLine("Light is turned ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is turned OFF");
        }
    }
}
