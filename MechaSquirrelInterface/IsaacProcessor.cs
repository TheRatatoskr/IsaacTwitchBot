using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MechaSquirrelInterface
{
	class IsaacProcessor
	{
		//configurations
		public bool multiplierEnabled = false;
		public bool SpamControlActive = true;
		public bool multiCommands = false;
		//end configurations

		//Object References
		public Bot bot;
		public Logger logger;
		private MainMenu mainMenu;
		//end Object References

		//file references
		private string commandOvenPath;
		private const string commandOven = "oven.bake";
		private string logPath;
		private const string logFile = "log.txt";

		string chatPollPath = "chatpoll.txt";
		string luaCommandPath = "luacommand.txt";
		string consoleOutputPath = "consoleoutput.txt";
		string cooldownsPath = "cool.txt";
		//end file references

		//List Containers
		List<string> chatPoll = new List<string>();
		List<string> luaCommand = new List<string>();
		List<string> consoleOutput = new List<string>();
		List<DateTime> spamControl = new List<DateTime>();
		List<TimeSpan> cooldowns = new List<TimeSpan>();
		//end list containers

		//calculations and definitions 
		private int multiplierLength = 3;
		private TimeSpan spamControlTime;
		//end calculations and definitions

		//constructor that configurs all of the options set from the main menu recieved from the bot. 
		public IsaacProcessor(Logger logshare, bool multiBool,bool spamControlEnabled, bool mCommands, int spamControlTimer, MainMenu recievedMenu)
		{
			multiCommands = mCommands;
			mainMenu = recievedMenu;
			multiplierEnabled = multiBool;
			logger = logshare;

			spamControlTime = new TimeSpan(0, 0, 0, spamControlTimer);
			SpamControlActive = spamControlEnabled;

			CheckFile(chatPollPath);
			CheckFile(luaCommandPath);
			CheckFile(consoleOutputPath);
			CheckFile(logFile);

			ImportData(chatPoll, chatPollPath);
			ImportData(luaCommand, luaCommandPath);
			ImportData(consoleOutput, consoleOutputPath);
			ImportCooldowns(cooldowns, cooldownsPath);

			InitilizeSpamControl();
			
		}

		//this checks required files to make sure they exist. This prevents exceptions from being thrown. 
		public void CheckFile(string fileToCheck)
		{
			if (!File.Exists(fileToCheck)) { File.Create(fileToCheck).Close(); }
		}
		//this imports the data from the txt files into the appropriate lists.
		public void ImportData(List<string> list, string path)
		{
			foreach (string item in File.ReadAllLines(path))
			{
				list.Add(item);
			}
		}

		public void ImportCooldowns(List<TimeSpan> list, string path)
		{
			foreach (string item in File.ReadAllLines(path))
			{
				list.Add(new TimeSpan(0, 0, 0, Int32.Parse(item)));
			}
		}

		//this sets the values of the spam controller to their initial values. this prevents the same command from being over used
		//this is going to be replaced by a cool down function. 
		private void InitilizeSpamControl()
		{
			foreach (string item in chatPoll)
			{
				spamControl.Add(DateTime.Now - cooldowns[chatPoll.IndexOf(item)]);
			}
		}


		public void Bake(string comInput, string pollInput)
		{

			//this method writes an input to the command oven file. 
			// Set a variable to the Documents path.
			//string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			// Append text to an existing file
			//mainMenu.ChangeLogLabel("Hello from the isaac processor");
			using (StreamWriter outputFile = new StreamWriter(commandOven, true))
			{
				outputFile.WriteLine(comInput);
			}
		}
		public void Log(string loginput)
		{

			//this method writes an input to the command oven file. 
			// Set a variable to the Documents path.
			//string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			// Append text to an existing file
			using (StreamWriter outputFile = new StreamWriter(logFile, true))
			{
				outputFile.WriteLine(loginput);
			}
		}

		//this is the main chat message processing method. 
		public void ChatInterpreter(string chatMessage, string userName)
		{
			string output = "";
			int repeater = 0;
			string tryRepeater = "0";
			Log(logger.infoLog + "Chat message has been received.");
			if (chatMessage.Length <= multiplierLength)
			{
				Log("Message was too short");
				return;
			}
			if(multiplierEnabled && chatMessage.Substring(1,multiplierLength).Contains('x'))
			{
				if(chatMessage.IndexOf('x') == 0) { return; }
				mainMenu.ChangeLogLabel(logger.infoLog + "Chat message has a repeater request");
				output = chatMessage.Substring(chatMessage.IndexOf('x')+1);
				Log(output);
				tryRepeater = chatMessage.Substring(0, chatMessage.IndexOf('x'));
				Log(tryRepeater);
				Int32.TryParse(tryRepeater, out repeater);
				
				Log(repeater.ToString());
				if (repeater == 0) { return; }

				for (int i = 1; i <= repeater; i++)
				{
					ProcessCommand(output, userName);
				}
				return;
			}
			else
			{
				Log(chatMessage + "No Repeater");
				ProcessCommand(chatMessage, userName);
				return;
			}

			//land of no return. if you made it here, congrats. im not sure what happened. Please contact Mr. Ratatoskr Immediatly and let him know this came up. 
			mainMenu.ChangeLogLabel("Something weird as carp happened. Contact Mr. Ratatoskr and tell him that someone found the forbidden acorn.");


		}


		public void ProcessCommand(string command, string userName)
		{
			//this does a small bit of input validation. If the command list is empty, then it GTFOs
			if (chatPoll.Count == 0) { return; }



			logger.Log(logger.infoLog, "Logged from IsaacProcessor.CS - " + command);
			logger.Log(logger.infoLog, "Logged from the processor. The Value of the first poll item in the list is " + chatPoll[0]);
			foreach (string item in chatPoll)
			{
				if(command.Contains(item))
				{

					int indexOfCommand = chatPoll.IndexOf(item);


						if (SpamControlActive && DateTime.Now < spamControl[indexOfCommand] + cooldowns[indexOfCommand])
						{
							mainMenu.ChangeLogLabel("Spam Control Triggered!");
							return;
						}
					
					spamControl[indexOfCommand] = DateTime.Now;
					mainMenu.ChangeLogLabel(userName + consoleOutput[indexOfCommand]);
					//mainMenu.ChangeLogLabel()
					logger.Log(logger.infoLog, "Logged from the foreach loop in the command processor - " + item + " - " + command);
					logger.Log(logger.infoLog, "Attempting to send this line of code: " + luaCommand[chatPoll.IndexOf(item)]);
					Bake(luaCommand[chatPoll.IndexOf(item)], consoleOutput[chatPoll.IndexOf(item)]);

					//this checks to see if multiple commands in a single message are allowed, and if not, GTFO
					if (!multiCommands){return;}

				}
			}
		}

		public string Randomizer(string[] commandList)
		{
			Random random = new Random();
			random.Next(0, commandList.Length - 1);
			return commandList[random.Next(0, commandList.Length - 1)];
		}
		
	}
}
