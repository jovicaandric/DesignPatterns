using System;
namespace dp.Behavioral.Command
{
    public class LightOffCommand : ICommand 
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            this._light.TurnOff();
        }

        public void Unexecute()
        {
            this._light.TurnOn();
        }
    }
}
