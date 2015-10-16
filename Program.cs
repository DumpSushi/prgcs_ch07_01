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
			// 個別オブジェクトの配列。
			CalendarEvent[] events = SeparateEvents();
			ModifyFirst(events);
			Console.WriteLine();

			// 同一オブジェクトの配列。
			events = AllTheSameEvent();
			ModifyFirst(events);
			Console.WriteLine();

			// 整数の配列。
			int[] numbers = { 2, 3, 5, 7, 11 };
			int thirdElementInArray = numbers[2];
			thirdElementInArray += 1;
			Console.WriteLine("変数：" + thirdElementInArray);
			Console.WriteLine("配列中の要素：" + numbers[2]);

			Console.ReadKey();
		}

		private static void ModifyFirst(CalendarEvent[] events)
		{
			Console.WriteLine(events[0].Title);
			Console.WriteLine(events[1].Title);

			events[0].Title = "変更";

			Console.WriteLine(events[0].Title);
			Console.WriteLine(events[1].Title);
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

			CalendarEvent thirdElementInArray = events[2];
			thirdElementInArray.Title = "変更されたタイトル";
			Console.WriteLine("変数：" + thirdElementInArray.Title);
			Console.WriteLine("配列中の要素：" + events[2].Title);

			Console.WriteLine();

			return events;
		}

		private static CalendarEvent[] AllTheSameEvent()
		{
			CalendarEvent theOnlyEvent = new CalendarEvent
			{
				Title = "サウスバンクでスウィング・ダンス",
				StartTime = new DateTimeOffset(2009, 7, 11, 15, 00, 00, TimeSpan.Zero),
				Duration = TimeSpan.FromHours(4)
			};

			CalendarEvent[] events =
			{
				theOnlyEvent,
				theOnlyEvent,
				theOnlyEvent,
				theOnlyEvent,
				theOnlyEvent
			};

			return events;
		}
	}
}
