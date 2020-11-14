using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechaSquirrelInterface
{
	public partial class MainMenu : Form
	{
		
		public string dataToSend;
		public Bot twitchBot;
		private string ovenFile = "oven.bake";

		public MainMenu()
		{
			Misc.CheckFile(ovenFile);

			InitializeComponent();
			ChangeLogLabel("Thanks to TwitchLib for being awesome and allowing this all to work!");
			ChangeLogLabel("Thank you Isaac Discord for helping me sort out the spawning bug");
			if (!System.IO.File.Exists("main.lua"))
			{
				ChangeLogLabel("main.lua is missing. Bot is not running from the mod folder");
			}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			lblConsole.Text = txtChatInput.Text;
			twitchBot.AnnoyChat(txtChatInput.Text);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			bool fieldCheckSuccess = true;
			if(String.IsNullOrWhiteSpace(txtChannel.Text))
			{
				fieldCheckSuccess = false;
				ChangeLogLabel("Please Specify a Channel to connect to.");
			}
			if (String.IsNullOrWhiteSpace(txtUsername.Text))
			{
				fieldCheckSuccess = false;
				ChangeLogLabel("Please specify a user name to log into");
			}
			if (String.IsNullOrWhiteSpace(txtCode.Text))
			{
				fieldCheckSuccess = false;
				ChangeLogLabel("Please input your auth code");
			}
			
			if (fieldCheckSuccess)
			{
				twitchBot = new Bot(txtChannel.Text, txtUsername.Text, txtCode.Text, ckbIsMultiplier.Checked, ckbIsSpamControl.Checked, ckbIsMulti.Checked, 0, this);
			}
		}
		

		private void btnShow_Click(object sender, EventArgs e)
		{
			txtUsername.PasswordChar = '\0';
			txtChannel.PasswordChar = '\0';
			txtCode.PasswordChar = '\0';
			
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			txtUsername.PasswordChar = '*';
			txtChannel.PasswordChar = '*';
			txtCode.PasswordChar = '*';
			
		}
		private void LoadData()
		{
			//check if the file exists
			//if not, then create it, and then GTFO.
			//if it does import the lines in as a list.
			//if the list has more than 4 entries, throw an error.
			//set each text box value to the entries in the list by index.
			return;
		}
		private void SaveData()
		{
			//check if the file exists
			//if not then create it.
			//write text box data to each line.
			return;
		}
		public void showLog(string message)
		{
			return;
		}

		private void lblData_Click(object sender, EventArgs e)
		{

		}

		public void ChangeLogLabel(string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(ChangeLogLabel), new object[] { value });
				return;
			}
			txtReadout.AppendText("\r\n");
			txtReadout.AppendText(value);
			
			//txtReadout.Text += "\r\n";
		}
		public void DisableMenu(string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(DisableMenu), new object[] { value });
				return;
			}
			btnStart.Enabled = false;
			btnSend.Enabled = true;
			txtCode.Enabled = false;
			txtUsername.Enabled = false;
			txtChannel.Enabled = false;
			btnDisconnect.Enabled = true;
		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			twitchBot.AbandonShip();
			btnStart.Enabled = true;
			txtCode.Enabled = true;
			txtUsername.Enabled = true;
			txtChannel.Enabled = true;
			btnDisconnect.Enabled = false;
			btnSend.Enabled = false;
		}



		private void sldSpamControl_Scroll(object sender, ScrollEventArgs e)
		{
			return;
		}
	}


}
