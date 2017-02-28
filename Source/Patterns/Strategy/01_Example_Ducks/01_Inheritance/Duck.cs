namespace Strategy._01_Example_Ducks._01_Inheritance
{
    public class Duck
    {
        public virtual string Quack() {
            return "Regular Quack";
        }
        public virtual string Display() {
            return nameof(Duck);
        }

        public virtual string Fly() {
            return "Flying";
        }
    }
}
