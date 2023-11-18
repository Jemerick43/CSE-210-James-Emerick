/*
Name: Checklist
Purpose: Provides functionality for goals which require completion of certain tasks
Author: James Emerick
Date: 11/18/2023
*/
class Checklist : Goals
{
    private bool _isComplete;
    public Checklist() : base()
    {
    }
    public override int IterateGoalCompletion(int jePoints, int jeBonusPoints)
    {
        return jeBonusPoints;
    }
    public bool IsComplete(int jeNumberComplete, int jeNumberToComplete)
    {
        if (jeNumberComplete == jeNumberToComplete)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
        return _isComplete;
    }
}