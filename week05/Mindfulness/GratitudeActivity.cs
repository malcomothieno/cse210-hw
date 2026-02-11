
using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
    {
        _name = "Gratitude Activity";
        _description = "Focus on gratitude to improve positivity.";
    }

    protected override void PerformActivity()
    {
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("What are you grateful for? ");
            Console.ReadLine();
        }
    }
}
