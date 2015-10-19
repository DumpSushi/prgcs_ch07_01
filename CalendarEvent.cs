using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch07_01
{
	class CalendarEvent : IComparable<CalendarEvent>
	{
		public string Title { get; set; }
		public DateTimeOffset StartTime { get; set; }
		public TimeSpan Duration { get; set; }

		public int CompareTo(CalendarEvent other)
		{
			if (other == null)
			{
				return 1;
			}
			return StartTime.CompareTo(other.StartTime);
		}
	}
}
