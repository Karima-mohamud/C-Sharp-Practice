namespace Student_Course_Registration_System
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
            this.grpinformation = new System.Windows.Forms.GroupBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textage = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.grpcourse = new System.Windows.Forms.GroupBox();
            this.lblcoursename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textcoursename = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.Regitrated_Courses = new System.Windows.Forms.ListBox();
            this.Registration_Result = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textnumcourses = new System.Windows.Forms.TextBox();
            this.grpinformation.SuspendLayout();
            this.grpcourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpinformation
            // 
            this.grpinformation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpinformation.Controls.Add(this.textID);
            this.grpinformation.Controls.Add(this.textage);
            this.grpinformation.Controls.Add(this.lblid);
            this.grpinformation.Controls.Add(this.textname);
            this.grpinformation.Controls.Add(this.lblage);
            this.grpinformation.Controls.Add(this.lblname);
            this.grpinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpinformation.Location = new System.Drawing.Point(30, 50);
            this.grpinformation.Name = "grpinformation";
            this.grpinformation.Size = new System.Drawing.Size(567, 224);
            this.grpinformation.TabIndex = 0;
            this.grpinformation.TabStop = false;
            this.grpinformation.Text = "Student Information";
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbltitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(346, 2);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(883, 54);
            this.lbltitle.TabIndex = 7;
            this.lbltitle.Text = "Student Course Registration System";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(6, 46);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(165, 26);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Student Name :";
            // 
            // lblage
            // 
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(6, 86);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(165, 26);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Student Age :";
            // 
            // lblid
            // 
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(6, 127);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(165, 26);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "Student ID :";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(235, 46);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(304, 35);
            this.textname.TabIndex = 0;
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(235, 87);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(304, 35);
            this.textage.TabIndex = 1;
            this.textage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(235, 128);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(304, 35);
            this.textID.TabIndex = 2;
            // 
            // grpcourse
            // 
            this.grpcourse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpcourse.Controls.Add(this.textnumcourses);
            this.grpcourse.Controls.Add(this.label2);
            this.grpcourse.Controls.Add(this.btnremove);
            this.grpcourse.Controls.Add(this.textprice);
            this.grpcourse.Controls.Add(this.btnadd);
            this.grpcourse.Controls.Add(this.textcoursename);
            this.grpcourse.Controls.Add(this.label1);
            this.grpcourse.Controls.Add(this.lblcoursename);
            this.grpcourse.Location = new System.Drawing.Point(30, 271);
            this.grpcourse.Name = "grpcourse";
            this.grpcourse.Size = new System.Drawing.Size(567, 192);
            this.grpcourse.TabIndex = 1;
            this.grpcourse.TabStop = false;
            this.grpcourse.Text = "Course Information ";
            // 
            // lblcoursename
            // 
            this.lblcoursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursename.Location = new System.Drawing.Point(19, 33);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(161, 32);
            this.lblcoursename.TabIndex = 3;
            this.lblcoursename.Text = "Course Name :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course  Price($) :";
            // 
            // textcoursename
            // 
            this.textcoursename.Location = new System.Drawing.Point(186, 25);
            this.textcoursename.Name = "textcoursename";
            this.textcoursename.Size = new System.Drawing.Size(304, 26);
            this.textcoursename.TabIndex = 0;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(186, 74);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(304, 26);
            this.textprice.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(108, 148);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(158, 38);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "&Add Course";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.DarkRed;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Location = new System.Drawing.Point(301, 148);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(158, 38);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "&Remove Course ";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // Regitrated_Courses
            // 
            this.Regitrated_Courses.BackColor = System.Drawing.Color.PapayaWhip;
            this.Regitrated_Courses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Regitrated_Courses.FormattingEnabled = true;
            this.Regitrated_Courses.ItemHeight = 20;
            this.Regitrated_Courses.Location = new System.Drawing.Point(30, 476);
            this.Regitrated_Courses.Name = "Regitrated_Courses";
            this.Regitrated_Courses.Size = new System.Drawing.Size(645, 282);
            this.Regitrated_Courses.TabIndex = 2;
            // 
            // Registration_Result
            // 
            this.Registration_Result.BackColor = System.Drawing.Color.Plum;
            this.Registration_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Registration_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_Result.ForeColor = System.Drawing.Color.Purple;
            this.Registration_Result.FormattingEnabled = true;
            this.Registration_Result.ItemHeight = 20;
            this.Registration_Result.Location = new System.Drawing.Point(877, 59);
            this.Registration_Result.Name = "Registration_Result";
            this.Registration_Result.Size = new System.Drawing.Size(509, 582);
            this.Registration_Result.TabIndex = 4;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btncalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalculate.ForeColor = System.Drawing.Color.White;
            this.btncalculate.Location = new System.Drawing.Point(747, 658);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(137, 67);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Gray;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(1067, 658);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(137, 67);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.HotPink;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(909, 658);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(137, 67);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number Of Courses;";
            // 
            // textnumcourses
            // 
            this.textnumcourses.Location = new System.Drawing.Point(186, 112);
            this.textnumcourses.Name = "textnumcourses";
            this.textnumcourses.Size = new System.Drawing.Size(304, 26);
            this.textnumcourses.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 761);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.Registration_Result);
            this.Controls.Add(this.Regitrated_Courses);
            this.Controls.Add(this.grpcourse);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.grpinformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpinformation.ResumeLayout(false);
            this.grpinformation.PerformLayout();
            this.grpcourse.ResumeLayout(false);
            this.grpcourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpinformation;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.GroupBox grpcourse;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textcoursename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox Regitrated_Courses;
        private System.Windows.Forms.ListBox Registration_Result;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox textnumcourses;
        private System.Windows.Forms.Label label2;
    }
}

