using System;

public class Grades
{
    private int return_grade(double total_percentage)

    {
        string grade = "F";
        if (total_percent >= 90)
        {
            grade = "A";
        }
        else if (total_percent >= 80)
        {
            grade = "B";
        }
        else if (total_percent >= 70)
        {
            grade = "C";
        }
        else if (total_percent >= 60)
        {
            grade = "D";
        }
        return grade;

    }
}
