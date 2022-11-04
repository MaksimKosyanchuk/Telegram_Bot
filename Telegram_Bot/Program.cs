using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using static System.Net.Mime.MediaTypeNames;
using File = System.IO.File;

namespace Telegram_Bot
{
    internal class Program
    {
        public class rospOnDay
        {
            public class para
            {
                public string name;
                public string prepod;
            }
            public para firstPara_1 = new para();
            public para firstPara_2 = new para();
            public para secondPara_1 = new para();
            public para secondPara_2 = new para();
            public para thirdPara_1 = new para();
            public para thirdPara_2 = new para();
            public para fourthPara_1 = new para();
            public para fourthPara_2 = new para();
        }

        public static rospOnDay mondey = new rospOnDay();
        public static rospOnDay tuesday = new rospOnDay();
        public static rospOnDay wednesday = new rospOnDay();
        public static rospOnDay thursday = new rospOnDay();
        public static rospOnDay friday = new rospOnDay();

        public class time_rosp
        {
            public string time_first;
            public string time_second;
            public string time_third;
            public string time_fourth;
        }
        
        public static time_rosp my_time = new time_rosp();

        private static void initialization()
        {
            mondey.firstPara_1.name = "Мовни компетентности";
            mondey.firstPara_1.prepod = "Федотова Олена Михайливна";
            mondey.firstPara_2.name = "Communication Skills Training, практика";
            mondey.firstPara_2.prepod = "Карпенко Олена Олексиивна";

            mondey.secondPara_1.name = "Основи програмування, практика";
            mondey.secondPara_1.prepod = "Рубель Андрий Сергийович";
            mondey.secondPara_2.name = "";

            mondey.thirdPara_1.name = "Вышмат";
            mondey.thirdPara_1.prepod = "Неопределено";
            mondey.thirdPara_2.name = "";

            mondey.fourthPara_1.name = "Основи инфокомунікаций";
            mondey.fourthPara_1.prepod = "Кожемякіна Надія Володимирвна";
            mondey.fourthPara_2.name = "";
            mondey.fourthPara_2.prepod = "Нет";


            tuesday.firstPara_1.name = "Communication Skills Training, лекция";
            tuesday.firstPara_1.prepod = "Карпенко Олена Олексиивна";
            tuesday.firstPara_2.name = "";

            tuesday.secondPara_1.name = "Нет пар";
            tuesday.secondPara_1.prepod = "Рубель Андрий Сергийович";
            tuesday.secondPara_2.name = "";

            tuesday.thirdPara_1.name = "Вышмат, лекция";
            tuesday.thirdPara_1.name = "Куреннов";
            tuesday.thirdPara_2.name = "";

            tuesday.fourthPara_1.name = "Дискретна математика, лекция";
            tuesday.fourthPara_1.prepod = "Карташов Олексий Вікторович";
            tuesday.fourthPara_2.name = "";


            wednesday.firstPara_1.name = "Вышмат";
            wednesday.firstPara_1.prepod = "Томилова Євгения Павливна";
            wednesday.firstPara_2.name = "Основи професийнои україномовної комунікации, лекция";
            wednesday.firstPara_2.prepod = "Игнатова Лариса Миколаивна";

            wednesday.secondPara_1.name = "Основи инфокомуникаций, лекция";
            wednesday.secondPara_1.prepod = "Кожемякина Надия Володимиривна";
            wednesday.secondPara_2.name = "";

            wednesday.thirdPara_1.name = "Основи професийнои украиномовнои комуникации, практика";
            wednesday.thirdPara_1.prepod = "Игнатова Лариса Миколаивна";
            wednesday.thirdPara_2.name = "";

            wednesday.fourthPara_1.name = "Нет пары";
            wednesday.fourthPara_2.name = "Вища математика, практика";
            wednesday.fourthPara_2.prepod = "Томілова Євгенія Павлівна";


            thursday.firstPara_1.name = "";
            thursday.firstPara_2.name = "";

            thursday.secondPara_1.name = "";
            thursday.secondPara_2.name = "";

            thursday.thirdPara_1.name = "Вища математика, лекціяВища математика, лекція";
            thursday.thirdPara_1.prepod = "Курєннов Сергій Сергійович";
            thursday.thirdPara_2.name = "Нет пары";

            thursday.fourthPara_1.name = "Основи програмування, лекція";
            thursday.fourthPara_1.prepod = "Рубель Олексій Сергійович";
            thursday.fourthPara_2.name = "";


            friday.firstPara_1.name = "Мовні компетентності, практика";
            friday.firstPara_1.prepod = "Федотова Олена Михайлівна";
            friday.firstPara_2.name = "";

            friday.secondPara_1.name = "Основи інфокомунікацій, лекція";
            friday.secondPara_1.prepod = "Кожемякіна Надія Володимирівна";
            friday.secondPara_2.name = "Дискретна математика, лекція";
            friday.secondPara_2.prepod = "Олексій Вікторович";

            friday.thirdPara_1.name = "Физра";
            friday.thirdPara_1.prepod = "Неопределено";
            friday.thirdPara_2.name = "";

            friday.fourthPara_1.name = "Дискретна математика, практика";
            friday.fourthPara_1.prepod = "Карташов Олексій Вікторович";
            friday.fourthPara_2.name = "";

            my_time.time_first = "08:00 ― 09:35";
            my_time.time_second = "09:50 ― 11:25";
            my_time.time_third = "11:55 ― 13:30";
            my_time.time_fourth = "13:45 ― 15:20";
        }


