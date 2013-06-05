using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        Order Order { get; set; }

        ICommandExecutionResult Execute();

        ICommandUndoResult Undo();
    }

    public interface ICommandExecutionResult
    {
        bool Success { get; set; }
    }

    public interface ICommandUndoResult
    {
        bool Success { get; set; }
    }
}
