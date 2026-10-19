namespace Hotel_Room_Booking_System
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
            this.bltitle = new System.Windows.Forms.Label();
            this.grppersonal = new System.Windows.Forms.GroupBox();
            this.textguests = new System.Windows.Forms.TextBox();
            this.textnights = new System.Windows.Forms.TextBox();
            this.textage = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.lblguest = new System.Windows.Forms.Label();
            this.lblnights = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.grproomType = new System.Windows.Forms.GroupBox();
            this.rdohight = new System.Windows.Forms.RadioButton();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.rdostandard = new System.Windows.Forms.RadioButton();
            this.grpoption = new System.Windows.Forms.GroupBox();
            this.chkoption = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.Booking_Details = new System.Windows.Forms.ListBox();
            this.grppersonal.SuspendLayout();
            this.grproomType.SuspendLayout();
            this.grpoption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(286, 560);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(139, 53);
            this.btncalculate.TabIndex = 0;
            this.btncalculate.Text = "Ca&lculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click_1);
            // 
            // bltitle
            // 
            this.bltitle.BackColor = System.Drawing.Color.Navy;
            this.bltitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bltitle.ForeColor = System.Drawing.Color.White;
            this.bltitle.Location = new System.Drawing.Point(306, 9);
            this.bltitle.Name = "bltitle";
            this.bltitle.Size = new System.Drawing.Size(747, 56);
            this.bltitle.TabIndex = 1;
            this.bltitle.Text = "Hotel Room Booking System";
            this.bltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grppersonal
            // 
            this.grppersonal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grppersonal.Controls.Add(this.textguests);
            this.grppersonal.Controls.Add(this.textnights);
            this.grppersonal.Controls.Add(this.textage);
            this.grppersonal.Controls.Add(this.textname);
            this.grppersonal.Controls.Add(this.lblguest);
            this.grppersonal.Controls.Add(this.lblnights);
            this.grppersonal.Controls.Add(this.lblage);
            this.grppersonal.Controls.Add(this.lblname);
            this.grppersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grppersonal.Location = new System.Drawing.Point(25, 91);
            this.grppersonal.Name = "grppersonal";
            this.grppersonal.Size = new System.Drawing.Size(565, 207);
            this.grppersonal.TabIndex = 2;
            this.grppersonal.TabStop = false;
            this.grppersonal.Text = "Personal information";
            this.grppersonal.Enter += new System.EventHandler(this.grppersonal_Enter);
            // 
            // textguests
            // 
            this.textguests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textguests.Location = new System.Drawing.Point(248, 166);
            this.textguests.Name = "textguests";
            this.textguests.Size = new System.Drawing.Size(294, 30);
            this.textguests.TabIndex = 9;
            // 
            // textnights
            // 
            this.textnights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textnights.Location = new System.Drawing.Point(248, 125);
            this.textnights.Name = "textnights";
            this.textnights.Size = new System.Drawing.Size(294, 30);
            this.textnights.TabIndex = 8;
            // 
            // textage
            // 
            this.textage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textage.Location = new System.Drawing.Point(248, 84);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(294, 30);
            this.textage.TabIndex = 7;
            // 
            // textname
            // 
            this.textname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textname.Location = new System.Drawing.Point(248, 43);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(294, 30);
            this.textname.TabIndex = 4;
            // 
            // lblguest
            // 
            this.lblguest.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguest.Location = new System.Drawing.Point(24, 164);
            this.lblguest.Name = "lblguest";
            this.lblguest.Size = new System.Drawing.Size(218, 33);
            this.lblguest.TabIndex = 6;
            this.lblguest.Text = "Number Of Guests :";
            // 
            // lblnights
            // 
            this.lblnights.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnights.Location = new System.Drawing.Point(24, 124);
            this.lblnights.Name = "lblnights";
            this.lblnights.Size = new System.Drawing.Size(218, 33);
            this.lblnights.TabIndex = 5;
            this.lblnights.Text = "Number Of Nights:";
            // 
            // lblage
            // 
            this.lblage.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(24, 84);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(182, 33);
            this.lblage.TabIndex = 5;
            this.lblage.Text = "Guest Age:";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(24, 44);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(182, 33);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Guest Name :";
            // 
            // grproomType
            // 
            this.grproomType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grproomType.Controls.Add(this.rdohight);
            this.grproomType.Controls.Add(this.rdonormal);
            this.grproomType.Controls.Add(this.rdostandard);
            this.grproomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grproomType.Location = new System.Drawing.Point(25, 304);
            this.grproomType.Name = "grproomType";
            this.grproomType.Size = new System.Drawing.Size(565, 86);
            this.grproomType.TabIndex = 3;
            this.grproomType.TabStop = false;
            this.grproomType.Text = "Room Type";
            // 
            // rdohight
            // 
            this.rdohight.AutoSize = true;
            this.rdohight.Location = new System.Drawing.Point(399, 46);
            this.rdohight.Name = "rdohight";
            this.rdohight.Size = new System.Drawing.Size(87, 29);
            this.rdohight.TabIndex = 7;
            this.rdohight.TabStop = true;
            this.rdohight.Text = "Hight";
            this.rdohight.UseVisualStyleBackColor = true;
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Location = new System.Drawing.Point(224, 46);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(105, 29);
            this.rdonormal.TabIndex = 6;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "Normal";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // rdostandard
            // 
            this.rdostandard.AutoSize = true;
            this.rdostandard.Location = new System.Drawing.Point(29, 46);
            this.rdostandard.Name = "rdostandard";
            this.rdostandard.Size = new System.Drawing.Size(125, 29);
            this.rdostandard.TabIndex = 5;
            this.rdostandard.TabStop = true;
            this.rdostandard.Text = "Standard";
            this.rdostandard.UseVisualStyleBackColor = true;
            // 
            // grpoption
            // 
            this.grpoption.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpoption.Controls.Add(this.chkoption);
            this.grpoption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpoption.Location = new System.Drawing.Point(25, 420);
            this.grpoption.Name = "grpoption";
            this.grpoption.Size = new System.Drawing.Size(565, 81);
            this.grpoption.TabIndex = 3;
            this.grpoption.TabStop = false;
            this.grpoption.Text = "Additional Option";
            // 
            // chkoption
            // 
            this.chkoption.AutoSize = true;
            this.chkoption.Location = new System.Drawing.Point(27, 45);
            this.chkoption.Name = "chkoption";
            this.chkoption.Size = new System.Drawing.Size(372, 29);
            this.chkoption.TabIndex = 4;
            this.chkoption.Text = "Breakfast (10 per guest per nights)";
            this.chkoption.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(748, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 53);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(517, 560);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(139, 53);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Booking_Details
            // 
            this.Booking_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_Details.FormattingEnabled = true;
            this.Booking_Details.ItemHeight = 29;
            this.Booking_Details.Location = new System.Drawing.Point(843, 84);
            this.Booking_Details.Name = "Booking_Details";
            this.Booking_Details.Size = new System.Drawing.Size(295, 410);
            this.Booking_Details.TabIndex = 6;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 649);
            this.Controls.Add(this.Booking_Details);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpoption);
            this.Controls.Add(this.grproomType);
            this.Controls.Add(this.grppersonal);
            this.Controls.Add(this.bltitle);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "Hotel Room Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grppersonal.ResumeLayout(false);
            this.grppersonal.PerformLayout();
            this.grproomType.ResumeLayout(false);
            this.grproomType.PerformLayout();
            this.grpoption.ResumeLayout(false);
            this.grpoption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label bltitle;
        private System.Windows.Forms.GroupBox grppersonal;
        private System.Windows.Forms.GroupBox grproomType;
        private System.Windows.Forms.GroupBox grpoption;
        private System.Windows.Forms.Label lblguest;
        private System.Windows.Forms.Label lblnights;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox textguests;
        private System.Windows.Forms.TextBox textnights;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.RadioButton rdohight;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.RadioButton rdostandard;
        private System.Windows.Forms.CheckBox chkoption;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox Booking_Details;
    }
}

