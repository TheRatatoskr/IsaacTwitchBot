using System.IO;

namespace MechaSquirrelInterface
{
	class Logger
	{
		public string infoLog = @"[Info] - ";
		
		public string logFile = "log.txt";



		public void Log(string type, string information)
		{
			StreamWriter outputFile = new StreamWriter(logFile);
			outputFile.WriteLine(type + information);
			outputFile.Close();
			
		}
		
	}
}
