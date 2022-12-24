using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using File = System.IO.File;
using EnterText;
using Fuller;

//new line

namespace Classes
{
    namespace System.Globalization 
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

                    switch (update.Type)
                    {
                        case UpdateType.Message:
                            long ChatMessageId = message.Chat.Id;
                            string text = "";
                            if (message.Text != "")
                            {
                                if (message.Text == "/get_rosp@Maks28925_bot" || message.Text == "/get_rosp")
                                {
                                    string _log = $"|{DateTime.Now.ToLocalTime().ToString()}| " + update.Message.From.Username + $"({update.Message.From.Id}): {update.Message.Text}";
                                    Log(_log);
                                }
                                switch (message.Text)
                                {
                                    case "/get_rosp@Maks28925_bot":
                                        text = GetRosp();
                                        break;
                                    case "/get_rosp":
                                        text = GetRosp();
                                        break;
                                }
                                EnterText.EnterText.PushText(botClient, ChatMessageId, text, Buttons.Buttons.GetInlineButtonsDays(Classes.present_day), ParseMode.Html);
                            }
                            break;

                        case UpdateType.CallbackQuery:
                            string new_text = "";
                            CallbackQuery CallBack = update.CallbackQuery;
                            long ChatId = CallBack.Message.Chat.Id;
                            int MessageId = CallBack.Message.MessageId;
                            IReplyMarkup buttons = Buttons.Buttons.GetBackButton();
                            switch (update.CallbackQuery.Data)
                            {
                                case "Понедельник":
                                    new_text = Fuller.Fuller.FillDay(Classes.monday, "monday");
                                    if (new_text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                    {
                                        Classes.present_day = Classes.monday;
                                        buttons = Buttons.Buttons.GetInlineButtonsDays(Classes.monday);
                                    }
                                    break;
                                case "Вторник":
                                    new_text = Fuller.Fuller.FillDay(Classes.tuesday, "tuesday");
                                    if (new_text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                    {
                                        Classes.present_day = Classes.tuesday;
                                        buttons = Buttons.Buttons.GetInlineButtonsDays(Classes.tuesday);
                                    }
                                    break;
                                case "Среда":
                                    new_text = Fuller.Fuller.FillDay(Classes.wednesday, "wednesday");
                                    if (new_text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                    {
                                        Classes.present_day = Classes.wednesday;
                                        buttons = Buttons.Buttons.GetInlineButtonsDays(Classes.wednesday);
                                    }
                                    break;
                                case "Четверг":
                                    new_text = Fuller.Fuller.FillDay(Classes.thursday, "thursday");
                                    if (new_text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                    {
                                        Classes.present_day = Classes.thursday;
                                        buttons = Buttons.Buttons.GetInlineButtonsDays(Classes.thursday);
                                    }
                                    break;
                                case "Пятница":
                                    new_text = Fuller.Fuller.FillDay(Classes.friday, "friday");
                                    if (new_text.Replace("<b>", "").Replace("</b>", "") != update.CallbackQuery.Message.Text)
                                    {
                                        Classes.present_day = Classes.friday;
                                        buttons = Buttons.Buttons.GetInlineButtonsDays(Classes.friday);
                                    }
                                    break;
                                case "first_chisl":
                                    new_text = Fuller.Fuller.FillPara(Classes.my_time.time_first_start, Classes.my_time.time_first_end, Classes.present_day.firstPara_1.name, Classes.present_day.firstPara_1.prepod, Classes.present_day.firstPara_1.link);
                                    buttons = Buttons.Buttons.GetBackButton();
                                    break;
                                case "first_znam":
                                    new_text = Fuller.Fuller.FillPara(Classes.my_time.time_first_start, Classes.my_time.time_first_end, Classes.present_day.firstPara_2.name, Classes.present_day.firstPara_2.prepod, Classes.present_day.firstPara_2.link);
                                    buttons = Buttons.Buttons.GetBackButton();
                                    break;
                                case "second_chisl":
                                    new_text = Fuller.Fuller.FillPara(Classes.my_time.time_second_start, Classes.my_time.time_second_end, Classes.present_day.secondPara_1.name, Classes.present_day.secondPara_1.prepod, Classes.present_day.secondPara_1.link);
                                    buttons = Buttons.Buttons.GetBackButton();
                                    break;
                                case "second_znam":
                                    new_text = Fuller.Fuller.FillPara(Classes.my_time.time_second_start, Classes.my_time.time_second_end, Classes.present_day.secondPara_2.name, Classes.present_day.secondPara_2.prepod, Classes.present_day.secondPara_2.link);
                                    buttons = Buttons.Buttons.GetBackButton();
                                    break;
                                case "third_chisl":
                                    new_text = Fuller.Fuller.FillPara(Classes.my_time.time_third_start, Classes.my_time.time_third_end, Classes.present_day.thirdPara_1.name, Classes.present_day.thirdPara_1.prepod, Classes.present_day.thirdPara_1.link);
                                    buttons = Buttons.Buttons.GetBackButton();
                                    break;
                                case "third_znam":
                                    new_text = Fuller.Fuller.FillPara(Classes.my_time.time_third_start, Classes.my_time.time_third_end, Classes.present_day.thirdPara_2.name, Classes.present_day.thirdPara_2.prepod, Classes.present_day.thirdPara_2.link);
                                    buttons = Buttons.Buttons.GetBackButton();
                                    break;
                                case "fourth_chisl":
                                    new_text = Fuller.Fuller.FillPara(Classes.my_time.time_fourth_start, Classes.my_time.time_fourth_end, Classes.present_day.fourthPara_1.name, Classes.present_day.fourthPara_1.prepod, Classes.present_day.fourthPara_1.link);
                                    buttons = Buttons.Buttons.GetBackButton();
                                    break;
                                case "fourth_znam":
                                    new_text = Fuller.Fuller.FillPara(Classes.my_time.time_fourth_start, Classes.my_time.time_fourth_end, Classes.present_day.fourthPara_2.name, Classes.present_day.fourthPara_2.prepod, Classes.present_day.fourthPara_2.link);
                                    buttons = Buttons.Buttons.GetBackButton();
                                    break;
                            }
                            await EnterText.EnterText.EditTextAsync(botClient, ChatId, MessageId, new_text, buttons, ParseMode.Html);
                            await botClient.AnswerCallbackQueryAsync(update.CallbackQuery.Id);
                            break;
                    }
                }

                public static string GetRosp()
                {
                    string text = "";
                    string day_of_week = Fuller.Fuller.CheckDay();
                    switch (day_of_week)
                    {
                        case "monday":
                            text = Fuller.Fuller.FillDay(Classes.monday, day_of_week);
                            Classes.present_day = Classes.monday;
                            break;
                        case "tuesday":
                            text = Fuller.Fuller.FillDay(Classes.tuesday, day_of_week);
                            Classes.present_day = Classes.tuesday;
                            break;
                        case "wednesday":
                            text = Fuller.Fuller.FillDay(Classes.wednesday, day_of_week);
                            Classes.present_day = Classes.wednesday;
                            break;
                        case "thursday":
                            text = Fuller.Fuller.FillDay(Classes.thursday, day_of_week);
                            Classes.present_day = Classes.thursday;
                            break;
                        case "friday":
                            text = Fuller.Fuller.FillDay(Classes.friday, day_of_week);
                            Classes.present_day = Classes.friday;
                            break;
                        case "saturday":
                            text = Fuller.Fuller.FillDay(Classes.monday, "monday");
                            Classes.present_day = Classes.monday;
                            break;
                        case "sunday":
                            text = Fuller.Fuller.FillDay(Classes.monday, "monday");
                            Classes.present_day = Classes.monday;
                            break;
                    }

                    return text;
                }

                public static string GetDayOfWeekName(Classes.rospOnDay day)
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

                private static void Log(string log_text)
                {
                    Console.WriteLine(log_text);
                    StreamWriter sw = new StreamWriter("C:\\Users\\mckos\\source\\repos\\Telegram_bot\\Telegram_Bot\\log.txt", append: true);
                    sw.Write("\n" + log_text);
                    sw.Close();
                }

                private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
                {
                    throw new NotImplementedException();

                }
            }
        }
    }
}