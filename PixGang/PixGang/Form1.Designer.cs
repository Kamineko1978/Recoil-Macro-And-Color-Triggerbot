
namespace PixGang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toggleTrigger = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.xTriggerLabel = new System.Windows.Forms.Label();
            this.xTriggerTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.yTriggerTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.xValueLabel = new System.Windows.Forms.Label();
            this.yValueLabel = new System.Windows.Forms.Label();
            this.topMost = new MetroFramework.Controls.MetroCheckBox();
            this.triggerDelay = new MetroFramework.Controls.MetroTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.triggerDelayLabel = new System.Windows.Forms.Label();
            this.toggleRecoil = new MetroFramework.Controls.MetroCheckBox();
            this.adsToggle = new MetroFramework.Controls.MetroCheckBox();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.strength = new MetroFramework.Controls.MetroTrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speed = new MetroFramework.Controls.MetroTrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.yAxisLabel = new System.Windows.Forms.Label();
            this.yAxis = new MetroFramework.Controls.MetroTrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.xAxisLabel = new System.Windows.Forms.Label();
            this.xAxis = new MetroFramework.Controls.MetroTrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.triggerbotConfigName = new MetroFramework.Controls.MetroTextBox();
            this.loadTriggerbotConfig = new MetroFramework.Controls.MetroButton();
            this.saveTriggerbotConfig = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.loadRecoilConfig = new MetroFramework.Controls.MetroButton();
            this.saveRecoilConfig = new MetroFramework.Controls.MetroButton();
            this.recoilConfigName = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toggleTrigger
            // 
            resources.ApplyResources(this.toggleTrigger, "toggleTrigger");
            this.toggleTrigger.Name = "toggleTrigger";
            this.toggleTrigger.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleTrigger.UseSelectable = true;
            this.toggleTrigger.CheckedChanged += new System.EventHandler(this.toggleTrigger_CheckedChanged);
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            // 
            // xTriggerLabel
            // 
            resources.ApplyResources(this.xTriggerLabel, "xTriggerLabel");
            this.xTriggerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.xTriggerLabel.ForeColor = System.Drawing.Color.White;
            this.xTriggerLabel.Name = "xTriggerLabel";
            // 
            // xTriggerTrackBar
            // 
            this.xTriggerTrackBar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.xTriggerTrackBar, "xTriggerTrackBar");
            this.xTriggerTrackBar.Maximum = 10;
            this.xTriggerTrackBar.Name = "xTriggerTrackBar";
            this.xTriggerTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xTriggerTrackBar.Value = 0;
            this.xTriggerTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.xTriggerTrackBar_Scroll);
            // 
            // yTriggerTrackBar
            // 
            this.yTriggerTrackBar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.yTriggerTrackBar, "yTriggerTrackBar");
            this.yTriggerTrackBar.Maximum = 10;
            this.yTriggerTrackBar.Name = "yTriggerTrackBar";
            this.yTriggerTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.yTriggerTrackBar.Value = 0;
            this.yTriggerTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.yTriggerTrackBar_Scroll);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // xValueLabel
            // 
            resources.ApplyResources(this.xValueLabel, "xValueLabel");
            this.xValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.xValueLabel.ForeColor = System.Drawing.Color.White;
            this.xValueLabel.Name = "xValueLabel";
            // 
            // yValueLabel
            // 
            resources.ApplyResources(this.yValueLabel, "yValueLabel");
            this.yValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.yValueLabel.ForeColor = System.Drawing.Color.White;
            this.yValueLabel.Name = "yValueLabel";
            // 
            // topMost
            // 
            resources.ApplyResources(this.topMost, "topMost");
            this.topMost.Name = "topMost";
            this.topMost.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.topMost.UseSelectable = true;
            this.topMost.CheckedChanged += new System.EventHandler(this.topMost_CheckedChanged);
            // 
            // triggerDelay
            // 
            this.triggerDelay.BackColor = System.Drawing.Color.Transparent;
            this.triggerDelay.LargeChange = 1000;
            resources.ApplyResources(this.triggerDelay, "triggerDelay");
            this.triggerDelay.Maximum = 2000;
            this.triggerDelay.Minimum = 100;
            this.triggerDelay.MouseWheelBarPartitions = 100;
            this.triggerDelay.Name = "triggerDelay";
            this.triggerDelay.SmallChange = 100;
            this.triggerDelay.Style = MetroFramework.MetroColorStyle.Yellow;
            this.triggerDelay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.triggerDelay.Value = 1000;
            this.triggerDelay.Scroll += new System.Windows.Forms.ScrollEventHandler(this.triggerDelay_Scroll);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // triggerDelayLabel
            // 
            resources.ApplyResources(this.triggerDelayLabel, "triggerDelayLabel");
            this.triggerDelayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.triggerDelayLabel.ForeColor = System.Drawing.Color.White;
            this.triggerDelayLabel.Name = "triggerDelayLabel";
            // 
            // toggleRecoil
            // 
            resources.ApplyResources(this.toggleRecoil, "toggleRecoil");
            this.toggleRecoil.Name = "toggleRecoil";
            this.toggleRecoil.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleRecoil.UseSelectable = true;
            this.toggleRecoil.CheckedChanged += new System.EventHandler(this.toggleRecoil_CheckedChanged);
            // 
            // adsToggle
            // 
            resources.ApplyResources(this.adsToggle, "adsToggle");
            this.adsToggle.Name = "adsToggle";
            this.adsToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.adsToggle.UseSelectable = true;
            this.adsToggle.CheckedChanged += new System.EventHandler(this.adsToggle_CheckedChanged);
            // 
            // strengthLabel
            // 
            resources.ApplyResources(this.strengthLabel, "strengthLabel");
            this.strengthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.strengthLabel.ForeColor = System.Drawing.Color.White;
            this.strengthLabel.Name = "strengthLabel";
            // 
            // strength
            // 
            this.strength.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.strength, "strength");
            this.strength.Maximum = 20;
            this.strength.Name = "strength";
            this.strength.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.strength.Value = 0;
            this.strength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.strength_Scroll);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // speedLabel
            // 
            resources.ApplyResources(this.speedLabel, "speedLabel");
            this.speedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Name = "speedLabel";
            // 
            // speed
            // 
            this.speed.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.speed, "speed");
            this.speed.Maximum = 20;
            this.speed.Name = "speed";
            this.speed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.speed.Value = 0;
            this.speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speed_Scroll);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // yAxisLabel
            // 
            resources.ApplyResources(this.yAxisLabel, "yAxisLabel");
            this.yAxisLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.yAxisLabel.ForeColor = System.Drawing.Color.White;
            this.yAxisLabel.Name = "yAxisLabel";
            // 
            // yAxis
            // 
            this.yAxis.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.yAxis, "yAxis");
            this.yAxis.Maximum = 20;
            this.yAxis.Minimum = -20;
            this.yAxis.Name = "yAxis";
            this.yAxis.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.yAxis.Value = 0;
            this.yAxis.Scroll += new System.Windows.Forms.ScrollEventHandler(this.yAxis_Scroll);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // xAxisLabel
            // 
            resources.ApplyResources(this.xAxisLabel, "xAxisLabel");
            this.xAxisLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.xAxisLabel.ForeColor = System.Drawing.Color.White;
            this.xAxisLabel.Name = "xAxisLabel";
            // 
            // xAxis
            // 
            this.xAxis.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.xAxis, "xAxis");
            this.xAxis.Maximum = 20;
            this.xAxis.Minimum = -20;
            this.xAxis.Name = "xAxis";
            this.xAxis.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xAxis.Value = 0;
            this.xAxis.Scroll += new System.Windows.Forms.ScrollEventHandler(this.xAxis_Scroll);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            resources.ApplyResources(this.metroTabControl1, "metroTabControl1");
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.WindowText;
            this.metroTabPage1.Controls.Add(this.triggerbotConfigName);
            this.metroTabPage1.Controls.Add(this.loadTriggerbotConfig);
            this.metroTabPage1.Controls.Add(this.saveTriggerbotConfig);
            this.metroTabPage1.Controls.Add(this.toggleTrigger);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.xTriggerLabel);
            this.metroTabPage1.Controls.Add(this.xTriggerTrackBar);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.yTriggerTrackBar);
            this.metroTabPage1.Controls.Add(this.xValueLabel);
            this.metroTabPage1.Controls.Add(this.yValueLabel);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.triggerDelay);
            this.metroTabPage1.Controls.Add(this.triggerDelayLabel);
            this.metroTabPage1.ForeColor = System.Drawing.Color.Transparent;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroTabPage1, "metroTabPage1");
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // triggerbotConfigName
            // 
            // 
            // 
            // 
            this.triggerbotConfigName.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.triggerbotConfigName.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.triggerbotConfigName.CustomButton.Name = "";
            this.triggerbotConfigName.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.triggerbotConfigName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.triggerbotConfigName.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.triggerbotConfigName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.triggerbotConfigName.CustomButton.UseSelectable = true;
            this.triggerbotConfigName.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.triggerbotConfigName.Lines = new string[0];
            resources.ApplyResources(this.triggerbotConfigName, "triggerbotConfigName");
            this.triggerbotConfigName.MaxLength = 32767;
            this.triggerbotConfigName.Name = "triggerbotConfigName";
            this.triggerbotConfigName.PasswordChar = '\0';
            this.triggerbotConfigName.PromptText = "Config Name";
            this.triggerbotConfigName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.triggerbotConfigName.SelectedText = "";
            this.triggerbotConfigName.SelectionLength = 0;
            this.triggerbotConfigName.SelectionStart = 0;
            this.triggerbotConfigName.ShortcutsEnabled = true;
            this.triggerbotConfigName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.triggerbotConfigName.UseSelectable = true;
            this.triggerbotConfigName.WaterMark = "Config Name";
            this.triggerbotConfigName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.triggerbotConfigName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loadTriggerbotConfig
            // 
            resources.ApplyResources(this.loadTriggerbotConfig, "loadTriggerbotConfig");
            this.loadTriggerbotConfig.Name = "loadTriggerbotConfig";
            this.loadTriggerbotConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadTriggerbotConfig.UseSelectable = true;
            this.loadTriggerbotConfig.Click += new System.EventHandler(this.loadTriggerbotConfig_Click);
            // 
            // saveTriggerbotConfig
            // 
            resources.ApplyResources(this.saveTriggerbotConfig, "saveTriggerbotConfig");
            this.saveTriggerbotConfig.Name = "saveTriggerbotConfig";
            this.saveTriggerbotConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saveTriggerbotConfig.UseSelectable = true;
            this.saveTriggerbotConfig.Click += new System.EventHandler(this.saveTriggerbotConfig_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.recoilConfigName);
            this.metroTabPage2.Controls.Add(this.loadRecoilConfig);
            this.metroTabPage2.Controls.Add(this.saveRecoilConfig);
            this.metroTabPage2.Controls.Add(this.yAxisLabel);
            this.metroTabPage2.Controls.Add(this.yAxis);
            this.metroTabPage2.Controls.Add(this.toggleRecoil);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.adsToggle);
            this.metroTabPage2.Controls.Add(this.xAxisLabel);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.xAxis);
            this.metroTabPage2.Controls.Add(this.strength);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.Controls.Add(this.strengthLabel);
            this.metroTabPage2.Controls.Add(this.speedLabel);
            this.metroTabPage2.Controls.Add(this.label6);
            this.metroTabPage2.Controls.Add(this.speed);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroTabPage2, "metroTabPage2");
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // loadRecoilConfig
            // 
            resources.ApplyResources(this.loadRecoilConfig, "loadRecoilConfig");
            this.loadRecoilConfig.Name = "loadRecoilConfig";
            this.loadRecoilConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadRecoilConfig.UseSelectable = true;
            this.loadRecoilConfig.Click += new System.EventHandler(this.loadRecoilConfig_Click);
            // 
            // saveRecoilConfig
            // 
            resources.ApplyResources(this.saveRecoilConfig, "saveRecoilConfig");
            this.saveRecoilConfig.Name = "saveRecoilConfig";
            this.saveRecoilConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saveRecoilConfig.UseSelectable = true;
            this.saveRecoilConfig.Click += new System.EventHandler(this.saveRecoilConfig_Click);
            // 
            // recoilConfigName
            // 
            // 
            // 
            // 
            this.recoilConfigName.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.recoilConfigName.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.recoilConfigName.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.recoilConfigName.CustomButton.Name = "";
            this.recoilConfigName.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.recoilConfigName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.recoilConfigName.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.recoilConfigName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.recoilConfigName.CustomButton.UseSelectable = true;
            this.recoilConfigName.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.recoilConfigName.Lines = new string[0];
            resources.ApplyResources(this.recoilConfigName, "recoilConfigName");
            this.recoilConfigName.MaxLength = 32767;
            this.recoilConfigName.Name = "recoilConfigName";
            this.recoilConfigName.PasswordChar = '\0';
            this.recoilConfigName.PromptText = "Config Name";
            this.recoilConfigName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.recoilConfigName.SelectedText = "";
            this.recoilConfigName.SelectionLength = 0;
            this.recoilConfigName.SelectionStart = 0;
            this.recoilConfigName.ShortcutsEnabled = true;
            this.recoilConfigName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.recoilConfigName.UseSelectable = true;
            this.recoilConfigName.WaterMark = "Config Name";
            this.recoilConfigName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.recoilConfigName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroTabPage3, "metroTabPage3");
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.topMost);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroTabPage4, "metroTabPage4");
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox toggleTrigger;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label xTriggerLabel;
        private MetroFramework.Controls.MetroTrackBar xTriggerTrackBar;
        private MetroFramework.Controls.MetroTrackBar yTriggerTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xValueLabel;
        private System.Windows.Forms.Label yValueLabel;
        private MetroFramework.Controls.MetroCheckBox topMost;
        private MetroFramework.Controls.MetroTrackBar triggerDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label triggerDelayLabel;
        private MetroFramework.Controls.MetroCheckBox toggleRecoil;
        private MetroFramework.Controls.MetroCheckBox adsToggle;
        private System.Windows.Forms.Label strengthLabel;
        private MetroFramework.Controls.MetroTrackBar strength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label speedLabel;
        private MetroFramework.Controls.MetroTrackBar speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label yAxisLabel;
        private MetroFramework.Controls.MetroTrackBar yAxis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label xAxisLabel;
        private MetroFramework.Controls.MetroTrackBar xAxis;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton saveRecoilConfig;
        private MetroFramework.Controls.MetroButton loadTriggerbotConfig;
        private MetroFramework.Controls.MetroButton saveTriggerbotConfig;
        private MetroFramework.Controls.MetroButton loadRecoilConfig;
        private MetroFramework.Controls.MetroTextBox triggerbotConfigName;
        private MetroFramework.Controls.MetroTextBox recoilConfigName;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
    }
}

