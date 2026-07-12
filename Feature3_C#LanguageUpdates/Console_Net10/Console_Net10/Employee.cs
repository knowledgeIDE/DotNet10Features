namespace Console_Net10;

public class Employee
{
    public string Name 
    { 
        get; 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
               throw new ArgumentException("Name cannot be null or empty.");
            }
            field = value;
        }
    }
}
