namespace Strategy._01_Example_Ducks._01_Inheritance
{
    public class CloudDuck : Duck
    {
        public override string Display() {
            return nameof(CloudDuck);
        }

        public override string Fly() {
            // The cloud duck can fly,
            // But it's flying behaves very differently
            // and maybe depends on various parameters.
            // On top of that it shares the same exact flying logic
            // as MountainDuck...
            // This means we're not coding "DRY", we're repeating ourselves..
            return "Gliding Flight";
        }
    }
}
