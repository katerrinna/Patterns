using System;

namespace Patterns.Behavioral.Command
{
    public class Parent
    {
        public string ExecuteCommand(ICommand command, string commandArg)
        {
            Console.WriteLine("Громкое ворчание");
            return command.Execute(commandArg);
        }
    }

    public class MakeBreakfastCommand : ICommand
    {
        public string Execute(string command)
        {
            Console.WriteLine($"Готовлю {command} на завтрак!");
            return "Ешь!";
        }
    }
    
    public class WakeMeUpCommand: ICommand
    {
        public string Execute(string command)
        {
            Console.WriteLine($"Я тебя разбужу в {command}");
            return "Ты обязательно проснешься";
        }
    }
}