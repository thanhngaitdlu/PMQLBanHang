using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang
{
	public class Utilities
	{
		public static string ConnectionString =
			ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
	}
}
