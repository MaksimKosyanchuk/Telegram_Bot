using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Classes
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

        public static void initialization()
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


            wednesday.firstPara_1.name = "Нет пары";
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
    }
}
