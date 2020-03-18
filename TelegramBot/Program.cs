using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBot
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("1128927381:AAFxiu2Hwqhh-6hXzhQKeHzKmvdOPgSMHBY");
        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_Onmessage;
            Bot.OnMessageEdited += Bot_Onmessage;
            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static void dynamoCommand(Telegram.Bot.Args.MessageEventArgs e ,  string Command)
        {
            Bot.SendTextMessageAsync(e.Message.Chat.Id,Command);
        }

        private static void dynamoMain(Telegram.Bot.Args.MessageEventArgs e)
        {
            Bot.SendTextMessageAsync(e.Message.Chat.Id, @"What do you want to search:
                        /DynamoBuilds
                        /DynamoForum
                        /DynamoDictionary
                        /DynamoPrimer
                        /DynamoPackage
                        /DynamoAPI
                        /DynamoFurther
                        /PythonBasic
                        /pyRevit
                        /revitapidocs
                        ");
        }

        //private static void welcomeDynamo(Telegram.Bot.Args.MessageEventArgs e)
        //{
        //    if ()
        //    {
        //        e.Message.NewChatMembers
        //    }
        //}

       

        private static void Bot_Onmessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                var message = e.Message.Text.ToLower();

                
                if (message.Equals("/help") || message.Equals("help") || message.Equals("/Help@dynamovnbot"))
                {
                   dynamoMain(e);

                }
                if (message.Equals("/dynamobuilds") || message.Equals("dynamobuilds")|| message.Equals("/dynamobuilds@dynamovnbot"))
                {
                    dynamoCommand(e, "http://dynamobuilds.com/");

                }
                if (message.Equals("/dynamoforum") || message.Equals("dynamoforum")|| message.Equals("/dynamoforum@dynamovnbot"))
                {
                    dynamoCommand(e, "https://forum.dynamobim.com/");

                }
                if (message.Equals("/dynamodictionary") || message.Equals("dynamodictionary")|| message.Equals("/dynamodictionary@dynamovnbot"))
                {
                    dynamoCommand(e, "https://dictionary.dynamobim.com/");

                }

                if (message.Equals("/dynamoprimer") || message.Equals("dynamoprimer") || message.Equals("/dynamoprimer@dynamovnbot"))
                {
                    dynamoCommand(e, "https://primer.dynamobim.org/");
                    
                }

                if (message.Equals("/dynamopackage") || message.Equals("dynamopackage") || message.Equals("/dynamopackage@dynamovnbot"))
                {
                    dynamoCommand(e, "https://dynamopackages.com/#");

                }

                if (message.Equals("/dynamoapi") || message.Equals("dynamoapi")|| message.Equals("/dynamoapi@dynamovnbot"))
                {
                    dynamoCommand(e, "https://developer.dynamobim.org/");

                }

                if (message.Equals("/dynamofurther") || message.Equals("dynamofurther")|| message.Equals("/dynamofurther@dynamovnbot"))
                {
                    dynamoCommand(e, "https://dynamopythonprimer.gitbook.io/dynamo-python-primer/");

                }

                if (message.Equals("/pythonbasic") || message.Equals("pythonbasic")|| message.Equals("/pythonbasic@dynamovnbot"))
                {
                    dynamoCommand(e, "https://python.swaroopch.com/basics.html");
                }

                if (message.Equals("/pyrevit") || message.Equals("pyrevit")|| message.Equals("/pyrevit@dynamovnbot"))
                {
                    dynamoCommand(e, "http://wiki.pyrevitlabs.io/");
                }

                if (message.Equals("/revitapidocs") || message.Equals("revitapidocs")||message.Equals("/revitapidocs@dynamovnbot"))
                {
                    dynamoCommand(e, "https://www.revitapidocs.com/");
                    dynamoCommand(e, "https://apidocs.co/apps/");
                }


                if (message.Equals("/revitapi") || message.Equals("revitapi") || message.Equals("/revitapi@dynamovnbot"))
                {
                    dynamoCommand(e, "https://www.revitapidocs.com/");
                    dynamoCommand(e, "https://apidocs.co/apps/");
                }






            }
        }
    }
}
