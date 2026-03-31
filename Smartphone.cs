class Smartphone : Appareil
{
    private int nbCapteursPhoto;

    public int NbCapteursPhoto { get => nbCapteursPhoto; set => nbCapteursPhoto = value; }

    public override void AfficherInfos()
    {
        Console.WriteLine("Marque : " + Marque);
        Console.WriteLine("Modèle : " + Modele);
        Console.WriteLine("Date : " + DateFabrication.ToShortDateString());
        Console.WriteLine("Capteurs photo : " + NbCapteursPhoto);
        Console.WriteLine("Ancienneté : " + CalculerAnciennete() + " ans");
    }

    public override int CalculerAnciennete()
    {
        return DateTime.Now.Year - DateFabrication.Year;
    }
}