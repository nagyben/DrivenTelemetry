using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivenTelemetryWinForms {
	public static class CSVConverter {
		public static string ToCSVFormat(this object thing) {
			if (thing is DateTime) {
				DateTime herp = (DateTime)thing;
				return herp.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds.ToString();
			} else if (thing is double) {
				return thing.ToString();
			} else {
				return "null";
			}
		}
	}
}
