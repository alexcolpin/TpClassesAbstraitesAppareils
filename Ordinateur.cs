class Ordinateur : Appareil
{
    private double tailleEcran;

    public double TailleEcran { get => tailleEcran; set => tailleEcran = value; }

    public override void AfficherType()
    {
        Console.WriteLine("Je suis un ordinateur.");
    }

    public override void AfficherInfos()
    {
        Console.WriteLine("Marque : " + Marque);
        Console.WriteLine("Modèle : " + Modele);
        Console.WriteLine("Date : " + DateFabrication.ToShortDateString());
        Console.WriteLine("Taille écran : " + TailleEcran);
        Console.WriteLine("Ancienneté : " + CalculerAnciennete() + " ans");
    }

    public override int CalculerAnciennete()
    {
        return DateTime.Now.Year - DateFabrication.Year;
    }

    public override string ToString()
    {
        return "Ordinateur - Marque : " + Marque + ", Modèle : " + Modele + ", Taille écran : " + TailleEcran;
    }
}