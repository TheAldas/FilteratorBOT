using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Net;
using Newtonsoft.Json;
using Discord.Rest;
using FiltriBot.Modules;

namespace FiltriBot.Modules
{
    public class TextCommands : ModuleBase<SocketCommandContext>
    {
        [Command("hello")]
        public async Task Echo()
        {
            var embed = new EmbedBuilder();
            embed.WithAuthor(Context.User.Username);
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }
    }
}