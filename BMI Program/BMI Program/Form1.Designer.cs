namespace BMI_Program
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
            this.btncalcualte = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.ListBox();
            this.textweight = new System.Windows.Forms.TextBox();
            this.grpinfo = new System.Windows.Forms.GroupBox();
            this.textheight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.grpinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalcualte
            // 
            this.btncalcualte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcualte.Location = new System.Drawing.Point(112, 405);
            this.btncalcualte.Name = "btncalcualte";
            this.btncalcualte.Size = new System.Drawing.Size(129, 48);
            this.btncalcualte.TabIndex = 2;
            this.btncalcualte.Text = "Ca&lculate";
            this.btncalcualte.UseVisualStyleBackColor = true;
            this.btncalcualte.Click += new System.EventHandler(this.btncalcualte_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.DarkBlue;
            this.lbltitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(371, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(416, 55);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "BMI Program ";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 20;
            this.Result.Location = new System.Drawing.Point(701, 97);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(311, 304);
            this.Result.TabIndex = 5;
            // 
            // textweight
            // 
            this.textweight.Location = new System.Drawing.Point(306, 45);
            this.textweight.Name = "textweight";
            this.textweight.Size = new System.Drawing.Size(226, 26);
            this.textweight.TabIndex = 0;
            // 
            // grpinfo
            // 
            this.grpinfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpinfo.Controls.Add(this.textheight);
            this.grpinfo.Controls.Add(this.label1);
            this.grpinfo.Controls.Add(this.textweight);
            this.grpinfo.Controls.Add(this.lblweight);
            this.grpinfo.Location = new System.Drawing.Point(12, 82);
            this.grpinfo.Name = "grpinfo";
            this.grpinfo.Size = new System.Drawing.Size(626, 177);
            this.grpinfo.TabIndex = 1;
            this.grpinfo.TabStop = false;
            this.grpinfo.Text = "Personal Information";
            // 
            // textheight
            // 
            this.textheight.Location = new System.Drawing.Point(306, 103);
            this.textheight.Name = "textheight";
            this.textheight.Size = new System.Drawing.Size(226, 26);
            this.textheight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Height(M):";
            // 
            // lblweight
            // 
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(6, 44);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(230, 31);
            this.lblweight.TabIndex = 2;
            this.lblweight.Text = "Enter  The Weight(kg) : ";
            this.lblweight.Click += new System.EventHandler(this.lblweight_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(524, 405);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(129, 48);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(318, 405);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(129, 48);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 576);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grpinfo);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btncalcualte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpinfo.ResumeLayout(false);
            this.grpinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncalcualte;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.TextBox textweight;
        private System.Windows.Forms.GroupBox grpinfo;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textheight;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
    }
}

