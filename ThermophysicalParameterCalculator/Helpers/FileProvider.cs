using System.IO;
using System.Text;

namespace ThermophysicalParameterCalculator
{
	public static class FileProvider 
	{
		public static void Raplace (string value,string fileName)
		{
			using (var sw = new StreamWriter(fileName, false, Encoding.UTF8))
			{
				sw.WriteLine(value);
			}				
		}

		public static void Append(string value, string fileName)
		{
			using (var sw = new StreamWriter(fileName, true, Encoding.UTF8))
			{
				sw.WriteLine(value);
			}
		}

		public static string GetValue(string fileName)
		{
			string value;
			using (var sr = new StreamReader(fileName))
			{
				value = sr.ReadToEnd();
			}
			return value;
		}
	}
}
