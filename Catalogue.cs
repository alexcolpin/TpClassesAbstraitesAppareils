class CatalogueAppareils
{
    private Dictionary<string, Appareil> appareils;

    public CatalogueAppareils()
    {
        appareils = new Dictionary<string, Appareil>();
    }

    public void AjouterAppareil(Appareil appareil)
    {
        appareils[appareil.Modele] = appareil;
    }

    public void RechercherAppareil(string modele)
    {
        try
        {
            Appareil a = appareils[modele];
            a.AfficherInfos();
        }
        catch
        {
            Console.WriteLine("Aucun appareil trouvé pour cette clé.");
        }
    }
}