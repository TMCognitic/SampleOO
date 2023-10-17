using System.Collections;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Pilote pilote = new Pilote()
        {
            Nom = "Doe",
            Prenom = "John",
            Tel = "555-659365",
            Email = "test@test.be",
            Anniversaire = new DateTime(1970, 1, 1),
            Licence = 558251343115816131
        };

        pilote.DireBonjour();
    }    
}

class Entite
{
    public int Id { get; set; }
}

class Article : Entite //<- L'héritage
{

}

class Personne : Entite //<- L'héritage
{
    #region Masqué
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Tel { get; set; }
    public string Email { get; set; }
    public DateTime Anniversaire { get; set; }
    #endregion
    public virtual void DireBonjour()
    {
        Console.WriteLine($"Hello tout le monde");
    }
}

class Pilote : Personne //<- L'héritage
{
    #region Masqué
    public long Licence { get; set; }
    #endregion
    public override void DireBonjour()
    {
        Console.WriteLine($"Hello tout le monde, quelle est notre destination?");
    }
}

class Mecanicien : Personne //<- L'héritage
{
    public override void DireBonjour()
    {
        Console.WriteLine($"Hello tout le monde, ça gaz??");
    }
}

class Professeur : Personne
{

}







