namespace FoodCharge
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
            this.lblfood1 = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.textfood1 = new System.Windows.Forms.TextBox();
            this.textfood2 = new System.Windows.Forms.TextBox();
            this.textprice1 = new System.Windows.Forms.TextBox();
            this.textprice2 = new System.Windows.Forms.TextBox();
            this.lblprice2 = new System.Windows.Forms.Label();
            this.lblfood2 = new System.Windows.Forms.Label();
            this.lblprice1 = new System.Windows.Forms.Label();
            this.lblsalestax = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltaxsshow = new System.Windows.Forms.Label();
            this.lbltotalshow = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfood1
            // 
            this.lblfood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood1.Location = new System.Drawing.Point(87, 72);
            this.lblfood1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(270, 43);
            this.lblfood1.TabIndex = 0;
            this.lblfood1.Text = "Enter  meal one:";
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(152, 304);
            this.btnshow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(239, 67);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "Calculate";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // textfood1
            // 
            this.textfood1.Location = new System.Drawing.Point(598, 59);
            this.textfood1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textfood1.Name = "textfood1";
            this.textfood1.Size = new System.Drawing.Size(273, 30);
            this.textfood1.TabIndex = 2;
            // 
            // textfood2
            // 
            this.textfood2.Location = new System.Drawing.Point(598, 188);
            this.textfood2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textfood2.Name = "textfood2";
            this.textfood2.Size = new System.Drawing.Size(273, 30);
            this.textfood2.TabIndex = 3;
            // 
            // textprice1
            // 
            this.textprice1.Location = new System.Drawing.Point(598, 126);
            this.textprice1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textprice1.Name = "textprice1";
            this.textprice1.Size = new System.Drawing.Size(273, 30);
            this.textprice1.TabIndex = 4;
            // 
            // textprice2
            // 
            this.textprice2.Location = new System.Drawing.Point(598, 257);
            this.textprice2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textprice2.Name = "textprice2";
            this.textprice2.Size = new System.Drawing.Size(273, 30);
            this.textprice2.TabIndex = 5;
            // 
            // lblprice2
            // 
            this.lblprice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice2.Location = new System.Drawing.Point(87, 257);
            this.lblprice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice2.Name = "lblprice2";
            this.lblprice2.Size = new System.Drawing.Size(341, 43);
            this.lblprice2.TabIndex = 6;
            this.lblprice2.Text = "Enter the price for meal two:\r\n";
            // 
            // lblfood2
            // 
            this.lblfood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood2.Location = new System.Drawing.Point(87, 188);
            this.lblfood2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfood2.Name = "lblfood2";
            this.lblfood2.Size = new System.Drawing.Size(270, 43);
            this.lblfood2.TabIndex = 7;
            this.lblfood2.Text = "Enter  meal two:";
            // 
            // lblprice1
            // 
            this.lblprice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice1.Location = new System.Drawing.Point(87, 126);
            this.lblprice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice1.Name = "lblprice1";
            this.lblprice1.Size = new System.Drawing.Size(351, 43);
            this.lblprice1.TabIndex = 8;
            this.lblprice1.Text = "Enter  the price for meal one:";
            // 
            // lblsalestax
            // 
            this.lblsalestax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsalestax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestax.Location = new System.Drawing.Point(438, 394);
            this.lblsalestax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsalestax.Name = "lblsalestax";
            this.lblsalestax.Size = new System.Drawing.Size(459, 57);
            this.lblsalestax.TabIndex = 9;
            // 
            // lbltotal
            // 
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(438, 478);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(459, 57);
            this.lbltotal.TabIndex = 10;
            // 
            // lbltaxsshow
            // 
            this.lbltaxsshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaxsshow.Location = new System.Drawing.Point(147, 413);
            this.lbltaxsshow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltaxsshow.Name = "lbltaxsshow";
            this.lbltaxsshow.Size = new System.Drawing.Size(237, 38);
            this.lbltaxsshow.TabIndex = 11;
            this.lbltaxsshow.Text = "Sales Tax :";
            // 
            // lbltotalshow
            // 
            this.lbltotalshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalshow.Location = new System.Drawing.Point(147, 497);
            this.lbltotalshow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalshow.Name = "lbltotalshow";
            this.lbltotalshow.Size = new System.Drawing.Size(237, 38);
            this.lbltotalshow.TabIndex = 12;
            this.lbltotalshow.Text = "The total is:";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(436, 304);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(239, 67);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(713, 295);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(239, 67);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbltotalshow);
            this.Controls.Add(this.lbltaxsshow);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblsalestax);
            this.Controls.Add(this.lblprice1);
            this.Controls.Add(this.lblfood2);
            this.Controls.Add(this.lblprice2);
            this.Controls.Add(this.textprice2);
            this.Controls.Add(this.textprice1);
            this.Controls.Add(this.textfood2);
            this.Controls.Add(this.textfood1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lblfood1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Food Charge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.TextBox textfood1;
        private System.Windows.Forms.TextBox textfood2;
        private System.Windows.Forms.TextBox textprice1;
        private System.Windows.Forms.TextBox textprice2;
        private System.Windows.Forms.Label lblprice2;
        private System.Windows.Forms.Label lblfood2;
        private System.Windows.Forms.Label lblprice1;
        private System.Windows.Forms.Label lblsalestax;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltaxsshow;
        private System.Windows.Forms.Label lbltotalshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

