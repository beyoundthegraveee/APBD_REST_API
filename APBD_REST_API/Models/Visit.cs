namespace APBD_REST_API;

public class Visit
{

    public Animal Animal { get; set; }

    public string text { get; set; }

    public double cost { get; set; }
    public DateTime DateTime { get; set; }


    public Visit(Animal animal, string text, double cost, DateTime dateTime)
    {
        Animal = animal;
        this.text = text;
        this.cost = cost;
        DateTime = dateTime;
    }
}