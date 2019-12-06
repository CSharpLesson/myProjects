using System.Drawing;
using Telegram.Bot;
using Telegram.Bot.Types;
using System.Windows;
using System;
using Telegram.Bot.Types.Enums;
using System.IO;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("866100039:AAEmF8Pu1hqhimHXh4_62RBNfv28ZeAlQWM"); //token yozish uchun
        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;
            Bot.OnCallbackQuery += Bot_OnCallbackQuery;
            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static void Bot_OnCallbackQuery(object sender, Telegram.Bot.Args.CallbackQueryEventArgs e)
        {
            Console.WriteLine(e.CallbackQuery.Data);
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            //file jonatishni boshlang'ichi
            var stream = new FileStream(@"C:\Users\User\Desktop\1.jpg", FileMode.Open);  // faylni yuklab olindi          
            var fileToSend = new FileToSend("asdasdas", stream); //filetosendga fileni tiqildi
            var RequestReplyKeyboard = new ReplyKeyboardMarkup(new[]// bu yerda location qabul qilish ishlatilvotdi
                        {
                            new KeyboardButton("Location") { RequestLocation = true } //keyboard bilan locationi qabul qilinvotdi
                        });

            var result = Bot.SendTextMessageAsync(e.Message.Chat.Id, "Who or Where are you?", replyMarkup: RequestReplyKeyboard);
            Console.WriteLine(e.Message.Location.Longitude+ " :Longitude   " + e.Message.Location.Latitude+ " :Latitude"); //locationni langetud va latetudesini consolga yozilvotdi
            Bot.SendLocationAsync(e.Message.Chat.Id, e.Message.Location.Latitude, e.Message.Location.Longitude);
            Bot.SendPhotoAsync(e.Message.Chat.Id, fileToSend);// file jonatildi
            //Console.WriteLine(e.Message.Date);

            if (e.Message.Type==Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {

                
                //Console.WriteLine(result.Result.Location);
                

                //Bot.SendDocumentAsync(e.Message.Chat.Id, file);
                Bot.SendPhotoAsync(e.Message.Chat.Id, fileToSend);                
                Console.WriteLine(e.Message.Chat.Id+"    "+e.Message.Text);
                Bot.SendLocationAsync(e.Message.Chat.Id, 41.3196802f, 69.2428984f);
                

            }
            
        }
    }
}
