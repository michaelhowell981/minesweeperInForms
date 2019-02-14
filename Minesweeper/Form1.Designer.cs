namespace Minesweeper
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
			this.scoreLable = new System.Windows.Forms.Label();
			this.bombsRemainingLable = new System.Windows.Forms.Label();
			this.timeLable = new System.Windows.Forms.Label();
			this.heightLable = new System.Windows.Forms.Label();
			this.widthLable = new System.Windows.Forms.Label();
			this.difficultyLable = new System.Windows.Forms.Label();
			this.difficultySetting = new System.Windows.Forms.ComboBox();
			this.playButton = new System.Windows.Forms.Button();
			this.gridHeight = new System.Windows.Forms.NumericUpDown();
			this.gridWidth = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.gridHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// scoreLable
			// 
			this.scoreLable.AutoSize = true;
			this.scoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreLable.Location = new System.Drawing.Point(13, 13);
			this.scoreLable.Name = "scoreLable";
			this.scoreLable.Size = new System.Drawing.Size(55, 17);
			this.scoreLable.TabIndex = 0;
			this.scoreLable.Text = "Score:";
			// 
			// bombsRemainingLable
			// 
			this.bombsRemainingLable.AutoSize = true;
			this.bombsRemainingLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bombsRemainingLable.Location = new System.Drawing.Point(13, 45);
			this.bombsRemainingLable.Name = "bombsRemainingLable";
			this.bombsRemainingLable.Size = new System.Drawing.Size(142, 17);
			this.bombsRemainingLable.TabIndex = 1;
			this.bombsRemainingLable.Text = "Bombs Remaining:";
			// 
			// timeLable
			// 
			this.timeLable.AutoSize = true;
			this.timeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLable.Location = new System.Drawing.Point(236, 13);
			this.timeLable.Name = "timeLable";
			this.timeLable.Size = new System.Drawing.Size(48, 17);
			this.timeLable.TabIndex = 2;
			this.timeLable.Text = "Time:";
			// 
			// heightLable
			// 
			this.heightLable.AutoSize = true;
			this.heightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.heightLable.Location = new System.Drawing.Point(368, 13);
			this.heightLable.Name = "heightLable";
			this.heightLable.Size = new System.Drawing.Size(60, 17);
			this.heightLable.TabIndex = 3;
			this.heightLable.Text = "Height:";
			// 
			// widthLable
			// 
			this.widthLable.AutoSize = true;
			this.widthLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.widthLable.Location = new System.Drawing.Point(371, 45);
			this.widthLable.Name = "widthLable";
			this.widthLable.Size = new System.Drawing.Size(54, 17);
			this.widthLable.TabIndex = 4;
			this.widthLable.Text = "Width:";
			// 
			// difficultyLable
			// 
			this.difficultyLable.AutoSize = true;
			this.difficultyLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.difficultyLable.Location = new System.Drawing.Point(488, 13);
			this.difficultyLable.Name = "difficultyLable";
			this.difficultyLable.Size = new System.Drawing.Size(76, 17);
			this.difficultyLable.TabIndex = 5;
			this.difficultyLable.Text = "Difficulty:";
			// 
			// difficultySetting
			// 
			this.difficultySetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.difficultySetting.ForeColor = System.Drawing.SystemColors.WindowText;
			this.difficultySetting.FormattingEnabled = true;
			this.difficultySetting.Items.AddRange(new object[] {
            "Easy\t(10% mines)",
            "Medium\t(20% mines)",
            "Hard\t(30% mines)"});
			this.difficultySetting.Location = new System.Drawing.Point(571, 13);
			this.difficultySetting.Name = "difficultySetting";
			this.difficultySetting.Size = new System.Drawing.Size(121, 24);
			this.difficultySetting.TabIndex = 6;
			this.difficultySetting.Text = "Select difficulty";
			this.difficultySetting.UseWaitCursor = true;
			this.difficultySetting.SelectedIndexChanged += new System.EventHandler(this.difficultySetting_SelectedIndexChanged);
			// 
			// playButton
			// 
			this.playButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playButton.Location = new System.Drawing.Point(306, 80);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(173, 30);
			this.playButton.TabIndex = 7;
			this.playButton.Text = "Play";
			this.playButton.UseVisualStyleBackColor = false;
			// 
			// gridHeight
			// 
			this.gridHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridHeight.Location = new System.Drawing.Point(434, 14);
			this.gridHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.gridHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.gridHeight.Name = "gridHeight";
			this.gridHeight.Size = new System.Drawing.Size(53, 23);
			this.gridHeight.TabIndex = 8;
			this.gridHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// gridWidth
			// 
			this.gridWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridWidth.Location = new System.Drawing.Point(434, 45);
			this.gridWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.gridWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.gridWidth.Name = "gridWidth";
			this.gridWidth.Size = new System.Drawing.Size(53, 23);
			this.gridWidth.TabIndex = 9;
			this.gridWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gridWidth);
			this.Controls.Add(this.gridHeight);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.difficultySetting);
			this.Controls.Add(this.difficultyLable);
			this.Controls.Add(this.widthLable);
			this.Controls.Add(this.heightLable);
			this.Controls.Add(this.timeLable);
			this.Controls.Add(this.bombsRemainingLable);
			this.Controls.Add(this.scoreLable);
			this.Name = "Form1";
			this.Text = "MineSweeper";
			this.Load += new System.EventHandler(this.MineSweeper_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridWidth)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label scoreLable;
		private System.Windows.Forms.Label bombsRemainingLable;
		private System.Windows.Forms.Label timeLable;
		private System.Windows.Forms.Label heightLable;
		private System.Windows.Forms.Label widthLable;
		private System.Windows.Forms.Label difficultyLable;
		private System.Windows.Forms.ComboBox difficultySetting;
		private System.Windows.Forms.Button playButton;
		private System.Windows.Forms.NumericUpDown gridHeight;
		private System.Windows.Forms.NumericUpDown gridWidth;
	}
}

