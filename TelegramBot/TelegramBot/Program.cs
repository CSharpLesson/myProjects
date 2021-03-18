using System.Drawing;
using Telegram.Bot;
using Telegram.Bot.Types;
using System.Windows;
using System;
using Telegram.Bot.Types.Enums;
using System.IO;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.InlineKeyboardButtons;

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
        //botda rasm jonatish
        /// <summary>
        /// 
        /// </summary>
        public async static void SendPhoto()
        {
            //file jonatishni boshlang'ichi

            var clients = await ClientService.GetAll();
            clients = clients.Where(f => f.IsActive == true).ToList();


            foreach (var client in clients)
            {

                try
                {
                    var stream = File.Open(@"C:\Users\karimbayev_s\Desktop\q.jpg", FileMode.Open);
                    await SendMes(client, stream);
                    stream.Close();
                }
                catch (Exception ex)
                {

                    throw;
                }

            }

        }
        private static async Task SendMes(Client model, FileStream file)
        {
            try
            {
                await Bot.SendPhotoAsync(model.ChatId, file);
                Console.WriteLine(model.Name);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + " " + model.ChatId);
            }
            
        }

        private static void Bot_OnCallbackQuery(object sender, Telegram.Bot.Args.CallbackQueryEventArgs e)
        {
            Console.WriteLine(e.CallbackQuery.Data+" "+e.CallbackQuery.From.Id);
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            //file jonatishni boshlang'ichi
            //var stream = new FileStream(@"C:\Users\User\Desktop\1.jpg", FileMode.Open);  // faylni yuklab olindi          
            //var fileToSend = new FileToSend("asdasdas", stream); //filetosendga fileni tiqildi
            
            var RequestReplyKeyboard = new ReplyKeyboardMarkup(new[]// bu yerda location qabul qilish ishlatilvotdi
                        {
                            new KeyboardButton("Location") { RequestLocation = true } //keyboard bilan locationi qabul qilinvotdi
                        });
            // key board yasash
            var rkm = new ReplyKeyboardMarkup();
            rkm.Keyboard =
         new KeyboardButton[][]
         {
        new KeyboardButton[]
        {
            new KeyboardButton("item"),
            new KeyboardButton("item")
        },
          new KeyboardButton[]
        {
            new KeyboardButton("item")
        }
         };
            var RequestReplyKeyboard = new ReplyKeyboardMarkup(new[]// bu yerda location qabul qilish ishlatilvotdi
                        {
                            new KeyboardButton("Location") { RequestLocation = true } //keyboard bilan locationi qabul qilinvotdi
                        });
                RequestReplyKeyboard.ResizeKeyboard = true;// keyboart buttoni razmerini kichkina qiladi
            Bot.SendTextMessageAsync(e.Message.Chat.Id, "Text", ParseMode.Default, false, false, 0, rkm);
            //inline yasash
            var inlineKeyboard = new InlineKeyboardMarkup(new[] { new[] { InlineKeyboardButton.WithCallbackData("asdas") },
            new[] { InlineKeyboardButton.WithCallbackData("asdasdd" ) } ,
            new[] { InlineKeyboardButton.WithCallbackData("asdasd") } });
            Bot.SendTextMessageAsync(e.Message.Chat.Id, "-->", replyMarkup: inlineKeyboard);

            
            //var result = Bot.SendTextMessageAsync(e.Message.Chat.Id, "Who or Where are you?", replyMarkup: RequestReplyKeyboard);
            //Console.WriteLine(e.Message.Location.Longitude+ " :Longitude   " + e.Message.Location.Latitude+ " :Latitude"); //locationni langetud va latetudesini consolga yozilvotdi

            //Bot.SendPhotoAsync(e.Message.Chat.Id, fileToSend);// file jonatildi
            //Console.WriteLine(e.Message.Date);
            if (e.Message.Location != null)
            {
                Bot.SendLocationAsync(e.Message.Chat.Id, e.Message.Location.Latitude, e.Message.Location.Longitude);
            }
            if (e.Message.Type==Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {
                //Bot.SendPhotoAsync(e.Message.Chat.Id, fileToSend);                
                Console.WriteLine(e.Message.Chat.Id+"    "+e.Message.Text);
               


            }
            
        }
    }
}
