using System;
namespace dp.Behavioral.Command
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
    }
}
