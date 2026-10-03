namespace Range_Checker
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
            this.btncheck = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Label();
            this.textrange = new System.Windows.Forms.TextBox();
            this.lblsubtitle = new System.Windows.Forms.Label();
            this.lbldecsion = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(135, 363);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(134, 75);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "&Check Qualification";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.Location = new System.Drawing.Point(39, 29);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(301, 26);
            this.v.TabIndex = 5;
            this.v.Text = "Range Checker Application";
            // 
            // textrange
            // 
            this.textrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textrange.Location = new System.Drawing.Point(206, 149);
            this.textrange.Name = "textrange";
            this.textrange.Size = new System.Drawing.Size(340, 26);
            this.textrange.TabIndex = 0;
            // 
            // lblsubtitle
            // 
            this.lblsubtitle.AutoSize = true;
            this.lblsubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitle.Location = new System.Drawing.Point(35, 92);
            this.lblsubtitle.Name = "lblsubtitle";
            this.lblsubtitle.Size = new System.Drawing.Size(482, 26);
            this.lblsubtitle.TabIndex = 6;
            this.lblsubtitle.Text = "Enter an integer in the range of 1 through 10";
            // 
            // lbldecsion
            // 
            this.lbldecsion.AutoSize = true;
            this.lbldecsion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldecsion.Location = new System.Drawing.Point(262, 201);
            this.lbldecsion.Name = "lbldecsion";
            this.lbldecsion.Size = new System.Drawing.Size(180, 26);
            this.lbldecsion.TabIndex = 4;
            this.lbldecsion.Text = "Range Decision";
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(104, 262);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(588, 55);
            this.lblresult.TabIndex = 1;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(312, 363);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(113, 75);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(470, 363);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(113, 75);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbldecsion);
            this.Controls.Add(this.lblsubtitle);
            this.Controls.Add(this.textrange);
            this.Controls.Add(this.v);
            this.Controls.Add(this.btncheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.TextBox textrange;
        private System.Windows.Forms.Label lblsubtitle;
        private System.Windows.Forms.Label lbldecsion;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

