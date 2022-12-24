using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Classes;

namespace Fuller
{
    public class Fuller
    {

        public static string CheckDay()
        {
            DayOfWeek dt = DateTime.Now.DayOfWeek;
            return dt.ToString().ToLower();
        }


        public static string FillDay(Classes.Classes.rospOnDay day, string day_of_week)
        {
            string day_migalka = "";
            DateTime date_start = new DateTime(2022, 9, 18);
            DateTime date_now = DateTime.Now;
            if (CheckDay() == "sunday" || CheckDay() == "saturday")
            {
                date_now = date_now.AddDays(2);
            }
            if ((ISOWeek.GetWeekOfYear(date_now) - ISOWeek.GetWeekOfYear(date_start)) % 2 == 0)
            {
                day_migalka = "Числ";
            }
            else
            {
                day_migalka = "Знам";
            }

            string chisl = "> Числ:";
            string znam = "> Знам:";

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
                    final_text += "<b>Понедельник</b>";
                    break;
                case "tuesday":
                    final_text += "<b>Вторник</b>";
                    break;
                case "wednesday":
                    final_text += "<b>Среда</b>";
                    break;
                case "thursday":
                    final_text += "<b>Четверг</b>";
                    break;
                case "friday":
                    final_text += "<b>Пятница</b>";
                    break;
            }
            final_text += $"({day_migalka})\n";
            first_1 = " " + day.firstPara_1.name;
            first_2 = " " + day.firstPara_2.name;
            second_1 = " " + day.secondPara_1.name;
            second_2 = " " + day.secondPara_2.name;
            third_1 = " " + day.thirdPara_1.name;
            third_2 = " " + day.thirdPara_2.name;
            fourth_1 = " " + day.fourthPara_1.name;
            fourth_2 = " " + day.fourthPara_2.name;

            final_text += "\n";

            final_text += $"<b>1. {Classes.Classes.my_time.time_first_start} ⎯ {Classes.Classes.my_time.time_third_end} </b>\n";

            if (first_1 != " " && first_2 != " ")
            {
                first_1 = chisl + first_1;
                first_2 = znam + first_2;
                final_text += first_1 + "\n";
                final_text += first_2 + "\n\n";
            }

            else if (first_1 != " " && first_2 == " ")
            {
                final_text += ">" + first_1;
                final_text += "\n\n";
            }

            else if (first_1 == " " && first_2 != " ")
            {
                final_text += ">" + first_2;
                final_text += "\n\n";
            }

            else if (first_1 == " " && first_2 == " ")
            {
                final_text += ">" + " Нет пары\n\n";
            }

            final_text += $"<b>2. {Classes.Classes.my_time.time_second_start} ⎯ {Classes.Classes.my_time.time_second_end}</b> \n";

            if (second_1 != " " && second_2 != " ")
            {
                second_1 = chisl + second_1;
                second_2 = znam + second_2;
                final_text += second_1 + "\n";
                final_text += second_2 + "\n\n";
            }
            else if (second_1 != " " && second_2 == " ")
            {
                final_text += ">" + second_1 + "\n\n";
            }
            else if (second_1 == " " && second_2 != " ")
            {
                final_text += ">" + second_2 + "\n\n";
            }
            else if (second_2 == " " && second_1 == " ")
            {
                final_text += ">" + " Нет пары\n\n";
            }

            final_text += $"<b>3. {Classes.Classes.my_time.time_third_start} ⎯ {Classes.Classes.my_time.time_third_end}</b> \n";

            if (third_1 != " " && third_2 != " ")
            {
                third_1 = chisl + third_1;
                third_2 = znam + third_2;
                final_text += third_1 + "\n";
                final_text += third_2 + "\n\n";
            }
            else if (third_1 != " " && third_2 == " ")
            {
                final_text += ">" + third_1 + "\n\n";
            }
            else if (third_1 == " " && third_2 != " ")
            {
                final_text += ">" + third_2 + "\n\n";
            }
            else if (third_1 == " " && third_2 == " ")
            {
                final_text += ">" + " Нет пары\n\n";
            }

            final_text += $"<b>4. {Classes.Classes.my_time.time_fourth_start} ⎯ {Classes.Classes.my_time.time_fourth_end}</b> \n";

            if (fourth_1 != " " && fourth_2 != " ")
            {
                fourth_1 = chisl + fourth_1;
                fourth_2 = znam + fourth_2;
                final_text += fourth_1 + "\n";
                final_text += fourth_2;
            }
            else if (fourth_1 != " " && fourth_2 == " ")
            {
                final_text += ">" + fourth_1;
            }
            else if (fourth_1 == " " && fourth_2 != " ")
            {
                final_text += ">" + fourth_2 + "";
            }
            else if (fourth_1 == " " && fourth_2 == " ")
            {
                final_text += ">" + " Нет пары";
            }

            return final_text;
        }

        public static string FillPara(string time_start, string time_end, string para_name, string prepod, string link)
        {
            string _day = "";
            if (Classes.Classes.present_day == Classes.Classes.monday)
            {
                _day = "Понедельник";
            }
            else if (Classes.Classes.present_day == Classes.Classes.tuesday)
            {
                _day = "Вторник";
            }
            else if (Classes.Classes.present_day == Classes.Classes.wednesday)
            {
                _day = "Среда";
            }
            else if (Classes.Classes.present_day == Classes.Classes.thursday)
            {
                _day = "Четверг";
            }
            else if (Classes.Classes.present_day == Classes.Classes.friday)
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
    }
}
