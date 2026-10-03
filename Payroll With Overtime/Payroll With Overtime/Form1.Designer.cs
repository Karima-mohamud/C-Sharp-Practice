namespace Payroll_With_Overtime
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
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblhours = new System.Windows.Forms.Label();
            this.texthoursworked = new System.Windows.Forms.TextBox();
            this.lblgross = new System.Windows.Forms.Label();
            this.lblrate = new System.Windows.Forms.Label();
            this.texthourpayrate = new System.Windows.Forms.TextBox();
            this.lblgrosspay = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Silver;
            this.btncalculate.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(150, 341);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(113, 49);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "Ca&lculate gross pay";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhours
            // 
            this.lblhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhours.Location = new System.Drawing.Point(120, 65);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(236, 51);
            this.lblhours.TabIndex = 3;
            this.lblhours.Text = "Hours Worked:";
            // 
            // texthoursworked
            // 
            this.texthoursworked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texthoursworked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texthoursworked.Location = new System.Drawing.Point(400, 66);
            this.texthoursworked.Name = "texthoursworked";
            this.texthoursworked.Size = new System.Drawing.Size(289, 28);
            this.texthoursworked.TabIndex = 0;
            // 
            // lblgross
            // 
            this.lblgross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgross.Location = new System.Drawing.Point(120, 205);
            this.lblgross.Name = "lblgross";
            this.lblgross.Size = new System.Drawing.Size(236, 51);
            this.lblgross.TabIndex = 5;
            this.lblgross.Text = "Gross Pay :";
            // 
            // lblrate
            // 
            this.lblrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrate.Location = new System.Drawing.Point(120, 136);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(236, 51);
            this.lblrate.TabIndex = 4;
            this.lblrate.Text = "Hourly Pay Rate:";
            // 
            // texthourpayrate
            // 
            this.texthourpayrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texthourpayrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texthourpayrate.Location = new System.Drawing.Point(400, 137);
            this.texthourpayrate.Name = "texthourpayrate";
            this.texthourpayrate.Size = new System.Drawing.Size(289, 28);
            this.texthourpayrate.TabIndex = 1;
            // 
            // lblgrosspay
            // 
            this.lblgrosspay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrosspay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosspay.Location = new System.Drawing.Point(404, 193);
            this.lblgrosspay.Name = "lblgrosspay";
            this.lblgrosspay.Size = new System.Drawing.Size(285, 41);
            this.lblgrosspay.TabIndex = 2;
            this.lblgrosspay.Click += new System.EventHandler(this.lblgrosspay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(536, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Silver;
            this.btnclear.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(319, 341);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(113, 49);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblgrosspay);
            this.Controls.Add(this.texthourpayrate);
            this.Controls.Add(this.lblrate);
            this.Controls.Add(this.lblgross);
            this.Controls.Add(this.texthoursworked);
            this.Controls.Add(this.lblhours);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "Payroll With Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.TextBox texthoursworked;
        private System.Windows.Forms.Label lblgross;
        private System.Windows.Forms.Label lblrate;
        private System.Windows.Forms.TextBox texthourpayrate;
        private System.Windows.Forms.Label lblgrosspay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnclear;
    }
}

