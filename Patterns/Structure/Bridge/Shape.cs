namespace Patterns.Structure.Bridge
{
    public abstract class Shape
    {
        private string _name;
        private Color _color;

        protected Shape(string shapeName, Color color)
        {
            _name = shapeName;
            _color = color;
        }

        public override string ToString()
        {
            return $"Я {_color} {_name}";
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(Color color) : base("Квадрат", color)
        {
        }
    }

    public class Circle : Shape
    {
        public Circle(Color color) : base("Круг", color)
        {
        }
    }
    
    public class Star : Shape
    {
        public Star(Color color) : base("Звезда", color)
        {
        }
    }
}