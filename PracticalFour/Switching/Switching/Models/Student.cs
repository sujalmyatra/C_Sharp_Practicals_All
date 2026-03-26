namespace Switching.Models;

internal class Student
{
    public string Name;
    public decimal[] Marks = new decimal[5];

    public static decimal AverageMarks;

    public Student(string name)
    {
        Name = name;
    }

    /// <summary>
    /// this method calculates average of marks
    /// </summary>
    /// <returns></returns>
    public decimal CalculateAverageMarks()
    {
        decimal sum = 0;
        foreach(var mark in Marks)
        {
            sum += mark;
        }
        AverageMarks = sum / 5;

        return AverageMarks;
    }

    /// <summary>
    /// this method calculates minimum out of marks
    /// </summary>
    /// <returns></returns>
    public decimal CalculateMin()
    {
        decimal min = Marks[0];
        foreach(var mark in Marks)
        {
            min = Math.Min(min, mark);
        }
        return min;
    }

    /// <summary>
    /// this method calculates Maximum out of marks
    /// </summary>
    /// <returns></returns>
    public decimal CalculateMax()
    {
        decimal max = Marks[0];
        foreach (var mark in Marks)
        {
            max = Math.Max(max, mark);
        }
        return max;
    }

    /// <summary>
    /// this method calculates grade using average 
    /// </summary>
    /// <returns></returns>
    public string CalculateGrade(decimal marks)
    {
        return marks switch
        {
            > 90 => "A",
            > 80 => "B",
            > 70 => "C",
            <= 70 => "D" 
        }; 
    }
}
