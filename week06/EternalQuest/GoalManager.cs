using System;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public int GetScore()
    {
        return _score;
    }

    public int GetLevel()
    {
        return (_score / 1000) + 1;
    }
    public void RecordEvent(int goalNumber)
    {
        if (goalNumber < 1 || goalNumber > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[goalNumber - 1];

        if (goal.IsComplete() && goal is SimpleGoal)
        {
            Console.WriteLine("This goal is already complete.");
            return;
        }

        bool wasComplete = goal.IsComplete();

        goal.RecordEvent();

        _score += goal.GetPoints();

        
        if (goal is ChecklistGoal checklist)
        {
            if (!wasComplete && checklist.IsComplete())
            {
                _score += checklist.GetBonus();
                Console.WriteLine($"Congratulations! You earned a {checklist.GetBonus()} point bonus!");
            }
        }

        Console.WriteLine($"You earned {goal.GetPoints()} points!");
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nThe goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            return;
        }

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');

            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2])
                );

                if (bool.Parse(data[3]))
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2])
                );

                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[3]),
                    int.Parse(data[5])
                );

                int completed = int.Parse(data[4]);

                for (int j = 0; j < completed; j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}