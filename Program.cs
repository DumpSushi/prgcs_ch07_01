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
			CalendarEvent[] events1 =
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
			};
			CalendarEvent[] events2 =
			{
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

			CalendarEvent[] allEvents = CombineEvents(events1, events2);
			PrintEvents(allEvents);
			Console.WriteLine();
			PrintEvents(RemoveFirstEvent(allEvents));
			Console.ReadKey();
		}

		static void PrintEvents(CalendarEvent[] events)
		{
			foreach (CalendarEvent item in events)
			{
				Console.WriteLine(item.Title + ": " + item.StartTime);
			}
		}

		static CalendarEvent[] CombineEvents(CalendarEvent[] event1,
											 CalendarEvent[] event2)
		{
			CalendarEvent[] combinedEvents =
				new CalendarEvent[event1.Length + event2.Length];
			event1.CopyTo(combinedEvents, 0);
			event2.CopyTo(combinedEvents, event1.Length);

			return combinedEvents;
		}

		static CalendarEvent[] RemoveFirstEvent(CalendarEvent[] events)
		{
			CalendarEvent[] croppedEvents = new CalendarEvent[events.Length - 1];
			Array.Copy(
				events,
				1,
				croppedEvents,
				0,
				events.Length - 1
				);
			return croppedEvents;
		}

	}
}
