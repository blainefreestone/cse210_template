public class GoalManager
{
    private int _userScore;
    private List<string> _levelNames = new List<string>();
    private List<Goal> _goals = new List<Goal>();
    public GoalManager()
    {
        _levelNames.Add("Beginner Level");
        _levelNames.Add("Bronze Level");
        _levelNames.Add("Silver Level");
        _levelNames.Add("Gold Level");
        _levelNames.Add("Diamond Level");
    }
    public void Start()
    {
        while (true)
        {
            Console.Clear();

            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            
            string userChoice = Console.ReadLine();

            if (userChoice == "1") {CreateGoal();}

            else if (userChoice == "2") 
            {
                Console.Clear();

                int runningCount = 1;
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine(runningCount + ". " + goal.GetDetailsText());
                    runningCount += 1;
                }
                Console.ReadLine();
            }

            else if (userChoice == "3") {SaveGoals();}

            else if (userChoice == "4") {LoadGoals();}

            else if (userChoice == "5") {RecordEvent();}

            else if (userChoice == "6") {break;}
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_userScore} points. You are currently {GetLevelName()}");
    }
    public void ListGoalName()
    {
        int runningCount = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{runningCount}. {goal.GetName()}");
            runningCount += 1;
        }
    }
    public void CreateGoal()
    {
        Console.Clear();
        
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string userChoice = Console.ReadLine();

        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
            
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        string pointValueInText = Console.ReadLine();
        int pointValue = int.Parse(pointValueInText);


        if (userChoice == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, pointValue);
            _goals.Add(simpleGoal);
        }

        else if (userChoice == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, pointValue);
            _goals.Add(eternalGoal);
        }

        else if (userChoice == "3")
        {
            Console.WriteLine("What is the bonus for accomplishing this checklist? ");
            string bonusValueInText = Console.ReadLine();
            int bonusValue = int.Parse(bonusValueInText);
            
            Console.WriteLine("How many times does this goal need to be completed to recieve the bonus? ");
            string targetInText = Console.ReadLine();
            int target = int.Parse(targetInText);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, pointValue, bonusValue, target);
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent()
    {
        Console.Clear();
        
        Console.WriteLine("The goals are:");
        ListGoalName();

        Console.WriteLine("Which goal did you complete? ");
        string goalIndexInText = Console.ReadLine();
        int goalIndex = int.Parse(goalIndexInText);

        int pointsRewarded = _goals[goalIndex - 1].RecordEvent();
        _userScore += pointsRewarded;

        Console.ReadLine();
    }
    public void SaveGoals()
    {
        Console.Clear();
        
        Console.WriteLine("Please enter a filename: ");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_userScore);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetRepresentationText());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Clear();
        
        Console.WriteLine("Please enter a filename: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        string userScoreInText = lines[0];
        _userScore = int.Parse(userScoreInText);

        foreach (string line in lines)
        {   
            string[] parts = line.Split("|");
            
            if (parts.Count() == 1) {continue;}

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];

            string pointValueInText = parts[3];
            int pointValue = int.Parse(pointValueInText);

            if (type == "Checklist")
            {
                string bonusValueInText = parts[3];
                int bonusValue = int.Parse(bonusValueInText);

                string targetInText = parts[4];
                int target = int.Parse(targetInText);

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, pointValue, bonusValue, target);
                _goals.Add(checklistGoal);
            }

            else if (type == "Simple")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, pointValue);
                _goals.Add(simpleGoal);
            }

            else if (type == "Eternal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, pointValue);
                _goals.Add(eternalGoal);
            }
        }
    }
    public string GetLevelName()
    {
        string levelName;
        if (_userScore > 1000) {levelName = _levelNames[3];}
        else if (_userScore > 750) {levelName = _levelNames[2];}
        else if (_userScore > 500) {levelName = _levelNames[1];}
        else if (_userScore > 250) {levelName = _levelNames[0];}
        else {levelName = "No level";}

        return levelName;

    }
}