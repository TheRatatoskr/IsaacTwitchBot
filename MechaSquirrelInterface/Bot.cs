using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;


namespace MechaSquirrelInterface
{

	public class Bot
	{
		//DateTime lastDiscordSpam;
		Logger logger = new Logger();
		TwitchClient client;
		MainMenu mainMenu;
		string channelAccessed;
		IsaacProcessor processor;

		//this constructor starts the actual bot and attempts to connect to the twitch sever. 
		//It pulls alot of things from the form, and when it builds the processor object, it sets it varibles.

		public Bot(string channelTarget, string userName, string authCode, bool multiplier, bool spamControlEnabled, bool mCommands, int spamTimer, MainMenu receivedMenu)
		{
			//lastDiscordSpam = DateTime.Now;
			
			//this builds the processor
			processor = new IsaacProcessor(logger, multiplier, spamControlEnabled, mCommands, spamTimer, receivedMenu);

			//this sets the main menu object, mostly for calling the method that pukes out console information. 
			mainMenu = receivedMenu;

			channelAccessed = channelTarget;
			//this section manages the actual connection to twitch.
			//it creates a client object with the specified twitch info, etc.
			ConnectionCredentials credentials = new ConnectionCredentials(userName, authCode);
			var clientOptions = new ClientOptions
			{
				MessagesAllowedInPeriod = 750,
				ThrottlingPeriod = TimeSpan.FromSeconds(30)
			};
			WebSocketClient customClient = new WebSocketClient(clientOptions);
			client = new TwitchClient(customClient);
			client.Initialize(credentials, channelTarget);
			

			//this is the collection of event handlers being subscribed to various events
			client.OnLog += Client_OnLog;
			client.OnJoinedChannel += Client_OnJoinedChannel;
			client.OnMessageReceived += Client_OnMessageReceived;
			client.OnConnected += Client_OnConnected;
			client.OnConnectionError += Client_OnConnectionError;
			
			//this actually connects the client to twitch using a method defined in twitchlib
			client.Connect();

			
			//mainMenu.ChangeLogLabel("Mecha-Squirrel is now online");
			
		}

		// this section manages connection errors when a connection is attempted. 
		private void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
		{
			mainMenu.ChangeLogLabel("Connection Error. Check username and auth code.");
		}

		//this section goes off on a successful log in
		private void Client_OnLog(object sender, OnLogArgs e)
		{
			//Console.WriteLine($"{e.DateTime.ToString()}: {e.BotUsername} - {e.Data}");
		}

		//this section is for a succesful connection (different from login)
		private void Client_OnConnected(object sender, OnConnectedArgs e)
		{
			//Console.WriteLine($"Connected to {e.AutoJoinChannel}");
			mainMenu.ChangeLogLabel("Isaac Bot is now online");
			mainMenu.DisableMenu("string!");
		}

		//this section is when the chat channel is joined. 
		private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
		{
			Console.WriteLine("Connected successfully");
			client.SendMessage(e.Channel, "Isaac Bot is online.");
		}

		//this is the section that triggers when the bot sees a chat message. 
		private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
		{
			mainMenu.showLog(e.ChatMessage.Message);

			//this checks if the chatter is me. If it is, it calls the debug section of the processor
			if(e.ChatMessage.Username.ToLower() == "anthropomorphicsquirrel")
			{
				processor.SquirrelCommands(e.ChatMessage.Message);
			}
			processor.ChatInterpreter(e.ChatMessage.Message, e.ChatMessage.Username.ToString());
		}

		//this method is called from teh main menu when the bot chat feature is called. 
		public void AnnoyChat(string messageToSend)
		{
			client.SendMessage(channelAccessed, messageToSend, false);
			mainMenu.showLog("message sent!");
		}

		//this method kills the connection and retires the bot. 
		public void AbandonShip()
		{
			client.Disconnect();
		}
	}
}
