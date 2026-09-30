namespace HotelBooking
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
            this.textcustomer = new System.Windows.Forms.TextBox();
            this.textnight = new System.Windows.Forms.TextBox();
            this.textroom = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbldiscountshow = new System.Windows.Forms.Label();
            this.lbltaxshow = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Transparent;
            this.btncalculate.Location = new System.Drawing.Point(200, 282);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(155, 54);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // textcustomer
            // 
            this.textcustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcustomer.Location = new System.Drawing.Point(456, 71);
            this.textcustomer.Name = "textcustomer";
            this.textcustomer.Size = new System.Drawing.Size(433, 30);
            this.textcustomer.TabIndex = 2;
            // 
            // textnight
            // 
            this.textnight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnight.Location = new System.Drawing.Point(456, 169);
            this.textnight.Name = "textnight";
            this.textnight.Size = new System.Drawing.Size(433, 30);
            this.textnight.TabIndex = 3;
            // 
            // textroom
            // 
            this.textroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textroom.Location = new System.Drawing.Point(456, 120);
            this.textroom.Name = "textroom";
            this.textroom.Size = new System.Drawing.Size(433, 30);
            this.textroom.TabIndex = 4;
            // 
            // textprice
            // 
            this.textprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprice.Location = new System.Drawing.Point(456, 218);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(433, 30);
            this.textprice.TabIndex = 5;
            this.textprice.TextChanged += new System.EventHandler(this.textprice_TextChanged);
            // 
            // lblcustomer
            // 
            this.lblcustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer.Location = new System.Drawing.Point(79, 71);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(263, 49);
            this.lblcustomer.TabIndex = 0;
            this.lblcustomer.Text = "Enter Guest Name  :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter number of Nights  :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Room Type :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Price Per Night  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(252, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(485, 48);
            this.lbltitle.TabIndex = 9;
            this.lbltitle.Text = "Hotel Room Booking Calculater";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.Location = new System.Drawing.Point(412, 282);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(155, 54);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.Location = new System.Drawing.Point(601, 282);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(155, 54);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbldiscountshow
            // 
            this.lbldiscountshow.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscountshow.Location = new System.Drawing.Point(110, 415);
            this.lbldiscountshow.Name = "lbldiscountshow";
            this.lbldiscountshow.Size = new System.Drawing.Size(263, 49);
            this.lbldiscountshow.TabIndex = 12;
            this.lbldiscountshow.Text = "Discount(5%)  :";
            this.lbldiscountshow.Click += new System.EventHandler(this.lbldiscountshow_Click);
            // 
            // lbltaxshow
            // 
            this.lbltaxshow.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaxshow.Location = new System.Drawing.Point(110, 366);
            this.lbltaxshow.Name = "lbltaxshow";
            this.lbltaxshow.Size = new System.Drawing.Size(263, 49);
            this.lbltaxshow.TabIndex = 13;
            this.lbltaxshow.Text = "Service Tax(10%)  :";
            this.lbltaxshow.Click += new System.EventHandler(this.lbltaxshow_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(110, 464);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(263, 49);
            this.lbltotal.TabIndex = 14;
            this.lbltotal.Text = "Total Amount  :";
            // 
            // lbltax
            // 
            this.lbltax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltax.Location = new System.Drawing.Point(392, 366);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(386, 44);
            this.lbltax.TabIndex = 15;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotalamount.Location = new System.Drawing.Point(392, 474);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(386, 44);
            this.lbltotalamount.TabIndex = 16;
            // 
            // lbldiscount
            // 
            this.lbldiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldiscount.Location = new System.Drawing.Point(392, 420);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(386, 44);
            this.lbldiscount.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 527);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbltaxshow);
            this.Controls.Add(this.lbldiscountshow);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textroom);
            this.Controls.Add(this.textnight);
            this.Controls.Add(this.textcustomer);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblcustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox textcustomer;
        private System.Windows.Forms.TextBox textnight;
        private System.Windows.Forms.TextBox textroom;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbldiscountshow;
        private System.Windows.Forms.Label lbltaxshow;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lbldiscount;
    }
}

