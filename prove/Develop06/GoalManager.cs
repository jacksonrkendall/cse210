public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("1: Create Goal\n2: Record Event\n3: List Goals\n4: Show Score\n5: Save Goals\n6: Load Goals\n7: Exit");
            Console.Write("Select an option: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    ListGoals();
                    break;
                case 4:
                    ShowScore();
                    break;
                case 5:
                    SaveGoals();
                    break;
                case 6:
                    LoadGoals();
                    break;
                case 7:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;   
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1: Simple Goal\n2: Eternal Goal\n3: Checklist Goal");
        Console.Write("Select goal type: ");
        int type = int.Parse(Console.ReadLine());
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());
        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid entry");
                break;
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal to record event: ");
        int index = int.Parse(Console.ReadLine());
        if (index < 1 || index > _goals.Count)
        { 
            Console.WriteLine("Invalid selection");
            return;
        }
        Goal selectedGoal = _goals[index - 1];
        selectedGoal.RecordEvent();
        if (selectedGoal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.IsComplete())
            {
                _score += checklistGoal.Bonus;
            }
        }
        _score += selectedGoal.Points;
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void ShowScore()
    {
        Console.WriteLine($"Your score: {_score}");
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

       using (StreamReader reader = new StreamReader("goals.txt"))
       {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(':');
                string goalType = parts[0].Trim();
                string[] details = parts[1].Trim().Split(',');

                string name = details[0].Trim();
                string description = details[1].Trim();
                int points = int.Parse(details[2].Trim().Split(' ')[0]);

                switch (goalType)
                {
                    case "Simple Goal":
                        _goals.Add(new SimpleGoal(name, description, points));
                        break;
                    case "Eternal Goal":
                        _goals.Add(new EternalGoal(name, description, points));
                        break;
                    case "Checklist Goal":
                        int target = int.Parse(details[3].Trim().Split(' ')[0]);
                        int bonus = int.Parse(details[4].Trim().Split(' ')[0]);
                        break;
                }
            }
        }
    }
}