using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class GoalManager
{
    private int _score;
    private List<string> _levels = [];
    private List<Goal> _goals = [];
    private List<List<string>> _goalsData = [];

    public void AddGoal(List<string> newGoal)
    {
        if (newGoal[0] == "S")
        {
            _goals.Add(new SimpleGoal(newGoal));
        }
        else if (newGoal[0] == "E")
        {
            _goals.Add(new EternalGoal(newGoal));
        }
        else if (newGoal[0] == "C")
        {
            _goals.Add(new ChecklistGoal(newGoal));
        }


        //determine which type of goal it is by first one, create a goal, add to list
    }

    public void DisplayGoals()
    {
        int goalNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. {goal.GetData()}");
            goalNumber += 1;
        }
    }
    public void DeleteGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public int CalculateScore()
    {
        _score = 0;
        foreach (Goal goal in _goals)
        {
            _score += goal.CalculatePoints();
        }
        return _score;
    }

    public bool Load(string fileName)
    {
        _goalsData = [];
        string[] rawGoalsData = System.IO.File.ReadAllLines(fileName);
        foreach (string rawGoal in rawGoalsData)
        {
            string[] rawGoalInfoList = rawGoal.Split("|");
            List<string> line = [];
            foreach (string rawGoalInfo in rawGoalInfoList)
            {
                line.Add(rawGoalInfo);
            }
            _goalsData.Add(line);
        }
        foreach (List<string> goalData in _goalsData)
            {
                if (goalData[0] == "S")
                {
                    _goals.Add(new SimpleGoal(goalData));
                }
                else if (goalData[0] == "E")
                {
                    _goals.Add(new EternalGoal(goalData));
                }
                else if (goalData[0] == "C")
                {
                    _goals.Add(new ChecklistGoal(goalData));
                }
            }
        return true;
    }
    public void Save(string fileName)
    {
        using (StreamWriter saveFile = new StreamWriter(fileName, append: false))
        
        foreach (Goal line in _goals)
            {
                saveFile.WriteLine(line.GetStoreData());
            }
    }

}