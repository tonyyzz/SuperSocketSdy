using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.JsonTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(JsonConvert.SerializeObject(new { a=1}));
			Console.WriteLine("ceshi");
			Console.ReadKey();
		}
	}
}
