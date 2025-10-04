namespace Patterns.Structure.Bridge
{
    public abstract class Color
    {
        private string _color;

        protected Color(string color)
        {
            _color = color;
        }
    }

    public class Red : Color
    {
        public Red() : base("Красный")
        {
        }
    }

    public class Blue : Color
    {
        public Blue() : base("Синий")
        {
        }
    }

    public class Green : Color
    {
        public Green() : base("Зеленый")
        {
        }
    }

    public class White : Color
    {
        public White() : base("Белый")
        {
        }
    }
}