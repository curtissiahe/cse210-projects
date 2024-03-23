using System;

public class MathAssigment
{
    private  string _textbookSection;
    private string _problem;

    public string GetHomeworkList()
    {
        return _textbookSection + _problem;
    }
}