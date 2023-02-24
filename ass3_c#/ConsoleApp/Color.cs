namespace ConsoleApp
{
    public class Color
    {
        private int redValue;
        private int greenValue;
        private int blueValue;
        private int alphaValue;

        public int RedValue {
            get { return redValue; }
            set 
            { 
                if (value >= 0 && value <= 255)
                {
                    redValue = value;
                }
                else
                {
                    Console.WriteLine("Non-valid red value");
                }
            }
        }
        public int GreenValue
        {
            get { return greenValue; }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    greenValue = value;
                }
                else
                {
                    Console.WriteLine("Non-valid green value");
                }
            }
        }
        public int BlueValue
        {
            get { return blueValue; }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    blueValue = value;
                }
                else
                {
                    Console.WriteLine("Non-valid blue value");
                }
            }
        }
        public int AlphaValue
        {
            get { return alphaValue; }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    alphaValue = value;
                }
                else
                {
                    Console.WriteLine("Non-valid alpha value");
                }
            }
        }

        public Color(int redValue, int greenValue, int blueValue, int alphaValue)
        {
            this.redValue = redValue;
            this.greenValue = greenValue;
            this.blueValue = blueValue;
            this.alphaValue = alphaValue;
        }
        
        public double GetGrayscaleValue()
        {
            return (double)(redValue + greenValue + blueValue) / 3;
        }
    }
}