        public static string get_rosp()
        {
            string text = "";
            initialization();
            string day_of_week = checkDay();
            switch (day_of_week)
            {
                case "mondey":
                    text = fillDay(mondey, day_of_week);
                    break;
                case "tuesday":
                    text = fillDay(tuesday, day_of_week);
                    break;
                case "wednesday":
                    text = fillDay(wednesday, day_of_week);
                    break;
                case "thursday":
                    text = fillDay(thursday, day_of_week);
                    break;
                case "friday":
                    text = fillDay(friday, day_of_week);
                    break;
            }

            return text;
        }

        static void Main(string[] args)
        {
            var client = new TelegramBotClient("5634953591:AAGtWvM96zTXzbTyUifgwOLwPul8OIgfkVs");
            client.StartReceiving(Update, Error);
            Console.ReadLine();

        }

        private static string checkDay()
        {
            DayOfWeek dt = DateTime.Now.DayOfWeek;
            return dt.ToString().ToLower();
        }

        private static string fillDay(rospOnDay day, string day_of_week)
        {
            string chisl = "Числ:  ";
            string znam = "Знам:  ";

            string final_text = "Расписание на: ";
            string first_1 = "";
            string first_2 = "";
            string second_1 = "";
            string second_2 = "";
            string third_1 = "";
            string third_2 = "";
            string fourth_1 = "";
            string fourth_2 = "";
            switch (day_of_week)
            {
                case "mondey":
                    final_text += "*Понедельник*\n";
                    break;
                case "tuesday":
                    final_text += "*Вторник*\n";
                    break;
                case "wednesday":
                    final_text += "*Среда*\n";
                    break;
                case "thursday":
                    final_text += "*Четверг*\n";
                    break;
                case "friday":
                    final_text += "*Пятница*\n";
                    break;
            }
            first_1 = day.firstPara_1.name;
            first_2 = day.firstPara_2.name;
            second_1 = day.secondPara_1.name;
            second_2 = day.secondPara_2.name;
            third_1 = day.thirdPara_1.name;
            third_2 = day.thirdPara_2.name;
            fourth_1 = day.fourthPara_1.name;
            fourth_2 = day.fourthPara_2.name;

            final_text += "\n";

            final_text += my_time.time_first + "\n";

            if (first_1 != "" && first_2 != "")
            {
                first_1 = chisl + first_1;
                first_2 = znam + first_2;
                final_text += first_1 + "\n";
                final_text += first_2 + "\n\n";
            }

            else if (first_1 != "" && first_2 == "")
            {
                final_text += first_1;
                final_text += "\n\n";
            }
            
            else if (first_1 == "" && first_2 != "")
            {
                final_text += first_2;
                final_text += "\n\n";
            }

            else if (first_1 == "" && first_2 == "")
            {
                final_text += "Нет пары\n\n";
            }

            final_text += my_time.time_second + "\n";

            if (second_1 != "" && second_2 != "")
            {
                second_1 = chisl + second_1;
                second_2 = znam + second_2;
                final_text += second_1 + "\n";
                final_text += second_2 + "\n\n";
            }
            else if (second_1 != "" && second_2 == "")
            {
                final_text += second_1 + "\n\n";
            }
            else if (second_1 == "" && second_2 != "")
            {
                final_text+= second_2 + "\n\n";
            }
            else if (second_2 == "" && second_1 == "")
            {
                final_text += "Нет пары\n\n";
            }

            final_text += my_time.time_third + "\n";

            if (third_1 != "" && third_2 != "")
            {
                third_1 = chisl + third_1;
                third_2 = znam + third_2;
                final_text += third_1 + "\n";
                final_text+= third_2 + "\n\n";
            }
            else if (third_1 != "" && third_2 == "")
            {
                final_text += third_1 + "\n\n";
            }
            else if (third_1 == "" && third_2 != "")
            {
                final_text  += third_2 + "\n\n";
            }
            else if (third_1 == "" && third_2 == "")
            {
                final_text += "Нет пары\n\n";
            }

            final_text += my_time.time_fourth + "\n";

            if (fourth_1 != "" && fourth_2 != "")
            {
                fourth_1 = chisl + fourth_1;
                fourth_2 = znam + fourth_2;
                final_text += fourth_1 + "\n";
                final_text += fourth_2 + "\n\n";
            }
            else if (fourth_1 != "" && fourth_2 == "")
            {
                final_text += fourth_1 + "\n\n";
            }
            else if (fourth_1 == "" && fourth_2 != "")
            {
                final_text += fourth_2 + "\n\n";
            }
            else if (fourth_1 == "" && fourth_2 == "")
            {
                final_text += "Нет пары";
            }

                return final_text;
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

                if (message.Text == "/get_rosp")
                {
                    string text = get_rosp();
                    await botClient.SendTextMessageAsync(message.Chat.Id, text, parseMode: ParseMode.MarkdownV2);
                }

                if (message.Text == "/buy")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"Окей, вот цены:\n\nСнюс -  грн \nКокс - грн", replyMarkup: GetInlineButton(1));
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
