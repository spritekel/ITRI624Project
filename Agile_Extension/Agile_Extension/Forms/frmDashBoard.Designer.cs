
namespace Agile_Extension
{
    partial class frmDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.styleManager1 = new MetroSet_UI.StyleManager();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.tpProject2 = new MetroSet_UI.Child.MetroSetTabPage();
            this.tpProject1 = new MetroSet_UI.Child.MetroSetTabPage();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.elpVoiceChat = new MetroSet_UI.Controls.MetroSetEllipse();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAgendaItems = new MetroSet_UI.Controls.MetroSetListBox();
            this.lblUpcoming = new MetroSet_UI.Controls.MetroSetLabel();
            this.tileSprint3 = new MetroSet_UI.Controls.MetroSetTile();
            this.tileSprint2 = new MetroSet_UI.Controls.MetroSetTile();
            this.tileSprint1 = new MetroSet_UI.Controls.MetroSetTile();
            this.tbProjects = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tpProject1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\henro\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Design.Style.Light;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(818, 13);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // tpProject2
            // 
            this.tpProject2.BaseColor = System.Drawing.Color.White;
            this.tpProject2.ImageIndex = 0;
            this.tpProject2.ImageKey = null;
            this.tpProject2.Location = new System.Drawing.Point(4, 42);
            this.tpProject2.Name = "tpProject2";
            this.tpProject2.Size = new System.Drawing.Size(914, 419);
            this.tpProject2.Style = MetroSet_UI.Design.Style.Light;
            this.tpProject2.StyleManager = null;
            this.tpProject2.TabIndex = 1;
            this.tpProject2.Text = "Project 2";
            this.tpProject2.ThemeAuthor = "Narwin";
            this.tpProject2.ThemeName = "MetroLite";
            this.tpProject2.ToolTipText = null;
            // 
            // tpProject1
            // 
            this.tpProject1.BaseColor = System.Drawing.Color.White;
            this.tpProject1.Controls.Add(this.circularProgressBar1);
            this.tpProject1.Controls.Add(this.elpVoiceChat);
            this.tpProject1.Controls.Add(this.panel1);
            this.tpProject1.Controls.Add(this.tileSprint3);
            this.tpProject1.Controls.Add(this.tileSprint2);
            this.tpProject1.Controls.Add(this.tileSprint1);
            this.tpProject1.ImageIndex = 0;
            this.tpProject1.ImageKey = null;
            this.tpProject1.Location = new System.Drawing.Point(4, 42);
            this.tpProject1.Name = "tpProject1";
            this.tpProject1.Size = new System.Drawing.Size(914, 419);
            this.tpProject1.Style = MetroSet_UI.Design.Style.Light;
            this.tpProject1.StyleManager = null;
            this.tpProject1.TabIndex = 0;
            this.tpProject1.Text = "Project 1";
            this.tpProject1.ThemeAuthor = "Narwin";
            this.tpProject1.ThemeName = "MetroLite";
            this.tpProject1.ToolTipText = null;
            this.tpProject1.Click += new System.EventHandler(this.tpProject1_Click);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Silver;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(238, 241);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Silver;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 20;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.circularProgressBar1.ProgressWidth = 19;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.circularProgressBar1.Size = new System.Drawing.Size(191, 163);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "65";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 6;
            this.circularProgressBar1.Text = "Progress";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // elpVoiceChat
            // 
            this.elpVoiceChat.BorderThickness = 7;
            this.elpVoiceChat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.elpVoiceChat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.elpVoiceChat.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.elpVoiceChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.elpVoiceChat.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.elpVoiceChat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.elpVoiceChat.HoverTextColor = System.Drawing.Color.White;
            this.elpVoiceChat.Image = null;
            this.elpVoiceChat.ImageSize = new System.Drawing.Size(64, 64);
            this.elpVoiceChat.Location = new System.Drawing.Point(15, 241);
            this.elpVoiceChat.Name = "elpVoiceChat";
            this.elpVoiceChat.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.elpVoiceChat.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.elpVoiceChat.NormalTextColor = System.Drawing.Color.Black;
            this.elpVoiceChat.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.elpVoiceChat.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.elpVoiceChat.PressTextColor = System.Drawing.Color.White;
            this.elpVoiceChat.Size = new System.Drawing.Size(192, 163);
            this.elpVoiceChat.Style = MetroSet_UI.Design.Style.Light;
            this.elpVoiceChat.StyleManager = null;
            this.elpVoiceChat.TabIndex = 4;
            this.elpVoiceChat.Text = "Voice Chat";
            this.elpVoiceChat.ThemeAuthor = "Narwin";
            this.elpVoiceChat.ThemeName = "MetroLite";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbAgendaItems);
            this.panel1.Controls.Add(this.lblUpcoming);
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(627, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 248);
            this.panel1.TabIndex = 3;
            // 
            // lbAgendaItems
            // 
            this.lbAgendaItems.BorderColor = System.Drawing.Color.LightGray;
            this.lbAgendaItems.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbAgendaItems.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lbAgendaItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAgendaItems.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.lbAgendaItems.HoveredItemColor = System.Drawing.Color.DimGray;
            this.lbAgendaItems.ItemHeight = 30;
            this.lbAgendaItems.Items.Add("Setup GUI");
            this.lbAgendaItems.Items.Add("Voice Chat integration");
            this.lbAgendaItems.Items.Add("Meeting with Project Manager");
            this.lbAgendaItems.Location = new System.Drawing.Point(26, 46);
            this.lbAgendaItems.MultiSelect = false;
            this.lbAgendaItems.Name = "lbAgendaItems";
            this.lbAgendaItems.SelectedIndex = -1;
            this.lbAgendaItems.SelectedItem = null;
            this.lbAgendaItems.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lbAgendaItems.SelectedItemColor = System.Drawing.Color.White;
            this.lbAgendaItems.SelectedValue = null;
            this.lbAgendaItems.ShowBorder = true;
            this.lbAgendaItems.ShowScrollBar = true;
            this.lbAgendaItems.Size = new System.Drawing.Size(228, 202);
            this.lbAgendaItems.Style = MetroSet_UI.Design.Style.Light;
            this.lbAgendaItems.StyleManager = null;
            this.lbAgendaItems.TabIndex = 1;
            this.lbAgendaItems.ThemeAuthor = "Narwin";
            this.lbAgendaItems.ThemeName = "MetroLite";
            // 
            // lblUpcoming
            // 
            this.lblUpcoming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblUpcoming.Location = new System.Drawing.Point(3, 17);
            this.lblUpcoming.Name = "lblUpcoming";
            this.lblUpcoming.Size = new System.Drawing.Size(266, 23);
            this.lblUpcoming.Style = MetroSet_UI.Design.Style.Light;
            this.lblUpcoming.StyleManager = null;
            this.lblUpcoming.TabIndex = 0;
            this.lblUpcoming.Text = "Agenda\r\n";
            this.lblUpcoming.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUpcoming.ThemeAuthor = "Narwin";
            this.lblUpcoming.ThemeName = "MetroLite";
            // 
            // tileSprint3
            // 
            this.tileSprint3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tileSprint3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tileSprint3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tileSprint3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tileSprint3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileSprint3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint3.HoverTextColor = System.Drawing.Color.White;
            this.tileSprint3.Location = new System.Drawing.Point(521, 13);
            this.tileSprint3.Name = "tileSprint3";
            this.tileSprint3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint3.NormalTextColor = System.Drawing.Color.White;
            this.tileSprint3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint3.PressTextColor = System.Drawing.Color.White;
            this.tileSprint3.Size = new System.Drawing.Size(229, 95);
            this.tileSprint3.Style = MetroSet_UI.Design.Style.Light;
            this.tileSprint3.StyleManager = null;
            this.tileSprint3.TabIndex = 2;
            this.tileSprint3.Text = "Sprint 3";
            this.tileSprint3.ThemeAuthor = "Narwin";
            this.tileSprint3.ThemeName = "MetroLite";
            this.tileSprint3.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            // 
            // tileSprint2
            // 
            this.tileSprint2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tileSprint2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tileSprint2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tileSprint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tileSprint2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileSprint2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint2.HoverTextColor = System.Drawing.Color.White;
            this.tileSprint2.Location = new System.Drawing.Point(268, 13);
            this.tileSprint2.Name = "tileSprint2";
            this.tileSprint2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint2.NormalTextColor = System.Drawing.Color.White;
            this.tileSprint2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint2.PressTextColor = System.Drawing.Color.White;
            this.tileSprint2.Size = new System.Drawing.Size(229, 95);
            this.tileSprint2.Style = MetroSet_UI.Design.Style.Light;
            this.tileSprint2.StyleManager = null;
            this.tileSprint2.TabIndex = 1;
            this.tileSprint2.Text = "Sprint 2";
            this.tileSprint2.ThemeAuthor = "Narwin";
            this.tileSprint2.ThemeName = "MetroLite";
            this.tileSprint2.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            // 
            // tileSprint1
            // 
            this.tileSprint1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tileSprint1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tileSprint1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tileSprint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tileSprint1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileSprint1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint1.HoverTextColor = System.Drawing.Color.White;
            this.tileSprint1.Location = new System.Drawing.Point(15, 13);
            this.tileSprint1.Name = "tileSprint1";
            this.tileSprint1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint1.NormalTextColor = System.Drawing.Color.White;
            this.tileSprint1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tileSprint1.PressTextColor = System.Drawing.Color.White;
            this.tileSprint1.Size = new System.Drawing.Size(229, 95);
            this.tileSprint1.Style = MetroSet_UI.Design.Style.Light;
            this.tileSprint1.StyleManager = null;
            this.tileSprint1.TabIndex = 0;
            this.tileSprint1.Text = "Sprint 1";
            this.tileSprint1.ThemeAuthor = "Narwin";
            this.tileSprint1.ThemeName = "MetroLite";
            this.tileSprint1.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            // 
            // tbProjects
            // 
            this.tbProjects.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbProjects.AnimateTime = 200;
            this.tbProjects.Controls.Add(this.tpProject1);
            this.tbProjects.Controls.Add(this.tpProject2);
            this.tbProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbProjects.ItemSize = new System.Drawing.Size(100, 38);
            this.tbProjects.Location = new System.Drawing.Point(15, 95);
            this.tbProjects.Name = "tbProjects";
            this.tbProjects.SelectedIndex = 0;
            this.tbProjects.Size = new System.Drawing.Size(922, 465);
            this.tbProjects.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbProjects.Speed = 20;
            this.tbProjects.Style = MetroSet_UI.Design.Style.Light;
            this.tbProjects.StyleManager = this.styleManager1;
            this.tbProjects.TabIndex = 2;
            this.tbProjects.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.tbProjects.ThemeAuthor = "Narwin";
            this.tbProjects.ThemeName = "MetroLite";
            this.tbProjects.UseAnimation = true;
            // 
            // frmDashBoard
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 575);
            this.Controls.Add(this.tbProjects);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "frmDashBoard";
            this.StyleManager = this.styleManager1;
            this.Text = "Agile Dashboard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.tpProject1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tbProjects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl tbProjects;
        private MetroSet_UI.Child.MetroSetTabPage tpProject1;
        private MetroSet_UI.Child.MetroSetTabPage tpProject2;
        private MetroSet_UI.Controls.MetroSetTile tileSprint2;
        private MetroSet_UI.Controls.MetroSetTile tileSprint1;
        private MetroSet_UI.Controls.MetroSetTile tileSprint3;
        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetLabel lblUpcoming;
        private MetroSet_UI.Controls.MetroSetEllipse elpVoiceChat;
        private MetroSet_UI.Controls.MetroSetListBox lbAgendaItems;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}

