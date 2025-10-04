namespace Patterns.Structure.Bridge
{
    public abstract class Shape
    {
        private string _name;

        protected Shape(string shapeName)
        {
            _name = shapeName;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle() : base("Квадрат")
        {
        }
    }

    public class Circle : Shape
    {
        public Circle() : base("Круг")
        {
        }
    }
    
    public class Star : Shape
    {
        public Star() : base("Звезда")
        {
        }
    }
}