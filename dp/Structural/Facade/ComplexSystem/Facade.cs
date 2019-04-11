using System;
namespace dp.Structural.Facade.ComplexSystem
{
    public class Facade
    {
        private SubsystemA _systemA;
        private SubsystemB _systemB;
        private SubsystemC _systemC;

        public Facade(SubsystemA systemA, SubsystemB systemB, SubsystemC systemC)
        {
            this._systemA = systemA;
            this._systemB = systemB;
            this._systemC = systemC;
        }

        public void Operation1()
        {
            _systemA.OperationA1();
            _systemA.OperationA2();
            _systemC.OperationC2();
        }

        public void Operation2()
        {
            _systemB.OperationB1();
            _systemC.OperationC3();
            _systemB.OperationB2();
            _systemC.OperationC1();
        }
    }
}
