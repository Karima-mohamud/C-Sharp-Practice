namespace Test_Score_Average
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
            this.lblscore1 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.textScore1 = new System.Windows.Forms.TextBox();
            this.lblscore3 = new System.Windows.Forms.Label();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.textScore3 = new System.Windows.Forms.TextBox();
            this.textscore2 = new System.Windows.Forms.TextBox();
            this.groupBoxtests = new System.Windows.Forms.GroupBox();
            this.lblaverage = new System.Windows.Forms.Label();
            this.lblaverageshow = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBoxtests.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblscore1
            // 
            this.lblscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore1.Location = new System.Drawing.Point(20, 43);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(202, 32);
            this.lblscore1.TabIndex = 0;
            this.lblscore1.Text = "Test Score #1";
            this.lblscore1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Silver;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(121, 372);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(128, 78);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Ca&lculate Average ";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // textScore1
            // 
            this.textScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textScore1.Location = new System.Drawing.Point(284, 45);
            this.textScore1.Name = "textScore1";
            this.textScore1.Size = new System.Drawing.Size(245, 26);
            this.textScore1.TabIndex = 0;
            // 
            // lblscore3
            // 
            this.lblscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore3.Location = new System.Drawing.Point(20, 172);
            this.lblscore3.Name = "lblscore3";
            this.lblscore3.Size = new System.Drawing.Size(202, 32);
            this.lblscore3.TabIndex = 3;
            this.lblscore3.Text = "Test Score #3";
            // 
            // lblscore2
            // 
            this.lblscore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore2.Location = new System.Drawing.Point(20, 106);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(202, 32);
            this.lblscore2.TabIndex = 4;
            this.lblscore2.Text = "Test Score #2";
            // 
            // textScore3
            // 
            this.textScore3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textScore3.Location = new System.Drawing.Point(284, 174);
            this.textScore3.Name = "textScore3";
            this.textScore3.Size = new System.Drawing.Size(245, 26);
            this.textScore3.TabIndex = 2;
            // 
            // textscore2
            // 
            this.textscore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textscore2.Location = new System.Drawing.Point(284, 108);
            this.textscore2.Name = "textscore2";
            this.textscore2.Size = new System.Drawing.Size(245, 26);
            this.textscore2.TabIndex = 1;
            // 
            // groupBoxtests
            // 
            this.groupBoxtests.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxtests.Controls.Add(this.lblaverageshow);
            this.groupBoxtests.Controls.Add(this.lblaverage);
            this.groupBoxtests.Controls.Add(this.lblscore2);
            this.groupBoxtests.Controls.Add(this.textscore2);
            this.groupBoxtests.Controls.Add(this.lblscore1);
            this.groupBoxtests.Controls.Add(this.textScore3);
            this.groupBoxtests.Controls.Add(this.textScore1);
            this.groupBoxtests.Controls.Add(this.lblscore3);
            this.groupBoxtests.Location = new System.Drawing.Point(27, 25);
            this.groupBoxtests.Name = "groupBoxtests";
            this.groupBoxtests.Size = new System.Drawing.Size(621, 301);
            this.groupBoxtests.TabIndex = 1;
            this.groupBoxtests.TabStop = false;
            this.groupBoxtests.Text = "Enter Three Test Scores";
            // 
            // lblaverage
            // 
            this.lblaverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverage.Location = new System.Drawing.Point(279, 225);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(250, 32);
            this.lblaverage.TabIndex = 3;
            // 
            // lblaverageshow
            // 
            this.lblaverageshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverageshow.Location = new System.Drawing.Point(71, 225);
            this.lblaverageshow.Name = "lblaverageshow";
            this.lblaverageshow.Size = new System.Drawing.Size(202, 32);
            this.lblaverageshow.TabIndex = 8;
            this.lblaverageshow.Text = "Average";
            this.lblaverageshow.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Silver;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(311, 368);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(128, 47);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Silver;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(311, 421);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(128, 42);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "&Exit ";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 525);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.groupBoxtests);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxtests.ResumeLayout(false);
            this.groupBoxtests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox textScore1;
        private System.Windows.Forms.Label lblscore3;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.TextBox textScore3;
        private System.Windows.Forms.TextBox textscore2;
        private System.Windows.Forms.GroupBox groupBoxtests;
        private System.Windows.Forms.Label lblaverageshow;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

