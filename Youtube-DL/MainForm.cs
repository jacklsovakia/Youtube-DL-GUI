using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Youtube_DL
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void BackButtonClick(object sender, EventArgs e)
		{
			webBrowser1.GoBack();
		}
		void WebBrowser1Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			if(webBrowser1.CanGoBack == true)
			{
				backButton.Enabled = true;
			}
			else
			{
				backButton.Enabled = false;
			}
			urlBox.Text = webBrowser1.Url.ToString();
		}
		void YTButtonClick(object sender, EventArgs e)
		{
			webBrowser1.Navigate("http://www.youtube.com");
		}
		void UpdButtonClick(object sender, EventArgs e)
		{
			Process.Start("cmd"," /c \"youtube-dl.exe --update\"");
		}
		void DownloadButtonClick(object sender, EventArgs e)
		{
			string ytdlargs = "";
			if(disableplaylistcheck.Checked == false)
			{
				if(playliststartcheck.Checked == true)
				{
					ytdlargs = ytdlargs + "--playlist-start " + playliststartbox.Text + " ";
				}
				if(playlistendcheck.Checked == true)
				{
					ytdlargs = ytdlargs + "--playlist-end " + playlistendbox.Text + " ";
				}
			}
			else
			{
				ytdlargs = ytdlargs + "--no-playlist ";
			}
			if(ratelimitcheck.Checked == true)
			{
				ytdlargs = ytdlargs + "--rate-limit " + ratelimitbox.Text + " ";
			}
			if(outputtemplatecheck.Checked == true)
			{
				ytdlargs = ytdlargs + "--output " + "\"" + outputtemplatebox.Text + "\" ";
			}
			if(overwritecheck.Checked == true)
			{
				ytdlargs = ytdlargs + "--no-overwrites ";
			}
			if(thumbcheck.Checked == true)
			{
				ytdlargs = ytdlargs + "--write-thumbnail ";
			}
			if(quietcheck.Checked == true && verbosecheck.Checked == false)
			{
				ytdlargs = ytdlargs + "--quiet ";
			}
			else
			{
				if(verbosecheck.Checked == true && quietcheck.Checked == false)
				{
					ytdlargs = ytdlargs + "--verbose ";
				}
			}
			if(nocertcheck.Checked == true)
			{
				ytdlargs = ytdlargs + "--no-check-certificate ";
			}
			if(comboBox1.SelectedIndex != -1)
			{
				if(comboBox1.Items[comboBox1.SelectedIndex] != "Choose one:" && comboBox1.Items[comboBox1.SelectedIndex] != "" && comboBox1.Items[comboBox1.SelectedIndex] != "custom")
					{
						ytdlargs = ytdlargs + "--format " + comboBox1.Items[comboBox1.SelectedIndex] + " ";
					}
					else
					{
						if(comboBox1.Items[comboBox1.SelectedIndex] == "" || comboBox1.Items[comboBox1.SelectedIndex] == "Choose one:")
						{
							MessageBox.Show("Bad Quality", "Bad Input");
						}
						if(comboBox1.Items[comboBox1.SelectedIndex] == "custom")
						{
							ytdlargs = ytdlargs + "--format " + customqual.Text + " ";
						}
					}
			}
			else
			{
				MessageBox.Show("Bad Quality", "Bad Input");
			}
			if(subcheck.Checked == true && autosubcheck.Checked == true)
			{
				MessageBox.Show("Bad Subtitle Options", "Bad Input");
			}
			else
			{
				if(subcheck.Checked == true)
				{
					ytdlargs = ytdlargs + "--write-sub ";
				}
				if(autosubcheck.Checked == true)
				{
					ytdlargs = ytdlargs + "--write-auto-sub ";
				}
			}
			if(flagoptbox.Text != "")
			{
				ytdlargs = ytdlargs + flagoptbox.Text;
			}
			Process.Start("youtube-dl.exe", ytdlargs + " \"" + urlBox.Text + "\"");
		}
		void ListqualbuttonClick(object sender, EventArgs e)
		{
			Process.Start("list.bat", "\"" + urlBox.Text + "\"");
		}
	}
}
