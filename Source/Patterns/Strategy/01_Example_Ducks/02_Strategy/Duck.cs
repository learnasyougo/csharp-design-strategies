using Strategy._01_Example_Ducks._02_Strategy.FlyBehaviours;
using Strategy._01_Example_Ducks._02_Strategy.QuackBehaviours;

namespace Strategy._01_Example_Ducks._02_Strategy
{
    public class Duck
    {
        IQuackBehaviour _quackBehaviour;
        IFlyBehaviour _flyBehaviour;
        
        public Duck(IQuackBehaviour quackBehaviour = null, IFlyBehaviour flyBehaviour = null) {
            _quackBehaviour = quackBehaviour ?? new DefaultQuackBehaviour();
            _flyBehaviour = flyBehaviour ?? new DefaultFlyBehaviour();
        }

        public virtual string Quack() {
            return _quackBehaviour.Quack();
        }
        public virtual string Display() {
            return nameof(Duck);
        }

        public virtual string Fly() {
            return _flyBehaviour.Fly();
        }
    }
}
