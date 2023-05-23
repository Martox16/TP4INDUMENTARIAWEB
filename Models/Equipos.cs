 static class Equipos
{
    public static List<string> ListaEquipos{get; private set;} = new List<string>{"juventus" , "chelsea" , "barcelona", "liverpool" , "ajax" , "tottenham", "inter", "boca" , "milan" , "napoli" };
    public static List<string> ListaMedias {get; private set;} = new List<string>{"medias.ajax.jpg" , "medias.barcelona.jfif" , "Medias.Boca.png", "medias.chelsea.jfif", "Medias.Inter.jpg", "medias.juventus.jfif", "medias.liverpool.jfif", "Medias.Milan.jfif", "Medias.Napoli.jfif", "medias.tottenham.jpg"};
    public static List<string> ListaPantalones {get; private set;} = new List<string>{"pantalon.ajax.png" , "pantalon.barcelona.png" , "pantalon.boca.png", "pantalon.chelsea.png", "pantalon.inter.png" , "pantalon.juventus.png" , "pantalon.liverpool.jfif" , "pantalon.milan.png" , "pantalon.napoli.png" ,"pantalon.tottenham.png"};
    public static List<string> ListaRemeras {get; private set;} = new List<string>{"remera.ajax.png","remera.barcelona.png" , "remera.boca.png" , "remera.chelsea.png" , "remera.inter.jfif" , "remera.juventus.png" , "remera.liverpool.png" , "remera.milan.jpg" , "remera.napoli.jpg" , "remera.tottenham.jfif"};
    public static Dictionary<string, Indumentaria> EquiposIndumentaria{get; private set;} = new Dictionary<string, Indumentaria>();
    
    static public bool IngresarIndumentaria(string ListaEquipos , Indumentaria objeto)
    {
        bool hayEquipo = false;
        
        if (EquiposIndumentaria.ContainsKey(ListaEquipos))
        {
            hayEquipo = true;
            
        }
        else
        {
            hayEquipo = false;
            EquiposIndumentaria.Add(ListaEquipos , objeto);
        }
        return hayEquipo;
    } 
  
}
