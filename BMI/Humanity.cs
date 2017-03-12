namespace BMI
{
    public class Humanity
    {
        public string Name { get; set; }
        public double Height { get; private set; }
        public double KG { get; private set; }
        public bool Sex { get; set; }
        private int Light { get; set; }
        private int Fat { get; set; }
        public Health Health { get; private set; }

        public Humanity(string name, double height, double kg, bool sex)
        {
            Name = name;
            Height = height;
            KG = kg;
            KG = kg;
            if (sex)
            {
                Light = 20;
                Fat = 25;
            }
            else
            {
                Light = 18;
                Fat = 22;
            }
        }

        public void SetHealthStatus(double BMI)
        {
            if (BMI < Light)
                Health = Health.過瘦;
            else if (BMI < Fat)
                Health = Health.正常;
            else
                Health = Health.過胖;
        }
    }

    public enum Health
    {
        過瘦, 正常, 過胖
    }
}
