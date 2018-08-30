using System;
using SlackBotMessages;

namespace IntegrationSlack.ConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            SBMClient client = new SBMClient("https://hooks.slack.com/services/Your/WebHook/Url");
            Message msg = new Message(text:"Seja bem vindo! Jamelão "+ DateTime.Now.ToShortDateString() ,channel: "general", username:"GTS", icon_emoji: ":sunglasses:");
            client.Send(msg);
        }
    }
}
