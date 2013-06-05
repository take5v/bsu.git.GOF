using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandHandler = new CommandQueueHandler();
            var order = new Order();

            var addFirstProductCommand = new AddProductCommand
            {
                Order = order,
                Product = new Product
                {
                    Name = "Milk",
                    Count = 10,
                    Price = 2000,
                    Guid = Guid.NewGuid()
                }
            };
            var addSecondProductCommand = new AddProductCommand
            {
                Order = order,
                Product = new Product
                {
                    Name = "Chocolate",
                    Count = 5,
                    Price = 15000,
                    Guid = Guid.NewGuid()
                }
            };

            commandHandler.AddCommandToExecute(addFirstProductCommand);
            commandHandler.AddCommandToExecute(addSecondProductCommand);
            
            commandHandler.Run();
            commandHandler.Run();
        }
    }
}
