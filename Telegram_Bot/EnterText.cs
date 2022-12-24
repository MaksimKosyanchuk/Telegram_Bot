using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;


namespace EnterText
{
    public class EnterText
    {
        public static void PushText(ITelegramBotClient botClient, long id, string text, IReplyMarkup buttons, ParseMode mode)
        {
            botClient.SendTextMessageAsync(id, text, replyMarkup: buttons, parseMode: mode);
        }

        public static async Task EditTextAsync(ITelegramBotClient botClient, long ChatId, int MessageId, string text, IReplyMarkup buttons, ParseMode mode)
        {
            await botClient.EditMessageTextAsync(ChatId, MessageId, text, replyMarkup: (InlineKeyboardMarkup)buttons, parseMode: mode, disableWebPagePreview: true);
        }
    }
}
