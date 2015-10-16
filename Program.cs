using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch07_01
{
	class Program
	{
		static void Main(string[] args)
		{
			CalendarEvent[] events = SeparateEvents();

			DateTime dateOfInterest = new DateTime(2009, 7, 12);
			foreach (CalendarEvent item in events)
			{
				if (item.StartTime.Date == dateOfInterest)
				{
					Console.WriteLine(item.Title + ": " + item.StartTime);
				}
			}

			Console.ReadKey();
		}

		private static CalendarEvent[] SeparateEvents()
		{
			CalendarEvent[] events =
			{
				new CalendarEvent
				{
					Title = "サウスバンクでスウィング・ダンス",
					StartTime = new DateTimeOffset (2009, 7, 11, 15, 00, 00, TimeSpan.Zero),
					Duration = TimeSpan.FromHours(4)
				},
				new CalendarEvent
				{
					Title = "サタデー・ナイト・スウィング",
					StartTime = new DateTimeOffset (2009, 7, 11, 19, 30, 00, TimeSpan.Zero),
					Duration = TimeSpan.FromHours(6.5)
				},
				new CalendarEvent
				{
					Title = "F1 ドイツグランプリ",
					StartTime = new DateTimeOffset (2009, 7, 12, 12, 10, 00, TimeSpan.Zero),
					Duration = TimeSpan.FromHours(3)
				},
				new CalendarEvent
				{
					Title = "スウィング・ダンス・ピクニック",
					StartTime = new DateTimeOffset (2009, 7, 12, 15, 00, 00, TimeSpan.Zero),
					Duration = TimeSpan.FromHours(4)
				},
				new CalendarEvent
				{
					Title = "100 Clubでのスウィングダンスイベント",
					StartTime = new DateTimeOffset (2009, 7, 13, 19, 45, 00, TimeSpan.Zero),
					Duration = TimeSpan.FromHours(5)
				}
			};
			return events;
		}
	}
}
