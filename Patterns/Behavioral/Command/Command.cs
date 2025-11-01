using System;

namespace Patterns.Behavioral.Command
{
    public class Command : IPattern
    {
        public void Example()
        {
            var parent = new Parent();

            var r1 = parent.ExecuteCommand(new MakeBreakfastCommand(), "Яичница");
            var r2 = parent.ExecuteCommand(new WakeMeUpCommand(), "8:00");
            
            Console.WriteLine(r1 + "  " + r2);
        }
    }
}