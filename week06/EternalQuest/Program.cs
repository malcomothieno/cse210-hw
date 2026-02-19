using System;
using System.Collections.Generic;
using System.IO;

// EXCEEDING REQUIREMENTS:
// - Added Level system (user levels up every 1000 points).
// - Added Titles based on level (Beginner, Disciple, Warrior, Saint, Legend).
// - Added NegativeGoal (lose points for bad habits).
// - Added automatic level-up notification.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
