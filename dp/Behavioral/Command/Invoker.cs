using System;
namespace dp.Behavioral.Command
{
    public class Invoker
    {
        public ICommand OnCommand { get; set; }
        public ICommand OffCommand { get; set; }

        public Invoker(ICommand OnCommand, ICommand OffCommand)
        {
            this.OnCommand = OnCommand;
            this.OffCommand = OffCommand;
        }

        public void PressOnButton()
        {
            this.OnCommand.Execute();
        }

        public void PressOffButton()
        {
            this.OffCommand.Execute();
        }
    }
}
