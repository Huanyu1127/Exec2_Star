namespace Exec2_Star_
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
			this.rowlbl = new System.Windows.Forms.Label();
			this.rowText = new System.Windows.Forms.TextBox();
			this.inputbtn = new System.Windows.Forms.Button();
			this.inputbtn2 = new System.Windows.Forms.Button();
			this.inputbtn3 = new System.Windows.Forms.Button();
			this.starText = new System.Windows.Forms.TextBox();
			this.starLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rowlbl
			// 
			this.rowlbl.AutoSize = true;
			this.rowlbl.Location = new System.Drawing.Point(127, 70);
			this.rowlbl.Name = "rowlbl";
			this.rowlbl.Size = new System.Drawing.Size(41, 12);
			this.rowlbl.TabIndex = 0;
			this.rowlbl.Text = "列數：";
			this.rowlbl.Click += new System.EventHandler(this.rowlbl_Click);
			// 
			// rowText
			// 
			this.rowText.Location = new System.Drawing.Point(194, 66);
			this.rowText.MaxLength = 2;
			this.rowText.Name = "rowText";
			this.rowText.Size = new System.Drawing.Size(100, 22);
			this.rowText.TabIndex = 1;
			// 
			// inputbtn
			// 
			this.inputbtn.Location = new System.Drawing.Point(387, 65);
			this.inputbtn.Name = "inputbtn";
			this.inputbtn.Size = new System.Drawing.Size(75, 23);
			this.inputbtn.TabIndex = 2;
			this.inputbtn.Text = "靠左三角形";
			this.inputbtn.UseVisualStyleBackColor = true;
			this.inputbtn.Click += new System.EventHandler(this.inputbtn_Click);
			// 
			// inputbtn2
			// 
			this.inputbtn2.Location = new System.Drawing.Point(483, 65);
			this.inputbtn2.Name = "inputbtn2";
			this.inputbtn2.Size = new System.Drawing.Size(75, 23);
			this.inputbtn2.TabIndex = 3;
			this.inputbtn2.Text = "靠右三角形";
			this.inputbtn2.UseVisualStyleBackColor = true;
			this.inputbtn2.Click += new System.EventHandler(this.inputbtn2_Click);
			// 
			// inputbtn3
			// 
			this.inputbtn3.Location = new System.Drawing.Point(579, 65);
			this.inputbtn3.Name = "inputbtn3";
			this.inputbtn3.Size = new System.Drawing.Size(75, 23);
			this.inputbtn3.TabIndex = 4;
			this.inputbtn3.Text = "等腰三角形";
			this.inputbtn3.UseVisualStyleBackColor = true;
			this.inputbtn3.Click += new System.EventHandler(this.inputbtn3_Click);
			// 
			// starText
			// 
			this.starText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.starText.Location = new System.Drawing.Point(129, 128);
			this.starText.Multiline = true;
			this.starText.Name = "starText";
			this.starText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.starText.Size = new System.Drawing.Size(525, 123);
			this.starText.TabIndex = 5;
			// 
			// starLabel
			// 
			this.starLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.starLabel.Location = new System.Drawing.Point(127, 266);
			this.starLabel.Name = "starLabel";
			this.starLabel.Size = new System.Drawing.Size(527, 146);
			this.starLabel.TabIndex = 6;
			this.starLabel.Text = "starLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.starLabel);
			this.Controls.Add(this.starText);
			this.Controls.Add(this.inputbtn3);
			this.Controls.Add(this.inputbtn2);
			this.Controls.Add(this.inputbtn);
			this.Controls.Add(this.rowText);
			this.Controls.Add(this.rowlbl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label rowlbl;
		private System.Windows.Forms.TextBox rowText;
		private System.Windows.Forms.Button inputbtn;
		private System.Windows.Forms.Button inputbtn2;
		private System.Windows.Forms.Button inputbtn3;
		private System.Windows.Forms.TextBox starText;
		private System.Windows.Forms.Label starLabel;
	}
}

