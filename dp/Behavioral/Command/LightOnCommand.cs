using System;
namespace dp.Behavioral.Command
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            this._light.TurnOn();
        }

        public void Unexecute()
        {
            this._light.TurnOff();
        }
    }
}
