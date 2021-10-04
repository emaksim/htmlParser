namespace HTMLParser
{
	partial class HabrTitleSearch
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabrTitleSearch));
			this.ListTitles = new System.Windows.Forms.ListBox();
			this.StartPoint = new System.Windows.Forms.Label();
			this.numericStart = new System.Windows.Forms.NumericUpDown();
			this.numericEnd = new System.Windows.Forms.NumericUpDown();
			this.EndPoint = new System.Windows.Forms.Label();
			this.ButtonStart = new System.Windows.Forms.Button();
			this.ButtonStop = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.clearButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
			this.SuspendLayout();
			// 
			// ListTitles
			// 
			this.ListTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ListTitles.FormattingEnabled = true;
			this.ListTitles.ItemHeight = 15;
			this.ListTitles.Location = new System.Drawing.Point(12, 13);
			this.ListTitles.Name = "ListTitles";
			this.ListTitles.Size = new System.Drawing.Size(429, 424);
			this.ListTitles.TabIndex = 0;
			this.ListTitles.SelectedIndexChanged += new System.EventHandler(this.ListTitles_SelectedIndexChanged);
			// 
			// StartPoint
			// 
			this.StartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartPoint.AutoSize = true;
			this.StartPoint.Location = new System.Drawing.Point(457, 13);
			this.StartPoint.Name = "StartPoint";
			this.StartPoint.Size = new System.Drawing.Size(121, 15);
			this.StartPoint.TabIndex = 1;
			this.StartPoint.Text = "Начальная страница";
			// 
			// numericStart
			// 
			this.numericStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericStart.Location = new System.Drawing.Point(457, 41);
			this.numericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericStart.Name = "numericStart";
			this.numericStart.Size = new System.Drawing.Size(120, 23);
			this.numericStart.TabIndex = 2;
			this.numericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericEnd
			// 
			this.numericEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericEnd.Location = new System.Drawing.Point(457, 122);
			this.numericEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericEnd.Name = "numericEnd";
			this.numericEnd.Size = new System.Drawing.Size(120, 23);
			this.numericEnd.TabIndex = 4;
			this.numericEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// EndPoint
			// 
			this.EndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EndPoint.AutoSize = true;
			this.EndPoint.Location = new System.Drawing.Point(457, 94);
			this.EndPoint.Name = "EndPoint";
			this.EndPoint.Size = new System.Drawing.Size(114, 15);
			this.EndPoint.TabIndex = 3;
			this.EndPoint.Text = "Конечная страница";
			// 
			// ButtonStart
			// 
			this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonStart.Location = new System.Drawing.Point(457, 170);
			this.ButtonStart.Name = "ButtonStart";
			this.ButtonStart.Size = new System.Drawing.Size(120, 23);
			this.ButtonStart.TabIndex = 5;
			this.ButtonStart.Text = "Старт";
			this.ButtonStart.UseVisualStyleBackColor = true;
			this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			// 
			// ButtonStop
			// 
			this.ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonStop.Location = new System.Drawing.Point(457, 208);
			this.ButtonStop.Name = "ButtonStop";
			this.ButtonStop.Size = new System.Drawing.Size(120, 23);
			this.ButtonStop.TabIndex = 6;
			this.ButtonStop.Text = "Остановить";
			this.ButtonStop.UseVisualStyleBackColor = true;
			this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(457, 414);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(130, 23);
			this.progressBar.TabIndex = 7;
			// 
			// clearButton
			// 
			this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clearButton.Location = new System.Drawing.Point(458, 250);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(120, 23);
			this.clearButton.TabIndex = 8;
			this.clearButton.Text = "Очистить";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// HabrTitleSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 450);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.ButtonStop);
			this.Controls.Add(this.ButtonStart);
			this.Controls.Add(this.numericEnd);
			this.Controls.Add(this.EndPoint);
			this.Controls.Add(this.numericStart);
			this.Controls.Add(this.StartPoint);
			this.Controls.Add(this.ListTitles);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HabrTitleSearch";
			this.Text = "HabrTitleSearch";
			((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ListTitles;
		private System.Windows.Forms.Label StartPoint;
		private System.Windows.Forms.NumericUpDown numericStart;
		private System.Windows.Forms.NumericUpDown numericEnd;
		private System.Windows.Forms.Label EndPoint;
		private System.Windows.Forms.Button ButtonStart;
		private System.Windows.Forms.Button ButtonStop;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button clearButton;
	}
}