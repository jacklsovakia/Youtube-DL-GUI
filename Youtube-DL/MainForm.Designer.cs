/*
 * Created by SharpDevelop.
 * User: Jackson
 * Date: 4/24/2016
 * Time: 7:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Youtube_DL
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Button YTButton;
		private System.Windows.Forms.TextBox urlBox;
		private System.Windows.Forms.Button updButton;
		private System.Windows.Forms.TextBox flagoptbox;
		private System.Windows.Forms.Label flagoptboxlabel;
		private System.Windows.Forms.CheckBox playliststartcheck;
		private System.Windows.Forms.TextBox playliststartbox;
		private System.Windows.Forms.TextBox playlistendbox;
		private System.Windows.Forms.CheckBox playlistendcheck;
		private System.Windows.Forms.CheckBox disableplaylistcheck;
		private System.Windows.Forms.TextBox ratelimitbox;
		private System.Windows.Forms.CheckBox ratelimitcheck;
		private System.Windows.Forms.TextBox outputtemplatebox;
		private System.Windows.Forms.CheckBox outputtemplatecheck;
		private System.Windows.Forms.CheckBox overwritecheck;
		private System.Windows.Forms.CheckBox thumbcheck;
		private System.Windows.Forms.CheckBox quietcheck;
		private System.Windows.Forms.CheckBox verbosecheck;
		private System.Windows.Forms.CheckBox nocertcheck;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label qualitylabel;
		private System.Windows.Forms.TextBox customqual;
		private System.Windows.Forms.CheckBox subcheck;
		private System.Windows.Forms.CheckBox autosubcheck;
		private System.Windows.Forms.GroupBox authgroupbox;
		private System.Windows.Forms.TextBox twoauthbox;
		private System.Windows.Forms.CheckBox twoauthcheck;
		private System.Windows.Forms.TextBox passwordbox;
		private System.Windows.Forms.CheckBox passwordcheck;
		private System.Windows.Forms.TextBox usernamebox;
		private System.Windows.Forms.CheckBox usercheck;
		private System.Windows.Forms.Button DownloadButton;
		private System.Windows.Forms.Button listqualbutton;
		private System.Windows.Forms.Button goButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button saveasButton;
		private System.Windows.Forms.CheckBox extaudioCheck;
		private System.Windows.Forms.ComboBox comboBox2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.backButton = new System.Windows.Forms.Button();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.YTButton = new System.Windows.Forms.Button();
			this.urlBox = new System.Windows.Forms.TextBox();
			this.goButton = new System.Windows.Forms.Button();
			this.updButton = new System.Windows.Forms.Button();
			this.flagoptbox = new System.Windows.Forms.TextBox();
			this.flagoptboxlabel = new System.Windows.Forms.Label();
			this.playliststartcheck = new System.Windows.Forms.CheckBox();
			this.playliststartbox = new System.Windows.Forms.TextBox();
			this.playlistendbox = new System.Windows.Forms.TextBox();
			this.playlistendcheck = new System.Windows.Forms.CheckBox();
			this.disableplaylistcheck = new System.Windows.Forms.CheckBox();
			this.ratelimitbox = new System.Windows.Forms.TextBox();
			this.ratelimitcheck = new System.Windows.Forms.CheckBox();
			this.outputtemplatebox = new System.Windows.Forms.TextBox();
			this.outputtemplatecheck = new System.Windows.Forms.CheckBox();
			this.overwritecheck = new System.Windows.Forms.CheckBox();
			this.thumbcheck = new System.Windows.Forms.CheckBox();
			this.quietcheck = new System.Windows.Forms.CheckBox();
			this.verbosecheck = new System.Windows.Forms.CheckBox();
			this.nocertcheck = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.qualitylabel = new System.Windows.Forms.Label();
			this.customqual = new System.Windows.Forms.TextBox();
			this.subcheck = new System.Windows.Forms.CheckBox();
			this.autosubcheck = new System.Windows.Forms.CheckBox();
			this.authgroupbox = new System.Windows.Forms.GroupBox();
			this.twoauthbox = new System.Windows.Forms.TextBox();
			this.twoauthcheck = new System.Windows.Forms.CheckBox();
			this.passwordbox = new System.Windows.Forms.TextBox();
			this.passwordcheck = new System.Windows.Forms.CheckBox();
			this.usernamebox = new System.Windows.Forms.TextBox();
			this.usercheck = new System.Windows.Forms.CheckBox();
			this.DownloadButton = new System.Windows.Forms.Button();
			this.listqualbutton = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.saveasButton = new System.Windows.Forms.Button();
			this.extaudioCheck = new System.Windows.Forms.CheckBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.CommandBox = new System.Windows.Forms.TextBox();
			this.authgroupbox.SuspendLayout();
			this.SuspendLayout();
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(8, 0);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 20);
			this.backButton.TabIndex = 0;
			this.backButton.Text = "Back";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.BackButtonClick);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(0, 25);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.Size = new System.Drawing.Size(1205, 835);
			this.webBrowser1.TabIndex = 4;
			this.webBrowser1.Url = new System.Uri("http://youtube.com", System.UriKind.Absolute);
			this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser1Navigated);
			// 
			// YTButton
			// 
			this.YTButton.Location = new System.Drawing.Point(89, 0);
			this.YTButton.Name = "YTButton";
			this.YTButton.Size = new System.Drawing.Size(75, 20);
			this.YTButton.TabIndex = 1;
			this.YTButton.Text = "Youtube";
			this.YTButton.UseVisualStyleBackColor = true;
			this.YTButton.Click += new System.EventHandler(this.YTButtonClick);
			// 
			// urlBox
			// 
			this.urlBox.AllowDrop = true;
			this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.urlBox.Location = new System.Drawing.Point(171, 0);
			this.urlBox.Name = "urlBox";
			this.urlBox.Size = new System.Drawing.Size(937, 20);
			this.urlBox.TabIndex = 2;
			// 
			// goButton
			// 
			this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.goButton.Location = new System.Drawing.Point(1114, 0);
			this.goButton.Name = "goButton";
			this.goButton.Size = new System.Drawing.Size(75, 20);
			this.goButton.TabIndex = 3;
			this.goButton.Text = "Go";
			this.goButton.UseVisualStyleBackColor = true;
			this.goButton.Click += new System.EventHandler(this.GoButtonClick);
			// 
			// updButton
			// 
			this.updButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.updButton.Location = new System.Drawing.Point(1211, 12);
			this.updButton.Name = "updButton";
			this.updButton.Size = new System.Drawing.Size(80, 23);
			this.updButton.TabIndex = 5;
			this.updButton.TabStop = false;
			this.updButton.Text = "Update";
			this.updButton.UseVisualStyleBackColor = true;
			this.updButton.Click += new System.EventHandler(this.UpdButtonClick);
			// 
			// flagoptbox
			// 
			this.flagoptbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flagoptbox.Location = new System.Drawing.Point(1215, 465);
			this.flagoptbox.Name = "flagoptbox";
			this.flagoptbox.Size = new System.Drawing.Size(361, 20);
			this.flagoptbox.TabIndex = 6;
			this.flagoptbox.TabStop = false;
			// 
			// flagoptboxlabel
			// 
			this.flagoptboxlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flagoptboxlabel.Location = new System.Drawing.Point(1215, 444);
			this.flagoptboxlabel.Name = "flagoptboxlabel";
			this.flagoptboxlabel.Size = new System.Drawing.Size(100, 18);
			this.flagoptboxlabel.TabIndex = 7;
			this.flagoptboxlabel.Text = "Additional Options:";
			// 
			// playliststartcheck
			// 
			this.playliststartcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.playliststartcheck.Location = new System.Drawing.Point(1211, 71);
			this.playliststartcheck.Name = "playliststartcheck";
			this.playliststartcheck.Size = new System.Drawing.Size(104, 24);
			this.playliststartcheck.TabIndex = 8;
			this.playliststartcheck.TabStop = false;
			this.playliststartcheck.Text = "Playlist Start #: ";
			this.playliststartcheck.UseVisualStyleBackColor = true;
			// 
			// playliststartbox
			// 
			this.playliststartbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.playliststartbox.Location = new System.Drawing.Point(1315, 73);
			this.playliststartbox.Name = "playliststartbox";
			this.playliststartbox.Size = new System.Drawing.Size(257, 20);
			this.playliststartbox.TabIndex = 9;
			this.playliststartbox.TabStop = false;
			// 
			// playlistendbox
			// 
			this.playlistendbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.playlistendbox.Location = new System.Drawing.Point(1315, 99);
			this.playlistendbox.Name = "playlistendbox";
			this.playlistendbox.Size = new System.Drawing.Size(257, 20);
			this.playlistendbox.TabIndex = 11;
			this.playlistendbox.TabStop = false;
			// 
			// playlistendcheck
			// 
			this.playlistendcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.playlistendcheck.Location = new System.Drawing.Point(1211, 97);
			this.playlistendcheck.Name = "playlistendcheck";
			this.playlistendcheck.Size = new System.Drawing.Size(104, 24);
			this.playlistendcheck.TabIndex = 10;
			this.playlistendcheck.TabStop = false;
			this.playlistendcheck.Text = "Playlist End #: ";
			this.playlistendcheck.UseVisualStyleBackColor = true;
			// 
			// disableplaylistcheck
			// 
			this.disableplaylistcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.disableplaylistcheck.Checked = true;
			this.disableplaylistcheck.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this.disableplaylistcheck.Location = new System.Drawing.Point(1211, 41);
			this.disableplaylistcheck.Name = "disableplaylistcheck";
			this.disableplaylistcheck.Size = new System.Drawing.Size(122, 24);
			this.disableplaylistcheck.TabIndex = 12;
			this.disableplaylistcheck.TabStop = false;
			this.disableplaylistcheck.Text = "Disable Playlist";
			this.disableplaylistcheck.UseVisualStyleBackColor = true;
			// 
			// ratelimitbox
			// 
			this.ratelimitbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ratelimitbox.Location = new System.Drawing.Point(1315, 129);
			this.ratelimitbox.Name = "ratelimitbox";
			this.ratelimitbox.Size = new System.Drawing.Size(257, 20);
			this.ratelimitbox.TabIndex = 14;
			this.ratelimitbox.TabStop = false;
			// 
			// ratelimitcheck
			// 
			this.ratelimitcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ratelimitcheck.Location = new System.Drawing.Point(1211, 127);
			this.ratelimitcheck.Name = "ratelimitcheck";
			this.ratelimitcheck.Size = new System.Drawing.Size(104, 24);
			this.ratelimitcheck.TabIndex = 13;
			this.ratelimitcheck.TabStop = false;
			this.ratelimitcheck.Text = "Limit Rate:";
			this.ratelimitcheck.UseVisualStyleBackColor = true;
			// 
			// outputtemplatebox
			// 
			this.outputtemplatebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.outputtemplatebox.Location = new System.Drawing.Point(1315, 159);
			this.outputtemplatebox.Name = "outputtemplatebox";
			this.outputtemplatebox.Size = new System.Drawing.Size(257, 20);
			this.outputtemplatebox.TabIndex = 16;
			this.outputtemplatebox.TabStop = false;
			// 
			// outputtemplatecheck
			// 
			this.outputtemplatecheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.outputtemplatecheck.Location = new System.Drawing.Point(1211, 157);
			this.outputtemplatecheck.Name = "outputtemplatecheck";
			this.outputtemplatecheck.Size = new System.Drawing.Size(113, 24);
			this.outputtemplatecheck.TabIndex = 15;
			this.outputtemplatecheck.TabStop = false;
			this.outputtemplatecheck.Text = "Output Template:";
			this.outputtemplatecheck.UseVisualStyleBackColor = true;
			// 
			// overwritecheck
			// 
			this.overwritecheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.overwritecheck.Location = new System.Drawing.Point(1211, 187);
			this.overwritecheck.Name = "overwritecheck";
			this.overwritecheck.Size = new System.Drawing.Size(113, 24);
			this.overwritecheck.TabIndex = 17;
			this.overwritecheck.TabStop = false;
			this.overwritecheck.Text = "Disable Overwrite";
			this.overwritecheck.UseVisualStyleBackColor = true;
			// 
			// thumbcheck
			// 
			this.thumbcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.thumbcheck.Location = new System.Drawing.Point(1211, 217);
			this.thumbcheck.Name = "thumbcheck";
			this.thumbcheck.Size = new System.Drawing.Size(104, 24);
			this.thumbcheck.TabIndex = 18;
			this.thumbcheck.TabStop = false;
			this.thumbcheck.Text = "Write Thumbnail";
			this.thumbcheck.UseVisualStyleBackColor = true;
			// 
			// quietcheck
			// 
			this.quietcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.quietcheck.Location = new System.Drawing.Point(1211, 247);
			this.quietcheck.Name = "quietcheck";
			this.quietcheck.Size = new System.Drawing.Size(104, 24);
			this.quietcheck.TabIndex = 19;
			this.quietcheck.TabStop = false;
			this.quietcheck.Text = "Quiet";
			this.quietcheck.UseVisualStyleBackColor = true;
			// 
			// verbosecheck
			// 
			this.verbosecheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.verbosecheck.Location = new System.Drawing.Point(1315, 247);
			this.verbosecheck.Name = "verbosecheck";
			this.verbosecheck.Size = new System.Drawing.Size(104, 24);
			this.verbosecheck.TabIndex = 20;
			this.verbosecheck.TabStop = false;
			this.verbosecheck.Text = "Verbose";
			this.verbosecheck.UseVisualStyleBackColor = true;
			// 
			// nocertcheck
			// 
			this.nocertcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nocertcheck.Location = new System.Drawing.Point(1425, 247);
			this.nocertcheck.Name = "nocertcheck";
			this.nocertcheck.Size = new System.Drawing.Size(144, 24);
			this.nocertcheck.TabIndex = 21;
			this.nocertcheck.TabStop = false;
			this.nocertcheck.Text = "Don\'t Check Certificates";
			this.nocertcheck.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Choose one:",
									"",
									"best",
									"worst",
									"bestvideo",
									"worstvideo",
									"bestaudio",
									"worstaudio",
									"custom"});
			this.comboBox1.Location = new System.Drawing.Point(1315, 277);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 22;
			this.comboBox1.TabStop = false;
			// 
			// qualitylabel
			// 
			this.qualitylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qualitylabel.Location = new System.Drawing.Point(1211, 280);
			this.qualitylabel.Name = "qualitylabel";
			this.qualitylabel.Size = new System.Drawing.Size(100, 17);
			this.qualitylabel.TabIndex = 23;
			this.qualitylabel.Text = "Quality";
			// 
			// customqual
			// 
			this.customqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.customqual.Location = new System.Drawing.Point(1442, 277);
			this.customqual.Name = "customqual";
			this.customqual.Size = new System.Drawing.Size(130, 20);
			this.customqual.TabIndex = 24;
			this.customqual.TabStop = false;
			// 
			// subcheck
			// 
			this.subcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.subcheck.Location = new System.Drawing.Point(1211, 304);
			this.subcheck.Name = "subcheck";
			this.subcheck.Size = new System.Drawing.Size(104, 24);
			this.subcheck.TabIndex = 25;
			this.subcheck.TabStop = false;
			this.subcheck.Text = "Subtitles";
			this.subcheck.UseVisualStyleBackColor = true;
			// 
			// autosubcheck
			// 
			this.autosubcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.autosubcheck.Location = new System.Drawing.Point(1321, 304);
			this.autosubcheck.Name = "autosubcheck";
			this.autosubcheck.Size = new System.Drawing.Size(125, 24);
			this.autosubcheck.TabIndex = 26;
			this.autosubcheck.TabStop = false;
			this.autosubcheck.Text = "Automatic Subtitles";
			this.autosubcheck.UseVisualStyleBackColor = true;
			// 
			// authgroupbox
			// 
			this.authgroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.authgroupbox.Controls.Add(this.twoauthbox);
			this.authgroupbox.Controls.Add(this.twoauthcheck);
			this.authgroupbox.Controls.Add(this.passwordbox);
			this.authgroupbox.Controls.Add(this.passwordcheck);
			this.authgroupbox.Controls.Add(this.usernamebox);
			this.authgroupbox.Controls.Add(this.usercheck);
			this.authgroupbox.Location = new System.Drawing.Point(1211, 334);
			this.authgroupbox.Name = "authgroupbox";
			this.authgroupbox.Size = new System.Drawing.Size(361, 107);
			this.authgroupbox.TabIndex = 27;
			this.authgroupbox.TabStop = false;
			this.authgroupbox.Text = "Authentication";
			// 
			// twoauthbox
			// 
			this.twoauthbox.Enabled = false;
			this.twoauthbox.Location = new System.Drawing.Point(113, 77);
			this.twoauthbox.Name = "twoauthbox";
			this.twoauthbox.Size = new System.Drawing.Size(242, 20);
			this.twoauthbox.TabIndex = 33;
			this.twoauthbox.TabStop = false;
			// 
			// twoauthcheck
			// 
			this.twoauthcheck.Enabled = false;
			this.twoauthcheck.Location = new System.Drawing.Point(9, 75);
			this.twoauthcheck.Name = "twoauthcheck";
			this.twoauthcheck.Size = new System.Drawing.Size(104, 24);
			this.twoauthcheck.TabIndex = 32;
			this.twoauthcheck.TabStop = false;
			this.twoauthcheck.Text = "2-Factor Auth";
			this.twoauthcheck.UseVisualStyleBackColor = true;
			// 
			// passwordbox
			// 
			this.passwordbox.Enabled = false;
			this.passwordbox.Location = new System.Drawing.Point(113, 47);
			this.passwordbox.Name = "passwordbox";
			this.passwordbox.Size = new System.Drawing.Size(242, 20);
			this.passwordbox.TabIndex = 31;
			this.passwordbox.TabStop = false;
			// 
			// passwordcheck
			// 
			this.passwordcheck.Enabled = false;
			this.passwordcheck.Location = new System.Drawing.Point(9, 45);
			this.passwordcheck.Name = "passwordcheck";
			this.passwordcheck.Size = new System.Drawing.Size(104, 24);
			this.passwordcheck.TabIndex = 30;
			this.passwordcheck.TabStop = false;
			this.passwordcheck.Text = "Password:";
			this.passwordcheck.UseVisualStyleBackColor = true;
			// 
			// usernamebox
			// 
			this.usernamebox.Enabled = false;
			this.usernamebox.Location = new System.Drawing.Point(113, 21);
			this.usernamebox.Name = "usernamebox";
			this.usernamebox.Size = new System.Drawing.Size(242, 20);
			this.usernamebox.TabIndex = 29;
			this.usernamebox.TabStop = false;
			// 
			// usercheck
			// 
			this.usercheck.Enabled = false;
			this.usercheck.Location = new System.Drawing.Point(9, 19);
			this.usercheck.Name = "usercheck";
			this.usercheck.Size = new System.Drawing.Size(104, 24);
			this.usercheck.TabIndex = 28;
			this.usercheck.TabStop = false;
			this.usercheck.Text = "Username:";
			this.usercheck.UseVisualStyleBackColor = true;
			// 
			// DownloadButton
			// 
			this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DownloadButton.Location = new System.Drawing.Point(1215, 491);
			this.DownloadButton.Name = "DownloadButton";
			this.DownloadButton.Size = new System.Drawing.Size(75, 23);
			this.DownloadButton.TabIndex = 28;
			this.DownloadButton.TabStop = false;
			this.DownloadButton.Text = "Download";
			this.DownloadButton.UseVisualStyleBackColor = true;
			this.DownloadButton.Click += new System.EventHandler(this.DownloadButtonClick);
			// 
			// listqualbutton
			// 
			this.listqualbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.listqualbutton.Location = new System.Drawing.Point(1497, 303);
			this.listqualbutton.Name = "listqualbutton";
			this.listqualbutton.Size = new System.Drawing.Size(75, 23);
			this.listqualbutton.TabIndex = 29;
			this.listqualbutton.TabStop = false;
			this.listqualbutton.Text = "List Qualities";
			this.listqualbutton.UseVisualStyleBackColor = true;
			this.listqualbutton.Click += new System.EventHandler(this.ListqualbuttonClick);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "All files|*.*";
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1FileOk);
			// 
			// saveasButton
			// 
			this.saveasButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveasButton.Location = new System.Drawing.Point(1296, 491);
			this.saveasButton.Name = "saveasButton";
			this.saveasButton.Size = new System.Drawing.Size(75, 23);
			this.saveasButton.TabIndex = 30;
			this.saveasButton.TabStop = false;
			this.saveasButton.Text = "Save as...";
			this.saveasButton.UseVisualStyleBackColor = true;
			this.saveasButton.Click += new System.EventHandler(this.SaveasButtonClick);
			// 
			// extaudioCheck
			// 
			this.extaudioCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.extaudioCheck.Location = new System.Drawing.Point(1410, 187);
			this.extaudioCheck.Name = "extaudioCheck";
			this.extaudioCheck.Size = new System.Drawing.Size(166, 24);
			this.extaudioCheck.TabIndex = 31;
			this.extaudioCheck.TabStop = false;
			this.extaudioCheck.Text = "Extract Audio from video files";
			this.extaudioCheck.UseVisualStyleBackColor = true;
			this.extaudioCheck.CheckedChanged += new System.EventHandler(this.ExtaudioCheckCheckedChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox2.Enabled = false;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
									"best",
									"aac",
									"vorbis",
									"mp3",
									"m4a",
									"opus",
									"wav"});
			this.comboBox2.Location = new System.Drawing.Point(1410, 217);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(166, 21);
			this.comboBox2.TabIndex = 32;
			this.comboBox2.TabStop = false;
			this.comboBox2.Text = "mp3";
			// 
			// CommandBox
			// 
			this.CommandBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CommandBox.Location = new System.Drawing.Point(1211, 520);
			this.CommandBox.Name = "CommandBox";
			this.CommandBox.ReadOnly = true;
			this.CommandBox.Size = new System.Drawing.Size(365, 20);
			this.CommandBox.TabIndex = 33;
			this.CommandBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AcceptButton = this.goButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 862);
			this.Controls.Add(this.CommandBox);
			this.Controls.Add(this.goButton);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.YTButton);
			this.Controls.Add(this.extaudioCheck);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.saveasButton);
			this.Controls.Add(this.urlBox);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.listqualbutton);
			this.Controls.Add(this.DownloadButton);
			this.Controls.Add(this.authgroupbox);
			this.Controls.Add(this.autosubcheck);
			this.Controls.Add(this.subcheck);
			this.Controls.Add(this.customqual);
			this.Controls.Add(this.qualitylabel);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.nocertcheck);
			this.Controls.Add(this.verbosecheck);
			this.Controls.Add(this.quietcheck);
			this.Controls.Add(this.thumbcheck);
			this.Controls.Add(this.overwritecheck);
			this.Controls.Add(this.outputtemplatebox);
			this.Controls.Add(this.outputtemplatecheck);
			this.Controls.Add(this.ratelimitbox);
			this.Controls.Add(this.ratelimitcheck);
			this.Controls.Add(this.disableplaylistcheck);
			this.Controls.Add(this.playlistendbox);
			this.Controls.Add(this.playlistendcheck);
			this.Controls.Add(this.playliststartbox);
			this.Controls.Add(this.playliststartcheck);
			this.Controls.Add(this.flagoptboxlabel);
			this.Controls.Add(this.flagoptbox);
			this.Controls.Add(this.updButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Youtube-DL GUI";
			this.AcceptButton = goButton;
			this.authgroupbox.ResumeLayout(false);
			this.authgroupbox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox CommandBox;
	}
}
