using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandHandler {
    public class CommandGreet : BaseCommandModule{
        [Command("greet")]
        public async Task GreetCommand(CommandContext context) {
            await context.RespondAsync("Greetings");
        }
    }
}
