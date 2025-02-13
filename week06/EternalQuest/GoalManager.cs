using System.IO;
public class GoalManager 
{
    string fileName;
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    string menuSelection;

    public GoalManager()
    {
    }
    public void Start()
    {
        do {

        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create new Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        menuSelection = Console.ReadLine();
        if (menuSelection == "1")
        {
            CreateGoal();
        }
        else if (menuSelection == "2")
        {
            ListGoalNames();
        }
        else if (menuSelection == "3")
        {
            SaveGoals();
        }
        else if (menuSelection == "6")
        {
            Console.WriteLine("bye :)");
        }
        else {
            Console.WriteLine("Please select a valid option: ");
        }
        } while (menuSelection != "6");
    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {
        Console.WriteLine("The Goals are:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are the following:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?:");
        string election = Console.ReadLine();
        Console.WriteLine("What is the name of the goal?:");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?:");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?:");
        string pointsString = Console.ReadLine();
        int points = int.Parse(pointsString);
        if (election == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (election == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (election == "3")
        {
            Console.WriteLine("How many times does this goal needs to be accomplished for a bonus?:");
            string targetString = Console.ReadLine();
            Console.WriteLine("What is the bonus for accomplishing it that many times?:");
            string bonusString = Console.ReadLine();
            int target = int.Parse(targetString);
            int bonus = int.Parse(bonusString);
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {

        }
    }
    public void RecordEvents()
    {

    }
    public void SaveGoals()
    {
        Console.WriteLine("Please type the name of the file where you will save the goals: ");
        fileName = $"{Console.ReadLine()}.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }
    }
    public void LoadGoals()
    {
        
    }
}