namespace TpClassesAbstraitesAppareils;

class Program
{
    static void Main(string[] args)
    {
        Ordinateur pc1 = new Ordinateur();
        pc1.Marque = "Lenovo";
        pc1.Modele = "ThinkPad";
        pc1.DateFabrication = new DateTime(2020, 1, 1);
        pc1.TailleEcran = 15.6;

        Ordinateur pc2 = new Ordinateur();
        pc2.Marque = "HP";
        pc2.Modele = "Pavilion";
        pc2.DateFabrication = new DateTime(2018, 1, 1);
        pc2.TailleEcran = 14;

        Smartphone tel1 = new Smartphone();
        tel1.Marque = "Apple";
        tel1.Modele = "iPhone 12";
        tel1.DateFabrication = new DateTime(2021, 1, 1);
        tel1.NbCapteursPhoto = 2;

        Smartphone tel2 = new Smartphone();
        tel2.Marque = "Samsung";
        tel2.Modele = "Galaxy S21";
        tel2.DateFabrication = new DateTime(2022, 1, 1);
        tel2.NbCapteursPhoto = 3;

        List<Appareil> liste = new List<Appareil>();
        liste.Add(pc1);
        liste.Add(pc2);
        liste.Add(tel1);
        liste.Add(tel2);

        foreach (Appareil a in liste)
        {
            a.Allumer();
            a.AfficherType();
            a.AfficherGarantie();
            a.AfficherInfos();
            Console.WriteLine("-----");
        }
        Dictionary<string, Appareil> dico = new Dictionary<string, Appareil>();
        dico["ThinkPad"] = pc1;
        dico["iPhone 12"] = tel1;

        Console.WriteLine(dico["ThinkPad"]);
    }
}