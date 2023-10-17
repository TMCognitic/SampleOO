namespace ExoProprietes
{
    internal class Rectangle : Forme
    {
        private double _longueur;
        private double _largeur;

        public double Longueur
        {
            get
            {
                return _longueur;
            }

            set
            {
                _longueur = value;
            }
        }

        public double Largeur
        {
            get
            {
                return _largeur;
            }

            set
            {
                _largeur = value;
            }
        }

        public override double Perimetre
        {
            get { return (Longueur + Largeur) * 2; }
        }

        public override double Surface
        {
            get { return Longueur * Largeur; }
        }
    }
}
