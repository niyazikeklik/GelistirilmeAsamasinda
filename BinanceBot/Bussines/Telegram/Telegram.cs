using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace BinanceBotDesktop.Telegram
{
	public class Telegram
	{
		TelegramBotClient botClient;
		public ChatId _ChatId;
		public Telegram(string Token = "1562965699:AAEU233wAO8TQ-eoESDgZWu8Fua3dvSlniI", long chatId = 1046979537)
		{
			 _ChatId = new ChatId(chatId);
			 botClient = new TelegramBotClient("");
		}
		public async void MesajGonder(string Mesaj)
		{
			var me = await botClient.GetMeAsync();
			Message message = await botClient.SendTextMessageAsync(
			chatId: _ChatId,
			text: Mesaj,
			cancellationToken: CancellationToken.None);
		}
	}
}
