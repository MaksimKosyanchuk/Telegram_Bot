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

namespace Classes
{
    namespace Telegram_Bot
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                var client = new TelegramBotClient(File.ReadAllText("C:\\Users\\mckos\\source\\repos\\Telegram_bot\\Telegram_Bot\\config.txt"));
                client.StartReceiving(Update, Error);
                Classes.initialization();
                Console.ReadLine();
            }

            async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
            {
                var message = update.Message;
                Message a;

                switch (update.Type)
                {
                    case Telegram.Bot.Types.Enums.UpdateType.Message:
                        string text;
                        if (message.Text != "")
                        {
                            if (message.Text == "/get_rosp@Maks28925_bot" || message.Text == "/get_rosp")
                            {
                                string _log = $"|{DateTime.Now.ToLocalTime().ToString()}| " + update.Message.From.Username + $"({update.Message.From.Id}): {update.Message.Text}";
                                log(_log);
                            }
                            switch (message.Text)
                            {
                                case "/get_rosp@Maks28925_bot":
                                    text = get_rosp();
                                    a = botClient.SendTextMessageAsync(message.Chat.Id, text, replyMarkup: GetInlineButtonsDays(Classes.present_day), parseMode: ParseMode.Html).Result;
                                    break;
                                case "/get_rosp":
                                    text = get_rosp();
                                    a = botClient.SendTextMessageAsync(message.Chat.Id, text, replyMarkup: GetInlineButtonsDays(Classes.present_day), parseMode: ParseMode.Html).Result;
                                    break;
                                case "/start":
                                    text = get_rosp();
                                    await botClient.SendTextMessageAsync(message.Chat.Id, "<b>/get_rosp - узнать расписание\n/help - список всех команд</b>", parseMode: ParseMode.Html);
                                    break;

                                case "/help":
                                    await botClient.SendTextMessageAsync(message.Chat.Id, "Узнать расписание - /get_rosp@Maks28925_bot");
                                    break;
                            }
                        }
                        break;

                    case Telegram.Bot.Types.Enums.UpdateType.CallbackQuery:
                        string new_text = "";
                        switch (update.CallbackQuery.Data)
                        {
                            case "Понедельник":
                                text = fillDay(Classes.monday, "monday");
                                if (text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                {
                                    await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(Classes.monday), parseMode: ParseMode.Html);
                                    Classes.present_day = Classes.monday;
                                }
                                await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                                break;
                            case "Вторник":
                                text = fillDay(Classes.tuesday, "tuesday");
                                if (text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                {
                                    await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(Classes.tuesday), parseMode: ParseMode.Html);
                                    Classes.present_day = Classes.tuesday;
                                }
                                await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                                break;
                            case "Среда":
                                text = fillDay(Classes.wednesday, "wednesday");
                                if (text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                {
                                    await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(Classes.wednesday), parseMode: ParseMode.Html);
                                    Classes.present_day = Classes.wednesday;
                                }
                                await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                                break;
                            case "Четверг":
                                text = fillDay(Classes.thursday, "thursday");
                                if (text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                {
                                    Classes.present_day = Classes.thursday;
                                    await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(Classes.thursday), parseMode: ParseMode.Html);
                                }
                                await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                                break;
                            case "Пятница":
                                text = fillDay(Classes.friday, "friday");
                                if (text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                {
                                    await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, text, replyMarkup: (InlineKeyboardMarkup)GetInlineButtonsDays(Classes.friday), parseMode: ParseMode.Html);
                                    Classes.present_day = Classes.friday;
                                }
                                await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                                break;
                            case "first_chisl":
                                new_text = fill_para(Classes.my_time.time_first_start, Classes.my_time.time_first_end, Classes.present_day.firstPara_1.name, Classes.present_day.firstPara_1.prepod, Classes.present_day.firstPara_1.link);
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, parseMode: ParseMode.Html, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                                break;
                            case "first_znam":
                                new_text = fill_para(Classes.my_time.time_first_start, Classes.my_time.time_first_end, Classes.present_day.firstPara_2.name, Classes.present_day.firstPara_2.prepod, Classes.present_day.firstPara_2.link);
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, parseMode: ParseMode.Html, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                                break;
                            case "second_chisl":
                                new_text = fill_para(Classes.my_time.time_second_start, Classes.my_time.time_second_end, Classes.present_day.secondPara_1.name, Classes.present_day.secondPara_1.prepod, Classes.present_day.secondPara_1.link);
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, parseMode: ParseMode.Html, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                                break;
                            case "second_znam":
                                new_text = fill_para(Classes.my_time.time_second_start, Classes.my_time.time_second_end, Classes.present_day.secondPara_2.name, Classes.present_day.secondPara_2.prepod, Classes.present_day.secondPara_2.link);
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, parseMode: ParseMode.Html, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                                break;
                            case "third_chisl":
                                new_text = fill_para(Classes.my_time.time_third_start, Classes.my_time.time_third_end, Classes.present_day.thirdPara_1.name, Classes.present_day.thirdPara_1.prepod, Classes.present_day.thirdPara_1.link);
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, parseMode: ParseMode.Html, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                                break;
                            case "third_znam":
                                new_text = fill_para(Classes.my_time.time_third_start, Classes.my_time.time_third_end, Classes.present_day.thirdPara_2.name, Classes.present_day.thirdPara_2.prepod, Classes.present_day.thirdPara_2.link);
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, parseMode: ParseMode.Html, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                                break;
                            case "fourth_chisl":
                                new_text = fill_para(Classes.my_time.time_fourth_start, Classes.my_time.time_fourth_end, Classes.present_day.fourthPara_1.name, Classes.present_day.fourthPara_1.prepod, Classes.present_day.fourthPara_1.link);
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, parseMode: ParseMode.Html, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                                break;
                            case "fourth_znam":
                                new_text = fill_para(Classes.my_time.time_fourth_start, Classes.my_time.time_fourth_end, Classes.present_day.fourthPara_2.name, Classes.present_day.fourthPara_2.prepod, Classes.present_day.fourthPara_2.link);
                                await botClient.EditMessageTextAsync(update.CallbackQuery.Message.Chat.Id, update.CallbackQuery.Message.MessageId, new_text, parseMode: ParseMode.Html, replyMarkup: GetBackButton(), disableWebPagePreview: true);
                                break;
                        }
                        break;
                }
            }

            public static string get_rosp()
            {
                string text = "";
                string day_of_week = checkDay();
                switch (day_of_week)
                {
                    case "monday":
                        text = fillDay(Classes.monday, day_of_week);
                        Classes.present_day = Classes.monday;
                        break;
                    case "tuesday":
                        text = fillDay(Classes.tuesday, day_of_week);
                        Classes.present_day = Classes.tuesday;
                        break;
                    case "wednesday":
                        text = fillDay(Classes.wednesday, day_of_week);
                        Classes.present_day = Classes.wednesday;
                        break;
                    case "thursday":
                        text = fillDay(Classes.thursday, day_of_week);
                        Classes.present_day = Classes.thursday;
                        break;
                    case "friday":
                        text = fillDay(Classes.friday, day_of_week);
                        Classes.present_day = Classes.friday;
                        break;
                    case "saturday":
                        text = fillDay(Classes.monday, "monday");
                        Classes.present_day = Classes.monday;
                        break;
                    case "sunday":
                        text = fillDay(Classes.monday, "monday");
                        Classes.present_day = Classes.monday;
                        break;
                }

                return text;
            }

            public static string get_day_of_week_name(Classes.rospOnDay day)
            {
                string _day = "";
                if (day == Classes.monday)
                {
                    _day = "Понедельник";
                }
                else if (day == Classes.tuesday)
                {
                    _day = "Вторник";
                }
                else if (day == Classes.wednesday)
                {
                    _day = "Среда";
                }
                else if (day == Classes.thursday)
                {
                    _day = "Четверг";
                }
                else if (day == Classes.friday)
                {
                    _day = "Пятница";
                }
                return _day;
            }

            private static string checkDay()
            {
                DayOfWeek dt = DateTime.Now.DayOfWeek;
                return dt.ToString().ToLower();
            }

            private static string fillDay(Classes.rospOnDay day, string day_of_week)
            {
                string chisl = ">Числ:  ";
                string znam = ">Знам:  ";

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
                        final_text += "<b>Понедельник</b>\n";
                        break;
                    case "tuesday":
                        final_text += "<b>Вторник</b>\n";
                        break;
                    case "wednesday":
                        final_text += "<b>Среда</b>\n";
                        break;
                    case "thursday":
                        final_text += "<b>Четверг</b>\n";
                        break;
                    case "friday":
                        final_text += "<b>Пятница</b>\n";
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

                final_text += $"<b>1</b>. {Classes.my_time.time_first_start} ⎯ {Classes.my_time.time_third_end} \n";

                if (first_1 != "" && first_2 != "")
                {
                    first_1 = chisl + first_1;
                    first_2 = znam + first_2;
                    final_text += first_1 + "\n";
                    final_text += first_2 + "\n\n";
                }

                else if (first_1 != "" && first_2 == "")
                {
                    final_text += ">" + first_1;
                    final_text += "\n\n";
                }

                else if (first_1 == "" && first_2 != "")
                {
                    final_text += ">" + first_2;
                    final_text += "\n\n";
                }

                else if (first_1 == "" && first_2 == "")
                {
                    final_text += ">" + "Нет пары\n\n";
                }

                final_text += $"<b>2</b>. {Classes.my_time.time_second_start} ⎯ {Classes.my_time.time_second_end} \n";

                if (second_1 != "" && second_2 != "")
                {
                    second_1 = chisl + second_1;
                    second_2 = znam + second_2;
                    final_text += second_1 + "\n";
                    final_text += second_2 + "\n\n";
                }
                else if (second_1 != "" && second_2 == "")
                {
                    final_text += ">" + second_1 + "\n\n";
                }
                else if (second_1 == "" && second_2 != "")
                {
                    final_text += ">" + second_2 + "\n\n";
                }
                else if (second_2 == "" && second_1 == "")
                {
                    final_text += ">" + "Нет пары\n\n";
                }

                final_text += $"<b>3</b>. {Classes.my_time.time_third_start} ⎯ {Classes.my_time.time_third_end} \n";

                if (third_1 != "" && third_2 != "")
                {
                    third_1 = chisl + third_1;
                    third_2 = znam + third_2;
                    final_text += third_1 + "\n";
                    final_text += third_2 + "\n\n";
                }
                else if (third_1 != "" && third_2 == "")
                {
                    final_text += ">" + third_1 + "\n\n";
                }
                else if (third_1 == "" && third_2 != "")
                {
                    final_text += ">" + third_2 + "\n\n";
                }
                else if (third_1 == "" && third_2 == "")
                {
                    final_text += ">" + "Нет пары\n\n";
                }

                final_text += $"<b>4</b>. {Classes.my_time.time_fourth_start} ⎯ {Classes.my_time.time_fourth_end} \n";

                if (fourth_1 != "" && fourth_2 != "")
                {
                    fourth_1 = chisl + fourth_1;
                    fourth_2 = znam + fourth_2;
                    final_text += fourth_1 + "\n";
                    final_text += fourth_2;
                }
                else if (fourth_1 != "" && fourth_2 == "")
                {
                    final_text += ">" + fourth_1;
                }
                else if (fourth_1 == "" && fourth_2 != "")
                {
                    final_text += ">" + fourth_2 + "";
                }
                else if (fourth_1 == "" && fourth_2 == "")
                {
                    final_text += ">" + "Нет пары";
                }

                return final_text;
            }

            private static string fill_para(string time_start, string time_end, string para_name, string prepod, string link)
            {
                string _day = "";
                if (Classes.present_day == Classes.monday)
                {
                    _day = "Понедельник";
                }
                else if (Classes.present_day == Classes.tuesday)
                {
                    _day = "Вторник";
                }
                else if (Classes.present_day == Classes.wednesday)
                {
                    _day = "Среда";
                }
                else if (Classes.present_day == Classes.thursday)
                {
                    _day = "Четверг";
                }
                else if (Classes.present_day == Classes.friday)
                {
                    _day = "Пятница";
                }
                string text = "";
                text += $"День: <b>{_day}</b> \n";
                text += $"Начало: <b>{time_start}</b>\n";
                text += $"Конец: <b>{time_end}</b>\n\n";
                text += $"<b>{para_name}</b>\n\n";
                text += $"Преподаватель: <b>{prepod}</b>\n\n";
                text += $"Ссылка: <b>{link}</b>";
                return text;
            }

            private static void log(string log_text)
            {
                Console.WriteLine(log_text);
                StreamWriter sw = new StreamWriter("C:\\Users\\mckos\\source\\repos\\Telegram_bot\\Telegram_Bot\\log.txt", append: true);
                sw.Write("\n" + log_text);
                sw.Close();
            }

            private static InlineKeyboardMarkup GetBackButton()
            {
                string data = get_day_of_week_name(Classes.present_day);

                return new InlineKeyboardMarkup(new InlineKeyboardButton("Назад") { Text = "Назад", CallbackData = data });
            }

            private static IReplyMarkup GetInlineButtonsDays(Classes.rospOnDay day)
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
}