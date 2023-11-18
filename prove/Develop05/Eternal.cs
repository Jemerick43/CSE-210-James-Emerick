/*
Name: Eternal
Purpose: Provides functionality for Eternal Goal types
Author: James Emerick
Date: 11/15/2023
*/
class Eternal : Goals
{
    private int _simplePoints;
    private bool _ifComplete;
    public Eternal() : base()
    {
    }
    public override int IterateGoalCompletion(int jePoints, int jeDefault = 0)
    {
        _simplePoints = jePoints;
        return _simplePoints;
    }
}
