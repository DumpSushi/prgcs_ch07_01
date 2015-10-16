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
		}

		static string[] AddNumbers(string[] names)
		{
			string[] numberedNames = new string[names.Length];
			for (int i = 0; i < names.Length; ++i)
			{
				numberedNames[i] = string.Format("{0]: {1}", i, names[i]);
			}
			return numberedNames;
		}
	}
}
