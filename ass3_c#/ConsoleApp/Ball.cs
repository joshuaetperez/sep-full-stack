namespace ConsoleApp
{
    public class Ball
    {
        public double Size { get; set; }
        public Color Color { get; set; }
        public int TimesThrown { get; set; }

        public Ball(double size, Color color)
        {
            Size = size;
            Color = color;
            TimesThrown = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                TimesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return TimesThrown;
        }
    }
}
