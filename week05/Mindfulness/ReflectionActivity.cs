
using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you showed strength.",
        "Think of a time you helped someone.",
        "Think of a time you did something difficult."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn about yourself?",
        "How can you apply this again?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "Reflect on moments of strength and growth.";
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Spinner(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            Spinner(4);
            elapsed += 4;
        }
    }
}
