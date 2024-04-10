namespace APBD_REST_API;

public class Animal
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Category { get; set; }

    public double Mass { get; set; }

    public string Color { get; set; }

    public Animal(int id, string name, string category, double mass, string color)
    {
        Id = id;
        Name = name;
        Category = category;
        Mass = mass;
        Color = color;
    }

    
}