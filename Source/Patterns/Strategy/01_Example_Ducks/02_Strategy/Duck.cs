using Strategy._01_Example_Ducks._02_Strategy.DisplayBehaviours;
using Strategy._01_Example_Ducks._02_Strategy.FlyBehaviours;
using Strategy._01_Example_Ducks._02_Strategy.QuackBehaviours;

namespace Strategy._01_Example_Ducks._02_Strategy
{
    public class Duck
    {
        IDisplayBehaviour _displayBehaviour;
        IQuackBehaviour _quackBehaviour;
        IFlyBehaviour _flyBehaviour;
        
        public Duck(
                IDisplayBehaviour displayBehaviour = null,
                IQuackBehaviour quackBehaviour = null, 
                IFlyBehaviour flyBehaviour = null
            ) {
            _displayBehaviour = displayBehaviour ?? new DefaultDisplayBehaviour();
            _quackBehaviour = quackBehaviour ?? new DefaultQuackBehaviour();
            _flyBehaviour = flyBehaviour ?? new DefaultFlyBehaviour();
        }

        public virtual string Quack() {
            return _quackBehaviour.Quack();
        }
        public virtual string Display() {
            return _displayBehaviour.Display(this.GetType());
        }

        public virtual string Fly() {
            return _flyBehaviour.Fly();
        }
    }
}
