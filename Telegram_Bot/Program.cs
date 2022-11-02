using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using static System.Net.Mime.MediaTypeNames;
using File = System.IO.File;

namespace Telegram_Bot
{
    internal class Program
    {
        const int snus_price = 420;
        const int cocs_price = 550;

        static void Main(string[] args)
        {
            var client = new TelegramBotClient("5634953591:AAGtWvM96zTXzbTyUifgwOLwPul8OIgfkVs");
            client.StartReceiving(Update, Error);
            Console.ReadLine();
        }

        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;

            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message && message.Text != null)
            {
                Console.WriteLine($"{message.Chat.FirstName}({message.Chat.Id}): {message.Text}");
                if (message.Text.ToLower() == "qq")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"Здарова, {message.Chat.Id}");
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Чтоб купить товар введи /buy");
                    return;
                }

                if (message.Text == "/buy")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"Окей, вот цены:\n\nСнюс - {snus_price} грн \nКокс - {cocs_price} грн", replyMarkup: GetInlineButton(1));
                }

                if (update.Type == Telegram.Bot.Types.Enums.UpdateType.CallbackQuery)
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Окей, выбирай что хочешь: ", replyMarkup: GetBuyButtons());
                }

                if (message.Photo != null)
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Нормальное фото, но нужно документом!");
                    return;
                }

                else if (message.Text == "шишки" || message.Text == "снюс")
                {
                    if (message.Text == "снюс")
                    {
                        string imagePath = Path.Combine(Environment.CurrentDirectory, "my_image.jpg");
                        using (var stream = File.OpenRead(imagePath))
                        {
                            await botClient.SendPhotoAsync(message.Chat.Id, new Telegram.Bot.Types.InputFiles.InputOnlineFile(stream));
                            await botClient.SendTextMessageAsync(message.Chat.Id, "не, такое я не продам тебе!");
                        }
                    }
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Ты чё, нарик что-ли? Иди домой!", replyMarkup: null);
                }

                else if (message.Text != null && message.Text == "/help")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Если хотите купить товар - /buy");
                }

                else if (message.Text != null && message.Text == "/ping_all")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "@Serega1527 , @propust1 , @mak_sinus");
                }

            }

            else if (update.Type == Telegram.Bot.Types.Enums.UpdateType.CallbackQuery)
            {
                if (update.CallbackQuery.Data == "1")
                {
                    await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Окей выбирай!", replyMarkup: GetBuyButtons());
                }
            }

        }

        private static IReplyMarkup GetInlineButton(int id)
        {
            return new InlineKeyboardMarkup(new InlineKeyboardButton("купить"){ Text = "Купить", CallbackData = id.ToString()});
        }

        private static IReplyMarkup GetBuyButtons()
        {
            KeyboardButton keyboard = null;
            return new ReplyKeyboardMarkup(keyboard)
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton("снюс"), new KeyboardButton("шишки"), new KeyboardButton("шалуха")},
                    new List<KeyboardButton> { new KeyboardButton("cпайс"), new KeyboardButton("метон") }
                },
                ResizeKeyboard = true
            };
        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    }
}
