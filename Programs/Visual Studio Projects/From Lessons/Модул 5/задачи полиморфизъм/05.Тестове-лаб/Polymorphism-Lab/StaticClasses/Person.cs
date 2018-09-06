public class Person
{
    private string name;
    private static int ID = 1;

    public Person(string name)
    {
        this.name = name;
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public static string Something()
    {
        
        return "something";
    }
}