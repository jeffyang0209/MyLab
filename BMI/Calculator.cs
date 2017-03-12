namespace BMI
{
    public class Calculator
    {
        private double Height { get; set; }
        private double KG { get; set; }

        public Calculator(double height, double kg)
        {
            Height = height;
            KG = kg;
        }

        public Calculator(Humanity humanity)
        {
            Height = humanity.Height;
            KG = humanity.KG;
        }

        public double GetBMI()
        {
            return KG / (Height / 100 * Height / 100);
        }
    }
}
