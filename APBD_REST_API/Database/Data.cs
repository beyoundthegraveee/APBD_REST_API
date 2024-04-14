namespace APBD_REST_API.Database;

public class Data
{
    public static List<Animal> _animals = new()
    {
        new Animal(1, "pies", "zwierzę domowe", 36.7, "czarny"),
        new Animal(2, "kot", "zwierzę domowe", 21.2, "rudy"),
        new Animal(3, "papuga", "ptak", 0.05, "niebieski"),
        new Animal(4, "wróbel", "ptak", 0.03, "szary"),
        new Animal(5, "szczupak", "ryba", 2.3, "srebrny"),
        new Animal(6, "okoń", "ryba",0.7, "niebieski")
        
    };
    
    public static List<Visit> _visits = new()
    {
        new Visit(_animals[0], "Wizyta kontrolna", 50.0, new DateTime(2024, 4, 22)),
        new Visit(_animals[1], "Wizyta szczepionkowa", 40.0, new DateTime(2024, 5, 06)),
        new Visit(_animals[1], "Badanie ogólne", 60.0, new DateTime(2024, 1, 15)),
        new Visit(_animals[4], "Leczenie zranienia", 80.0, new DateTime(2024, 7, 11)),
        new Visit(_animals[4], "Badanie profilaktyczne", 30.0, new DateTime(2024, 12, 11)),
        new Visit(_animals[2], "Konsultacja", 45.0, new DateTime(2024, 9, 12))
    };
    
    
    
    
    
    
}