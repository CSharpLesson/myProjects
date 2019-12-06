using System.Drawing;
using Telegram.Bot;
using Telegram.Bot.Types;
using System.Windows;
using System;
using Telegram.Bot.Types.Enums;
using System.IO;

namespace TelegramBot
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("866100039:AAEmF8Pu1hqhimHXh4_62RBNfv28ZeAlQWM");
        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;
            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }


        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var stream = new FileStream(@"C:\Users\User\Desktop\1.jpg", FileMode.Open);
            //var archive = new FileStream(@"C:\Users\User\Desktop\1.msi", FileMode.Open); 
            var fileToSend = new FileToSend("asdasdas", stream);
            var file = new FileToSend("aa",archive)
            if (e.Message.Type==Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {
                Bot.SendDocumentAsync(e.Message.Chat.Id, file);
                Bot.SendPhotoAsync(e.Message.Chat.Id, fileToSend);                
                Console.WriteLine(e.Message.Chat.Id+"    "+e.Message.Text);

            }
            
        }
    }
}
