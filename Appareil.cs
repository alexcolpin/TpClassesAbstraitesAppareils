using System;

abstract class Appareil
{
    private string marque;
    private string modele;
    private DateTime dateFabrication;

    public string Marque { get => marque; set => marque = value; }
    public string Modele { get => modele; set => modele = value; }
    public DateTime DateFabrication { get => dateFabrication; set => dateFabrication = value; }

    public void Allumer()
    {
        Console.WriteLine("L'appareil s'allume.");
    }

    public virtual void AfficherType()
    {
        Console.WriteLine("Je suis un appareil.");
    }

    public virtual void AfficherGarantie()
    {
        Console.WriteLine("Garantie standard de l'appareil.");
    }

    public abstract void AfficherInfos();
    public abstract int CalculerAnciennete();
}