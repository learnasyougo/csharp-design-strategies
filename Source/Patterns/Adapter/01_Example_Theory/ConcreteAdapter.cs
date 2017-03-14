using System;

namespace Adapter._01_Example_Theory
{
    public class ConcreteAdapter : IAdapter
    {
        // also known as the adaptee
        private readonly Component _component;

        public ConcreteAdapter(Component component) {
            _component = component;
        }

        public void Operation() {
            _component.SomeOperation();
        }
    }
}
