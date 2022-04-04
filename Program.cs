using DSharpPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;



namespace my_discord_bot_v2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {

                Token = "OTYwNDU2NzI5MDkzNjIzODA4.YkqtCA.1wZDEFY3IT3ODDXuv3Hs6ZlNIHU",
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });

            discord.MessageCreated += async (s, meseges) =>
            {
                
                if(meseges.Message.Content.ToLower().StartsWith("ramadan karim"))
                    await meseges.Message.RespondAsync("RamadanKom Karim    :) ");
                if (meseges.Message.Content.ToLower().StartsWith("ey"))
                    await meseges.Message.RespondAsync("Wsup!");
                if (meseges.Message.Content.ToLower().StartsWith("eid mobark"))
                    await meseges.Message.RespondAsync("EidKom Mobark  :)");
            };


            await discord.ConnectAsync();
                await Task.Delay(-1);


        }
      





}
}
