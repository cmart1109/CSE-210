public class Activity
{
    private string _name;
    private string _description;
    protected string duration;

    public Activity()
{

}
    public void DisplayStartingMessage()
    {
        Console.WriteLine("This is the Starting Message");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("This is the Ending Message now");
    }
    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Spinner");
    }
    public void ShowCount(int seconds)
    {
        Console.WriteLine("Count");
    }
}