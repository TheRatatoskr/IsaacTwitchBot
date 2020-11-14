using System.IO;

namespace MechaSquirrelInterface
{
	static class Misc
	{
		public static void CheckFile(string fileToCheck)
		{
				if (!File.Exists(fileToCheck)) { File.Create(fileToCheck).Close(); }
		}
	}
}
