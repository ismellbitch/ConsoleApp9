namespace ConsoleApp9
{
    internal class Diamond
    {
        private string name;
        private string color;
        private double weight;
        private int facetingQuality;

        public Diamond(string name, string color, double weight, int facetingQuality)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
            this.facetingQuality = facetingQuality;
        }

        public string Name { get { return name; } }
        
        public double Weight
        {
            get { return weight; }
            set { if (value > 0) weight = value; }
        }

        public int FacetingQuality
        {
            get { return facetingQuality; }
            set { if (value >= 0 && value <= 10) facetingQuality = value; }
        }

        public virtual double GetDiamondQuality()
        {
            return 0.4 * Weight + 0.6 * FacetingQuality;
        }
    }
}
