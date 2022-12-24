using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot.Types.ReplyMarkups;
using Classes;
using Classes.System.Globalization.Telegram_Bot;

namespace Buttons
{
    public class Buttons
    {
        public static IReplyMarkup GetInlineButtonsDays(Classes.Classes.rospOnDay day)
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

            InlineKeyboardButton firstkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            InlineKeyboardButton firstkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            InlineKeyboardButton secondkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            InlineKeyboardButton secondkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            InlineKeyboardButton thirdkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            InlineKeyboardButton thirdkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            InlineKeyboardButton fourthkeyboard_1 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");
            InlineKeyboardButton fourthkeyboard_2 = InlineKeyboardButton.WithCallbackData(text: "d", callbackData: "d");

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

            string my_day = Fuller.Fuller.CheckDay();
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
                default:
                    _monday += "🔥";
                    break;
            }

            if (Classes.Classes.present_day == Classes.Classes.monday)
            {
                _monday = "✅" + _monday;
            }
            else if (Classes.Classes.present_day == Classes.Classes.tuesday)
            {
                _tuesday = "✅" + _tuesday;
            }
            else if (Classes.Classes.present_day == Classes.Classes.wednesday)
            {
                _wednesday = "✅" + _wednesday;
            }
            else if (Classes.Classes.present_day == Classes.Classes.thursday)
            {
                _thursday = "✅" + _thursday;
            }
            else if (Classes.Classes.present_day == Classes.Classes.friday)
            {
                _friday = "✅" + _friday;
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

        public static InlineKeyboardMarkup GetBackButton()
        {
            string data = Program.GetDayOfWeekName(Classes.Classes.present_day);

            return new InlineKeyboardMarkup(new InlineKeyboardButton("Назад") { Text = "Назад", CallbackData = data });
        }
    }
}
