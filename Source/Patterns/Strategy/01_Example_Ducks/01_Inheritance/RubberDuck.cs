namespace Strategy._01_Example_Ducks._01_Inheritance
{
    public class RubberDuck : Duck
    {
        public override string Quack() {
            return "Plastick Quack";
        }

        public override string Display() {
            return nameof(RubberDuck);
        }

        public override string Fly() {
            // We don't implement fly
            // Because a rubber duck can't fly.
            // So we'll just don't implement it properly and make it do nothing.
            // This feels awkward
            return "";
        }
    }
}
