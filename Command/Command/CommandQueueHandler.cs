using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CommandQueueHandler
    {
        public Queue<ICommand> Commands { get; set; }

        private int _runPosition = 0;

        public void AddCommandToExecute(ICommand command)
        {
            Commands.Enqueue(command);
        }

        public ICommandExecutionResult Run()
        {
            return Commands.ToArray()[_runPosition++].Execute();
        }

        public ICommandUndoResult Undo()
        {
            --_runPosition;
            return Commands.Dequeue().Undo();
        }

        public CommandQueueHandler()
        {
            Commands = new Queue<ICommand>();
        }
    }
}
