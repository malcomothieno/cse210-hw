
using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void Run()
    {
        StartMessage();
        PerformActivity();
        EndMessage();
    }

    protected void StartMessage()
    {
        Console.Clear();
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Spinner(3);
    }

    protected void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Spinner(2);
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        Spinner(3);
    }

    protected void Spinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        int end = seconds * 10;
        for (int i = 0; i < end; i++)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(100);
            Console.Write("\b");
        }
    }

    protected abstract void PerformActivity();
}
