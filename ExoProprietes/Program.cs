using ExoProprietes;

internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle()
        {
            Couleur = "vert",
            Longueur = 7,
            Largeur = 5
        };

        Cercle cercle = new Cercle()
        {
            Couleur = "bleu",
            Rayon = 3
        };

        Console.WriteLine($"Périmètre du rectangle {rectangle.Couleur} : {rectangle.Perimetre}");
        Console.WriteLine($"Surface du rectangle {rectangle.Couleur} : {rectangle.Surface}");
        Console.WriteLine($"Périmètre du cercle {cercle.Couleur} : {cercle.Perimetre}");
        Console.WriteLine($"Surface du cercle {cercle.Couleur} : {cercle.Surface}");
    }
}