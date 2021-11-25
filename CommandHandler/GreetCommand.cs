using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace CommandHandler
{
    public class CommandGreet : BaseCommandModule {
        [Command("greet")]
        public async Task GreetCommand(CommandContext context) {
            await context.RespondAsync($"Hello: {context.Message.Author.Username}");
        }
    }
}
