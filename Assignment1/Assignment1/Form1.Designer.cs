namespace Assignment1
{
    partial class form1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldeparmnet = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lblinformation = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.textdepartment = new System.Windows.Forms.TextBox();
            this.textstudentid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textsemester = new System.Windows.Forms.TextBox();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(66, 110);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(309, 48);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter the student name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblstudentid
            // 
            this.lblstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(66, 165);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(309, 48);
            this.lblstudentid.TabIndex = 1;
            this.lblstudentid.Text = "Enter the student ID";
            this.lblstudentid.Click += new System.EventHandler(this.lblstudentid_Click);
            // 
            // lbldeparmnet
            // 
            this.lbldeparmnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeparmnet.Location = new System.Drawing.Point(66, 226);
            this.lbldeparmnet.Name = "lbldeparmnet";
            this.lbldeparmnet.Size = new System.Drawing.Size(309, 48);
            this.lbldeparmnet.TabIndex = 2;
            this.lbldeparmnet.Text = "Enter the department";
            this.lbldeparmnet.Click += new System.EventHandler(this.lbldeparmnet_Click);
            // 
            // lblsemester
            // 
            this.lblsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(66, 286);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(309, 48);
            this.lblsemester.TabIndex = 3;
            this.lblsemester.Text = "Enter the semester";
            this.lblsemester.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblinformation
            // 
            this.lblinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformation.ForeColor = System.Drawing.Color.Navy;
            this.lblinformation.Location = new System.Drawing.Point(296, 31);
            this.lblinformation.Name = "lblinformation";
            this.lblinformation.Size = new System.Drawing.Size(341, 48);
            this.lblinformation.TabIndex = 4;
            this.lblinformation.Text = "Student Information";
            this.lblinformation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(84, 364);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(752, 82);
            this.lbloutput.TabIndex = 5;
            // 
            // textdepartment
            // 
            this.textdepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textdepartment.Location = new System.Drawing.Point(405, 226);
            this.textdepartment.Name = "textdepartment";
            this.textdepartment.Size = new System.Drawing.Size(465, 26);
            this.textdepartment.TabIndex = 6;
            // 
            // textstudentid
            // 
            this.textstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textstudentid.Location = new System.Drawing.Point(405, 165);
            this.textstudentid.Name = "textstudentid";
            this.textstudentid.Size = new System.Drawing.Size(465, 26);
            this.textstudentid.TabIndex = 7;
            this.textstudentid.TextChanged += new System.EventHandler(this.textstudentid_TextChanged);
            // 
            // textname
            // 
            this.textname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textname.Location = new System.Drawing.Point(405, 110);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(465, 26);
            this.textname.TabIndex = 8;
            this.textname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textsemester
            // 
            this.textsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textsemester.Location = new System.Drawing.Point(405, 286);
            this.textsemester.Name = "textsemester";
            this.textsemester.Size = new System.Drawing.Size(465, 26);
            this.textsemester.TabIndex = 9;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowinfo.Location = new System.Drawing.Point(153, 481);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(170, 50);
            this.btnshowinfo.TabIndex = 10;
            this.btnshowinfo.Text = "Show information";
            this.btnshowinfo.UseVisualStyleBackColor = false;
            this.btnshowinfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(371, 481);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(170, 50);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(603, 481);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(170, 50);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 559);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.textsemester);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textstudentid);
            this.Controls.Add(this.textdepartment);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblinformation);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldeparmnet);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Name = "form1";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldeparmnet;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lblinformation;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox textdepartment;
        private System.Windows.Forms.TextBox textstudentid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textsemester;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

