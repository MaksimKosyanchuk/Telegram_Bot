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
                public string link;
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

        public static rospOnDay monday = new rospOnDay();
        public static rospOnDay tuesday = new rospOnDay();
        public static rospOnDay wednesday = new rospOnDay();
        public static rospOnDay thursday = new rospOnDay();
        public static rospOnDay friday = new rospOnDay();

        public class time_rosp
        {
            public string time_first_start;
            public string time_first_end;
            public string time_second_start;
            public string time_second_end;
            public string time_third_start;
            public string time_third_end;
            public string time_fourth_start;
            public string time_fourth_end;
        }

        public static time_rosp my_time = new time_rosp();
        public static rospOnDay present_day = new rospOnDay();


        private static void initialization()
        {
            monday.firstPara_1.name = "Мовни компетентности";
            monday.firstPara_1.prepod = "Федотова Олена Михайливна";
            monday.firstPara_1.link = "https://meet.google.com/odi-bdye-gyc";
            monday.firstPara_2.name = "Communication Skills Training, практика";
            monday.firstPara_2.prepod = "Карпенко Олена Олексиивна";
            monday.firstPara_2.link = "https://us05web.zoom.us/j/91661268937";

            monday.secondPara_1.name = "Основи програмування, практика";
            monday.secondPara_1.prepod = "Рубель Андрий Сергийович";
            monday.secondPara_1.link = "https://discord.com/channels/768070349320355840/1019571492222160966";
            monday.secondPara_2.name = "";
            monday.secondPara_2.prepod = "";
            monday.secondPara_2.link = "";

            monday.thirdPara_1.name = "Вышмат";
            monday.thirdPara_1.prepod = "Томілова Євгенія Павлівна";
            monday.thirdPara_1.link = "https://meet.google.com/mbi-mapk-afe";
            monday.thirdPara_2.name = "";
            monday.thirdPara_2.prepod = "";
            monday.thirdPara_2.link = "";

            monday.fourthPara_1.name = "Основи инфокомунікаций";
            monday.fourthPara_1.prepod = "Кожемякіна Надія Володимирвна";
            monday.fourthPara_1.link = "https://meet.google.com/rcf-tjcw-qch";
            monday.fourthPara_2.name = "";
            monday.fourthPara_2.prepod = "";
            monday.fourthPara_2.link = "";


            tuesday.firstPara_1.name = "Communication Skills Training, практика";
            tuesday.firstPara_1.prepod = "Карпенко Олена Олексиивна";
            tuesday.firstPara_1.link = "https://us05web.zoom.us/j/91661268937";
            tuesday.firstPara_2.name = "Communication Skills Training, лекція";
            tuesday.firstPara_2.prepod = "Карпенко Олена Олексиивна";
            tuesday.firstPara_2.link = "https://us05web.zoom.us/j/91661268937";


            tuesday.secondPara_1.name = "Вища математика, практика,";
            tuesday.secondPara_1.prepod = "Томілова Євгенія Павлівна";
            tuesday.secondPara_1.link = "https://meet.google.com/mbi-mapk-afe";
            tuesday.secondPara_2.name = "";
            tuesday.secondPara_2.prepod = "";
            tuesday.secondPara_2.link = "";

            tuesday.thirdPara_1.name = "Вышмат, лекция";
            tuesday.thirdPara_1.prepod = "Куреннов";
            tuesday.thirdPara_1.link = "Неопределено";
            tuesday.thirdPara_2.name = "";
            tuesday.thirdPara_2.prepod = "";
            tuesday.thirdPara_2.link = "";

            tuesday.fourthPara_1.name = "";
            tuesday.fourthPara_1.prepod = "";
            tuesday.fourthPara_1.link = "";
            tuesday.fourthPara_2.name = "Дискретна математика, лекция";
            tuesday.fourthPara_2.prepod = "Карташов Олексий Вікторович";
            tuesday.fourthPara_2.link = "https://us04web.zoom.us/j/78122451647?pwd=FUFeaQgxhlFRQSvraKIVedSGiFM4GI";


            wednesday.firstPara_1.name = "";
            wednesday.firstPara_2.name = "Основи професийнои україномовної комунікации, лекция";
            wednesday.firstPara_2.prepod = "Игнатова Лариса Миколаивна";
            wednesday.firstPara_2.link = "https://meet.google.com/zoq-chgp-dxk";

            wednesday.secondPara_1.name = "Основи инфокомуникаций, лекция";
            wednesday.secondPara_1.prepod = "Кожемякина Надия Володимиривна";
            wednesday.secondPara_1.link = "https://meet.google.com/rcf-tjcw-qch";
            wednesday.secondPara_2.name = "";

            wednesday.thirdPara_1.name = "Основи професийнои украиномовнои комуникации, практика";
            wednesday.thirdPara_1.prepod = "Игнатова Лариса Миколаивна";
            wednesday.thirdPara_1.link = "https://meet.google.com/zoq-chgp-dxk";
            wednesday.thirdPara_2.name = "";

            wednesday.fourthPara_1.name = "Нет пары";
            wednesday.fourthPara_1.prepod = "Неопредлено";
            wednesday.fourthPara_1.link = "Неопределено";
            wednesday.fourthPara_2.name = "Вища математика, практика";
            wednesday.fourthPara_2.prepod = "Томілова Євгенія Павлівна";
            wednesday.fourthPara_2.link = "https://meet.google.com/mbi-mapk-afe";


            thursday.firstPara_1.name = "";
            thursday.firstPara_2.name = "";

            thursday.secondPara_1.name = "Основи програмування, практика";
            thursday.secondPara_1.prepod = "Рубель Андрій Сергійович";
            thursday.secondPara_1.link = "https://discord.com/channels/768070349320355840/1019571492222160966";
            thursday.secondPara_2.name = "";

            thursday.thirdPara_1.name = "";
            thursday.thirdPara_2.name = "";

            thursday.fourthPara_1.name = "Основи програмування, лекція";
            thursday.fourthPara_1.prepod = "Рубель Олексій Сергійович";
            thursday.fourthPara_1.link = "https://us02web.zoom.us/j/89826931650?pwd=aXpvWUFad0o5K0Nnbk1VZVhRNDZiQT09";
            thursday.fourthPara_2.name = "";


            friday.firstPara_1.name = "Мовні компетентності, практика";
            friday.firstPara_1.prepod = "Федотова Олена Михайлівна";
            friday.firstPara_1.link = "https://meet.google.com/odi-bdye-gyc";
            friday.firstPara_2.name = "";

            friday.secondPara_1.name = "Основи інфокомунікацій, лекція";
            friday.secondPara_1.prepod = "Кожемякіна Надія Володимирівна";
            friday.secondPara_1.link = "https://meet.google.com/rcf-tjcw-qch";
            friday.secondPara_2.name = "Дискретна математика, лекція";
            friday.secondPara_2.prepod = "Карташов Олексій Вікторович";
            friday.secondPara_2.link = "https://us04web.zoom.us/j/78122451647?pwd=FUFeaQgxhlFRQSvraKIVedSGiFM4GI.1";

            friday.thirdPara_1.name = "Физра";
            friday.thirdPara_1.prepod = "Неопределено";
            friday.thirdPara_1.link = "";
            friday.thirdPara_2.name = "";

            friday.fourthPara_1.name = "Дискретна математика, практика";
            friday.fourthPara_1.prepod = "Карташов Олексій Вікторович";
            friday.fourthPara_1.link = "https://us04web.zoom.us/j/78122451647?pwd=FUFeaQgxhlFRQSvraKIVedSGiFM4GI.1";
            friday.fourthPara_2.name = "";

            my_time.time_first_start = "08:00";
            my_time.time_first_end = "09:35";
            my_time.time_second_start = "09:50";
            my_time.time_second_end = "11:25";
            my_time.time_third_start = "11:55";
            my_time.time_third_end = "13:30";
            my_time.time_fourth_start = "13:45";
            my_time.time_fourth_start = "13:45";
            my_time.time_fourth_end = "15:20";
        }

        public static string get_rosp()
        {
            string text = "";
            initialization();
            string day_of_week = checkDay();
            switch (day_of_week)
            {
                case "monday":
                    text = fillDay(monday, day_of_week);
                    present_day = monday;
                    break;
                case "tuesday":
                    text = fillDay(tuesday, day_of_week);
                    present_day = tuesday;
                    break;
                case "wednesday":
                    text = fillDay(wednesday, day_of_week);
                    present_day = wednesday;
                    break;
                case "thursday":
                    text = fillDay(thursday, day_of_week);
                    present_day = thursday;
                    break;
                case "friday":
                    text = fillDay(friday, day_of_week);
                    present_day = friday;
                    break;
                case "saturday":
                    text = fillDay(monday, "monday");
                    present_day = monday;
                    break;
                case "sunday":
                    text = fillDay(monday, "monday");
                    present_day = monday;
                    break;
            }

            return text;
        }

        public static string get_day_of_week_name(rospOnDay day)
        {
            string _day = "";
            if (day == monday)
            {
                _day = "Понедельник";
            }
            else if (day == tuesday)
            {
                _day = "Вторник";
            }
            else if (day == wednesday)
            {
                _day = "Среда";
            }
            else if (day == thursday)
            {
                _day = "Четверг";
            }
            else if (day == friday)
            {
                _day = "Пятница";
            }
            return _day;
        }

        static void Main(string[] args)
        {
            var client = new TelegramBotClient("5634953591:AAEWzLkitszQUtwfbizqerd2Y5cwGPlQh2o");
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
                case "monday":
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

            final_text += $"{my_time.time_first_start} ⎯ {my_time.time_third_end} \n";

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

            final_text += $"2➤{my_time.time_second_start} ⎯ {my_time.time_second_end} \n";

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
                final_text += second_2 + "\n\n";
            }
            else if (second_2 == "" && second_1 == "")
            {
                final_text += "Нет пары\n\n";
            }

            final_text += $"3➤{my_time.time_third_start} ⎯ {my_time.time_third_end} \n";

            if (third_1 != "" && third_2 != "")
            {
                third_1 = chisl + third_1;
                third_2 = znam + third_2;
                final_text += third_1 + "\n";
                final_text += third_2 + "\n\n";
            }
            else if (third_1 != "" && third_2 == "")
            {
                final_text += third_1 + "\n\n";
            }
            else if (third_1 == "" && third_2 != "")
            {
                final_text += third_2 + "\n\n";
            }
            else if (third_1 == "" && third_2 == "")
            {
                final_text += "Нет пары\n\n";
            }

            final_text += $"4➤{my_time.time_fourth_start} ⎯ {my_time.time_fourth_end} \n";

            if (fourth_1 != "" && fourth_2 != "")
            {
                fourth_1 = chisl + fourth_1;
                fourth_2 = znam + fourth_2;
                final_text += fourth_1 + "\n";
                final_text += fourth_2;
            }
            else if (fourth_1 != "" && fourth_2 == "")
            {
                final_text += fourth_1;
            }
            else if (fourth_1 == "" && fourth_2 != "")
            {
                final_text += fourth_2 + "";
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
            Message a;

            switch (update.Type)
            {
                case Telegram.Bot.Types.Enums.UpdateType.Message:
                    Console.WriteLine(update.Message.From.Username + $"({update.Message.From.Id}): {update.Message.Text}");
                    string text;
                    if (message.Text != "")
                    {
                        switch (message.Text)
                        {
                            case "/get_rosp@Maks28925_bot":
                                text = get_rosp();
                                a = botClient.SendTextMessageAsync(message.Chat.Id, text, replyMarkup: GetInlineButtonsDays(present_day), parseMode: ParseMode.MarkdownV2).Result;
                                break;

                            case "/help":
                                await botClient.SendTextMessageAsync(message.Chat.Id, "Если хотите купить товар - /buy");
                                break;
                            case "кто гетеро?":
                                await botClient.SendTextMessageAsync(message.Chat.Id, "Андрей гей");
                                break;
                        }
                    }
                    break;

                case Telegram.Bot.Types.Enums.UpdateType.CallbackQuery:
                    string new_text = "";
                    switch (update.CallbackQuery.Data)
                    {
                        case "Понедельник":
                            text = fillDay(monday, "monday");
                            if (text.Replace("*", "") != update.CallbackQuery.Message.Text)
                            {
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(monday), parseMode: ParseMode.MarkdownV2);
                                present_day = monday;
                            }
                            await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                            break;
                        case "Вторник":
                            text = fillDay(tuesday, "tuesday");
                            if (text.Replace("*", "") != update.CallbackQuery.Message.Text)
                            {
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(tuesday), parseMode: ParseMode.MarkdownV2);
                                present_day = tuesday;
                            }
                            await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                            break;
                        case "Среда":
                            text = fillDay(wednesday, "wednesday");
                            if (text.Replace("*", "") != update.CallbackQuery.Message.Text)
                            {
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(wednesday), parseMode: ParseMode.MarkdownV2);
                                present_day = wednesday;
                            }
                            await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                            break;
                        case "Четверг":
                            text = fillDay(thursday, "thursday");
                            if (text.Replace("*", "") != update.CallbackQuery.Message.Text)
                            {
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(thursday), parseMode: ParseMode.MarkdownV2);
                                present_day = thursday;
                            }
                            await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                            break;
                        case "Пятница":
                            text = fillDay(friday, "friday");
                            if (text.Replace("*", "") != update.CallbackQuery.Message.Text)
                            {
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(friday), parseMode: ParseMode.MarkdownV2);
                                present_day = friday;
                            }
                            await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                            break;
                        case "first_chisl":
                            new_text = fill_para(my_time.time_first_start, my_time.time_first_end, present_day.firstPara_1.name, present_day.firstPara_1.prepod, present_day.firstPara_1.link);
                            await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                            break;
                        case "first_znam":
                            new_text = fill_para(my_time.time_first_start, my_time.time_first_end, present_day.firstPara_2.name, present_day.firstPara_2.prepod, present_day.firstPara_2.link);
                            await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                            break;
                        case "second_chisl":
                            new_text = fill_para(my_time.time_second_start, my_time.time_second_end, present_day.secondPara_1.name, present_day.secondPara_1.prepod, present_day.secondPara_1.link);
                            await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                            break;
                        case "second_znam":
                            new_text = fill_para(my_time.time_second_start, my_time.time_second_end, present_day.secondPara_2.name, present_day.secondPara_2.prepod, present_day.secondPara_2.link);
                            await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                            break;
                        case "third_chisl":
                            new_text = fill_para(my_time.time_third_start, my_time.time_third_end, present_day.thirdPara_1.name, present_day.thirdPara_1.prepod, present_day.thirdPara_1.link);
                            await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                            break;
                        case "third_znam":
                            new_text = fill_para(my_time.time_third_start, my_time.time_third_end, present_day.thirdPara_2.name, present_day.thirdPara_2.prepod, present_day.thirdPara_2.link);
                            await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                            break;
                        case "fourth_chisl":
                            new_text = fill_para(my_time.time_fourth_start, my_time.time_fourth_end, present_day.fourthPara_1.name, present_day.fourthPara_1.prepod, present_day.fourthPara_1.link);
                            await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                            break;
                        case "fourth_znam":
                            new_text = fill_para(my_time.time_fourth_start, my_time.time_fourth_end, present_day.fourthPara_2.name, present_day.fourthPara_2.prepod, present_day.fourthPara_2.link);
                            await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                            break;
                    }
                    break;
            }
        }

        private static InlineKeyboardMarkup GetBackButton()
        {
            string data = get_day_of_week_name(present_day);

            return new InlineKeyboardMarkup(new InlineKeyboardButton("Назад") { Text = "Назад", CallbackData = data });
        }

        private static string fill_para(string time_start, string time_end, string para_name, string prepod, string link)
        {
            string _day = "";
            if (present_day == monday)
            {
                _day = "Понедельник";
            }
            else if (present_day == tuesday)
            {
                _day = "Вторник";
            }
            else if (present_day == wednesday)
            {
                _day = "Среда";
            }
            else if (present_day == thursday)
            {
                _day = "Четверг";
            }
            else if (present_day == friday)
            {
                _day = "Пятница";
            }
            string text = "";
            text += $"День: {_day} \n";
            text += $"Начало: {time_start}\n";
            text += $"Конец: {time_end}\n\n";
            text += $"{para_name}\n\n";
            text += $"Преподаватель: {prepod}\n\n";
            text += $"Ссылка: {link}";
            return text;
        }


        private static IReplyMarkup GetInlineButtonsDays(rospOnDay day)
        {
            string first_1;
            string first_2;
            string second_1;
            string second_2;
            string third_1;
            string third_2;
            string fourth_1;
            string fourth_2;

            first_1 = day.firstPara_1.name;
            first_2 = day.firstPara_2.name;
            second_1 = day.secondPara_1.name;
            second_2 = day.secondPara_2.name;
            third_1 = day.thirdPara_1.name;
            third_2 = day.thirdPara_2.name;
            fourth_1 = day.fourthPara_1.name;
            fourth_2 = day.fourthPara_2.name;

            Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton firstkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton firstkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton secondkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton secondkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton thirdkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton thirdkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton fourthkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton fourthkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");

            if (first_1 != "" && first_2 != "")
            {
                firstkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "1(Числ)", callbackData: "first_chisl");
                firstkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "1(Знам)", callbackData: "first_znam");
            }

            else if (first_1 != "")
            {
                firstkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "first_chisl");
                firstkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "first_znam");
            }

            else if (first_2 != "")
            {
                firstkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "first_chisl");
                firstkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "first_znam");
            }

            else
            {
                firstkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "first_chisl");
                firstkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "first_znam");
            }

            if (second_1 != "" && second_2 != "")
            {
                secondkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "2(Числ)", callbackData: "second_chisl");
                secondkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "2(Знам)", callbackData: "second_znam");
            }

            else if (second_1 != "")
            {
                secondkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "second_chisl");
                secondkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "second_znam");
            }

            else if (second_2 != "")
            {
                secondkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "second_chisl");
                secondkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "second_znam");
            }

            else
            {
                secondkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "second_chisl");
                secondkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "second_znam");
            }


            if (third_1 != "" && third_2 != "")
            {
                thirdkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "3(Числ)", callbackData: "third_chisl");
                thirdkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "3(Знам)", callbackData: "third_znam");
            }
            else if (third_1 != "")
            {
                thirdkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "third_chisl");
                thirdkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "third_znam");
            }

            else if (third_2 != "")
            {
                thirdkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "third_chisl");
                thirdkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "third_znam");
            }

            else
            {
                thirdkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "third_chisl");
                thirdkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "third_znam");
            }

            if (fourth_1 != "" && fourth_2 != "")
            {
                fourthkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "4(Числ)", callbackData: "fourth_chisl");
                fourthkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "4(Знам)", callbackData: "fourth_znam");
            }
            else if (fourth_1 != "")
            {
                fourthkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "fourth_chisl");
                fourthkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "fourth_znam");
            }

            else if (fourth_2 != "")
            {
                fourthkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "fourth_chisl");
                fourthkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "fourth_znam");
            }

            else
            {
                fourthkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "fourth_chisl");
                fourthkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "", callbackData: "fourth_znam");
            }

            string _monday = "Понедельник";
            string _tuesday = "Вторник";
            string _wednesday = "Среда";
            string _thursday = "Четверг";
            string _friday = "Пятница";

            string my_day = checkDay();
            switch (my_day)
            {
                case "monday":
                    _monday += "🔥";
                    break;
                case "tuesday":
                    _tuesday += "🔥";
                    break;
                case "wednesday":
                    _wednesday += "🔥";
                    break;
                case "thursday":
                    _thursday += "🔥";
                    break;
                case "friday":
                    _friday += "🔥";
                    break;
            }

            return new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    firstkeyboard_1, firstkeyboard_2, secondkeyboard_1, secondkeyboard_2, thirdkeyboard_1, thirdkeyboard_2, fourthkeyboard_1, fourthkeyboard_2,
                },

                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: _monday, callbackData: "Понедельник"),
                },
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: _tuesday, callbackData: "Вторник"),
                },
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: _wednesday, callbackData: "Среда"),
                },
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: _thursday, callbackData: "Четверг"),
                },
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: _friday, callbackData: "Пятница"),
                },
            });

        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();

        }
    }
}