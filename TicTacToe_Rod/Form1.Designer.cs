namespace TicTacToe_Rod
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.row1column1 = new System.Windows.Forms.Button();
            this.row1column2 = new System.Windows.Forms.Button();
            this.row1column3 = new System.Windows.Forms.Button();
            this.row2column1 = new System.Windows.Forms.Button();
            this.row2column2 = new System.Windows.Forms.Button();
            this.row2column3 = new System.Windows.Forms.Button();
            this.row3column1 = new System.Windows.Forms.Button();
            this.row3column2 = new System.Windows.Forms.Button();
            this.row3column3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // row1column1
            // 
            this.row1column1.Location = new System.Drawing.Point(119, 128);
            this.row1column1.Name = "row1column1";
            this.row1column1.Size = new System.Drawing.Size(110, 110);
            this.row1column1.TabIndex = 0;
            this.row1column1.UseVisualStyleBackColor = true;
            // 
            // row1column2
            // 
            this.row1column2.Location = new System.Drawing.Point(263, 128);
            this.row1column2.Name = "row1column2";
            this.row1column2.Size = new System.Drawing.Size(110, 110);
            this.row1column2.TabIndex = 1;
            this.row1column2.UseVisualStyleBackColor = true;
            // 
            // row1column3
            // 
            this.row1column3.Location = new System.Drawing.Point(408, 128);
            this.row1column3.Name = "row1column3";
            this.row1column3.Size = new System.Drawing.Size(110, 110);
            this.row1column3.TabIndex = 2;
            this.row1column3.UseVisualStyleBackColor = true;
            // 
            // row2column1
            // 
            this.row2column1.Location = new System.Drawing.Point(119, 266);
            this.row2column1.Name = "row2column1";
            this.row2column1.Size = new System.Drawing.Size(110, 110);
            this.row2column1.TabIndex = 3;
            this.row2column1.UseVisualStyleBackColor = true;
            // 
            // row2column2
            // 
            this.row2column2.Location = new System.Drawing.Point(263, 266);
            this.row2column2.Name = "row2column2";
            this.row2column2.Size = new System.Drawing.Size(110, 110);
            this.row2column2.TabIndex = 4;
            this.row2column2.UseVisualStyleBackColor = true;
            // 
            // row2column3
            // 
            this.row2column3.Location = new System.Drawing.Point(408, 266);
            this.row2column3.Name = "row2column3";
            this.row2column3.Size = new System.Drawing.Size(110, 110);
            this.row2column3.TabIndex = 5;
            this.row2column3.UseVisualStyleBackColor = true;
            // 
            // row3column1
            // 
            this.row3column1.Location = new System.Drawing.Point(119, 413);
            this.row3column1.Name = "row3column1";
            this.row3column1.Size = new System.Drawing.Size(110, 110);
            this.row3column1.TabIndex = 6;
            this.row3column1.UseVisualStyleBackColor = true;
            // 
            // row3column2
            // 
            this.row3column2.Location = new System.Drawing.Point(263, 413);
            this.row3column2.Name = "row3column2";
            this.row3column2.Size = new System.Drawing.Size(110, 110);
            this.row3column2.TabIndex = 7;
            this.row3column2.UseVisualStyleBackColor = true;
            // 
            // row3column3
            // 
            this.row3column3.Location = new System.Drawing.Point(408, 413);
            this.row3column3.Name = "row3column3";
            this.row3column3.Size = new System.Drawing.Size(110, 110);
            this.row3column3.TabIndex = 8;
            this.row3column3.UseVisualStyleBackColor = true;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(656, 596);
            this.Controls.Add(this.row3column3);
            this.Controls.Add(this.row3column2);
            this.Controls.Add(this.row3column1);
            this.Controls.Add(this.row2column3);
            this.Controls.Add(this.row2column2);
            this.Controls.Add(this.row2column1);
            this.Controls.Add(this.row1column3);
            this.Controls.Add(this.row1column2);
            this.Controls.Add(this.row1column1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button row1column1;
        private Button row1column2;
        private Button row1column3;
        private Button row2column1;
        private Button row2column2;
        private Button row2column3;
        private Button row3column1;
        private Button row3column2;
        private Button row3column3;
    }
}