namespace WA.WinAPP.FourDicesGame
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.playButton = new System.Windows.Forms.Button();
			this.historyTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// playButton
			// 
			this.playButton.Location = new System.Drawing.Point(31, 30);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(75, 23);
			this.playButton.TabIndex = 0;
			this.playButton.Text = "Play";
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// historyTextBox
			// 
			this.historyTextBox.Location = new System.Drawing.Point(31, 60);
			this.historyTextBox.Multiline = true;
			this.historyTextBox.Name = "historyTextBox";
			this.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.historyTextBox.Size = new System.Drawing.Size(273, 305);
			this.historyTextBox.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 397);
			this.Controls.Add(this.historyTextBox);
			this.Controls.Add(this.playButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button playButton;
		private System.Windows.Forms.TextBox historyTextBox;
	}
}

