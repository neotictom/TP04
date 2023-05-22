using System.Collections.Generic;
class ORTWorld{
    public static List<string> ListaDestinos{get; private set;} = new List<string> {"Burundi","Butan","India","Namibia","Mauritania","Togo","Nepal","Guyana","Seychelles","Mozambique"};
    public static List<string> ListaHoteles{get; private set;} = new List<string> {"~/img/hotel1.jpg", "~/img/hotel2.jpg","~/img/hotel3.jpg","~/img/hotel4.jpg","~/img/hotel5.jpg","~/img/hotel6.jpg", "~/img/hotel7.jpg","~/img/hotel8.jpg","~/img/hotel9.jpg","~/img/hotel10.jpg"};
    public static List<string> ListaAereos{get; private set;} = new List<string> {"~/img/aereo1.png","~/img/aereo2.jfif","~/img/aereo3.jfif","~/img/aereo4.jpg","~/img/aereo5.jpg","~/img/aereo6.jpg","~/img/aereo7.jpg","~/img/aereo8.jfif","~/img/aereo9.jpg","~/img/aereo10.jfif"};
    public static List<string> ListaExcursiones{get; private set;} = new List<string> {"~/img/excursion1.jfif","~/img/excursion2.jfif","~/img/excursion3.jfif","~/img/excursion4.jfif","~/img/excursion5.jfif","~/img/excursion6.jfif","~/img/excursion7.png","~/img/excursion8.jfif","~/img/excursion9.jpeg","~/img/excursion10.jfif"};
    public static Dictionary<string,Paquete> Paquetes{get; private set;} = new Dictionary<string, Paquete>();
    public static bool hayPaquete{get;private set;} = false;
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
       if (Paquetes.ContainsKey(destinoSeleccionado))
      {
        return false;
      }
      else
      {
        Paquetes.Add(destinoSeleccionado, paquete);
        hayPaquete = true;
        return true;
      }
    }

}