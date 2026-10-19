namespace Vehicle_Rental_Management_System
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.groupVehicletype = new System.Windows.Forms.GroupBox();
            this.rdoeconomy = new System.Windows.Forms.RadioButton();
            this.rdosuv = new System.Windows.Forms.RadioButton();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.froupinsurance = new System.Windows.Forms.GroupBox();
            this.groupcustomer = new System.Windows.Forms.GroupBox();
            this.textage = new System.Windows.Forms.TextBox();
            this.textrentaldays = new System.Windows.Forms.TextBox();
            this.textexperience = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.lblrentaldays = new System.Windows.Forms.Label();
            this.lblyears = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.listResults = new System.Windows.Forms.ListBox();
            this.grpresult = new System.Windows.Forms.GroupBox();
            this.groupVehicletype.SuspendLayout();
            this.froupinsurance.SuspendLayout();
            this.groupcustomer.SuspendLayout();
            this.grpresult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculate.Location = new System.Drawing.Point(249, 643);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(129, 59);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(673, 643);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 59);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Location = new System.Drawing.Point(452, 643);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(129, 59);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Navy;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(243, 8);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(982, 59);
            this.lbltitle.TabIndex = 28;
            this.lbltitle.Text = "Vehicle Rental Management System\r\n\r\n";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupVehicletype
            // 
            this.groupVehicletype.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupVehicletype.Controls.Add(this.rdoluxury);
            this.groupVehicletype.Controls.Add(this.rdosuv);
            this.groupVehicletype.Controls.Add(this.rdoeconomy);
            this.groupVehicletype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupVehicletype.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupVehicletype.Location = new System.Drawing.Point(17, 368);
            this.groupVehicletype.Name = "groupVehicletype";
            this.groupVehicletype.Size = new System.Drawing.Size(564, 138);
            this.groupVehicletype.TabIndex = 29;
            this.groupVehicletype.TabStop = false;
            this.groupVehicletype.Text = "Vehicle Type";
            // 
            // rdoeconomy
            // 
            this.rdoeconomy.AutoSize = true;
            this.rdoeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoeconomy.ForeColor = System.Drawing.Color.Black;
            this.rdoeconomy.Location = new System.Drawing.Point(13, 78);
            this.rdoeconomy.Name = "rdoeconomy";
            this.rdoeconomy.Size = new System.Drawing.Size(126, 29);
            this.rdoeconomy.TabIndex = 0;
            this.rdoeconomy.TabStop = true;
            this.rdoeconomy.Text = "Economy";
            this.rdoeconomy.UseVisualStyleBackColor = true;
            // 
            // rdosuv
            // 
            this.rdosuv.AutoSize = true;
            this.rdosuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdosuv.ForeColor = System.Drawing.Color.Black;
            this.rdosuv.Location = new System.Drawing.Point(200, 78);
            this.rdosuv.Name = "rdosuv";
            this.rdosuv.Size = new System.Drawing.Size(82, 29);
            this.rdosuv.TabIndex = 1;
            this.rdosuv.TabStop = true;
            this.rdosuv.Text = "SUV";
            this.rdosuv.UseVisualStyleBackColor = true;
            this.rdosuv.CheckedChanged += new System.EventHandler(this.rdosuv_CheckedChanged);
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoluxury.ForeColor = System.Drawing.Color.Black;
            this.rdoluxury.Location = new System.Drawing.Point(351, 78);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(102, 29);
            this.rdoluxury.TabIndex = 2;
            this.rdoluxury.TabStop = true;
            this.rdoluxury.Text = "Luxury";
            this.rdoluxury.UseVisualStyleBackColor = true;
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.ForeColor = System.Drawing.Color.Black;
            this.chkinsurance.Location = new System.Drawing.Point(13, 42);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(332, 30);
            this.chkinsurance.TabIndex = 30;
            this.chkinsurance.Text = "Add Insurance($15 per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // froupinsurance
            // 
            this.froupinsurance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.froupinsurance.Controls.Add(this.chkinsurance);
            this.froupinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.froupinsurance.ForeColor = System.Drawing.Color.DarkBlue;
            this.froupinsurance.Location = new System.Drawing.Point(20, 517);
            this.froupinsurance.Name = "froupinsurance";
            this.froupinsurance.Size = new System.Drawing.Size(564, 83);
            this.froupinsurance.TabIndex = 30;
            this.froupinsurance.TabStop = false;
            this.froupinsurance.Text = "Insurance Option";
            // 
            // groupcustomer
            // 
            this.groupcustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupcustomer.Controls.Add(this.textage);
            this.groupcustomer.Controls.Add(this.textrentaldays);
            this.groupcustomer.Controls.Add(this.textexperience);
            this.groupcustomer.Controls.Add(this.lblage);
            this.groupcustomer.Controls.Add(this.lblrentaldays);
            this.groupcustomer.Controls.Add(this.lblyears);
            this.groupcustomer.Controls.Add(this.textname);
            this.groupcustomer.Controls.Add(this.lblname);
            this.groupcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupcustomer.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupcustomer.Location = new System.Drawing.Point(12, 82);
            this.groupcustomer.Name = "groupcustomer";
            this.groupcustomer.Size = new System.Drawing.Size(760, 269);
            this.groupcustomer.TabIndex = 31;
            this.groupcustomer.TabStop = false;
            this.groupcustomer.Text = "Customer Information";
            // 
            // textage
            // 
            this.textage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textage.Location = new System.Drawing.Point(337, 94);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(356, 32);
            this.textage.TabIndex = 20;
            // 
            // textrentaldays
            // 
            this.textrentaldays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textrentaldays.Location = new System.Drawing.Point(337, 151);
            this.textrentaldays.Name = "textrentaldays";
            this.textrentaldays.Size = new System.Drawing.Size(356, 32);
            this.textrentaldays.TabIndex = 19;
            // 
            // textexperience
            // 
            this.textexperience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textexperience.Location = new System.Drawing.Point(337, 210);
            this.textexperience.Name = "textexperience";
            this.textexperience.Size = new System.Drawing.Size(356, 32);
            this.textexperience.TabIndex = 18;
            // 
            // lblage
            // 
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.Color.Black;
            this.lblage.Location = new System.Drawing.Point(30, 107);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(222, 38);
            this.lblage.TabIndex = 17;
            this.lblage.Text = "Enter Customer Age :\r\n:";
            // 
            // lblrentaldays
            // 
            this.lblrentaldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrentaldays.ForeColor = System.Drawing.Color.Black;
            this.lblrentaldays.Location = new System.Drawing.Point(30, 164);
            this.lblrentaldays.Name = "lblrentaldays";
            this.lblrentaldays.Size = new System.Drawing.Size(263, 34);
            this.lblrentaldays.TabIndex = 16;
            this.lblrentaldays.Text = "Enter Number Of Rental Days:";
            // 
            // lblyears
            // 
            this.lblyears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyears.ForeColor = System.Drawing.Color.Black;
            this.lblyears.Location = new System.Drawing.Point(30, 223);
            this.lblyears.Name = "lblyears";
            this.lblyears.Size = new System.Drawing.Size(298, 33);
            this.lblyears.TabIndex = 15;
            this.lblyears.Text = "Enter Years of Driving Experiance:";
            // 
            // textname
            // 
            this.textname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textname.Location = new System.Drawing.Point(337, 46);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(356, 32);
            this.textname.TabIndex = 14;
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(30, 46);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(222, 38);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "Enter Customer Name:";
            // 
            // listResults
            // 
            this.listResults.FormattingEnabled = true;
            this.listResults.HorizontalScrollbar = true;
            this.listResults.ItemHeight = 26;
            this.listResults.Location = new System.Drawing.Point(22, 30);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(486, 550);
            this.listResults.TabIndex = 32;
            // 
            // grpresult
            // 
            this.grpresult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpresult.Controls.Add(this.listResults);
            this.grpresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpresult.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpresult.Location = new System.Drawing.Point(975, 82);
            this.grpresult.Name = "grpresult";
            this.grpresult.Size = new System.Drawing.Size(528, 600);
            this.grpresult.TabIndex = 33;
            this.grpresult.TabStop = false;
            this.grpresult.Text = "Rental Information And Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 714);
            this.Controls.Add(this.grpresult);
            this.Controls.Add(this.groupcustomer);
            this.Controls.Add(this.froupinsurance);
            this.Controls.Add(this.groupVehicletype);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Vehicle Rental Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupVehicletype.ResumeLayout(false);
            this.groupVehicletype.PerformLayout();
            this.froupinsurance.ResumeLayout(false);
            this.froupinsurance.PerformLayout();
            this.groupcustomer.ResumeLayout(false);
            this.groupcustomer.PerformLayout();
            this.grpresult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox groupVehicletype;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.RadioButton rdosuv;
        private System.Windows.Forms.RadioButton rdoeconomy;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.GroupBox froupinsurance;
        private System.Windows.Forms.GroupBox groupcustomer;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.TextBox textrentaldays;
        private System.Windows.Forms.TextBox textexperience;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblrentaldays;
        private System.Windows.Forms.Label lblyears;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.GroupBox grpresult;
    }
}

