class Paquete{
    public string Hotel{get; private set;}
    public string Aereos{get; private set;}
    public string Excursion{get; private set;}
    public Paquete (string hotel,string aereos,string excursion){
        Hotel = hotel;
        Aereos = aereos;
        Excursion = excursion;
    }
}