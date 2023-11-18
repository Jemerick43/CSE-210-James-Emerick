/*
Name: Simple
Purpose: Provides behavior for goals which require only completion and points
Author: James Emerick
Date: 11/18/2023
*/
class Simple : Goals
{
    private int _simplePoints;
    private bool _ifComplete;
    public Simple() : base()
    {
    }
    public override int IterateGoalCompletion(int jePoints, int jeDefault = 0)
    {
        _simplePoints = jePoints;
        return _simplePoints;
    }
}