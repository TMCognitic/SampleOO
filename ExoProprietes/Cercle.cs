namespace ExoProprietes
{
    internal class Cercle : Forme
    {
        public double Rayon { get; set; }

        public override double Perimetre
        {
            get { return 2 * Math.PI * Rayon; }
        }

        public override double Surface
        {
            get { return Math.PI * Math.Pow(Rayon, 2); }
        }
    }
}
