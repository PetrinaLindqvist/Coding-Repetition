namespace exercise_124
{
    public class Cat
    {
        private string name;
        private int age;

        public Cat(string name)
        {
            this.name = name;
            this.age = 0;
        }
        public void GrowOlder(int years)
        {
            this.age += years;
        }

        public override string ToString()
        {
            return this.name + ", " + this.age + " years.";
        } 
    }
}