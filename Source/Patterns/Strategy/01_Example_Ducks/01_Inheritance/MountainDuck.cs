namespace Strategy._01_Example_Ducks._01_Inheritance
{
    public class MountainDuck : Duck
    {
        public override string Display() {
            return nameof(MountainDuck);
        }        

        public override string Fly() {
            // The mountain duck can fly,
            // But it's flying behaves very differently
            // and maybe depends on various parameters.
            // On top of that it shares the same exact flying logic
            // as CloudDuck...
            // This means we're not coding "DRY", we're repeating ourselves..
            return "Gliding Flight";
        }
    }
}
