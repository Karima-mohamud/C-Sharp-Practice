namespace Assignment_file
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
            this.btncreate = new System.Windows.Forms.Button();
            this.btnpath = new System.Windows.Forms.Button();
            this.Append = new System.Windows.Forms.Button();
            this.btnreadline = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnreadtoend = new System.Windows.Forms.Button();
            this.btnreadall = new System.Windows.Forms.Button();
            this.btnotherfunction = new System.Windows.Forms.Button();
            this.btndeletefile = new System.Windows.Forms.Button();
            this.btndeleteitem = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.ListBox();
            this.bbtnalltext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(22, 30);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(211, 65);
            this.btncreate.TabIndex = 0;
            this.btncreate.Text = "Creating New File";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnpath
            // 
            this.btnpath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpath.Location = new System.Drawing.Point(273, 30);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(211, 65);
            this.btnpath.TabIndex = 1;
            this.btnpath.Text = "Creating New File Using Path";
            this.btnpath.UseVisualStyleBackColor = false;
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // Append
            // 
            this.Append.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Append.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Append.Location = new System.Drawing.Point(542, 30);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(211, 65);
            this.Append.TabIndex = 2;
            this.Append.Text = "Append";
            this.Append.UseVisualStyleBackColor = false;
            this.Append.Click += new System.EventHandler(this.Append_Click);
            // 
            // btnreadline
            // 
            this.btnreadline.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnreadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadline.Location = new System.Drawing.Point(22, 122);
            this.btnreadline.Name = "btnreadline";
            this.btnreadline.Size = new System.Drawing.Size(211, 65);
            this.btnreadline.TabIndex = 3;
            this.btnreadline.Text = "Reading the file using Readline()\r\n";
            this.btnreadline.UseVisualStyleBackColor = false;
            this.btnreadline.Click += new System.EventHandler(this.btnreadline_Click);
            // 
            // btnread
            // 
            this.btnread.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnread.Location = new System.Drawing.Point(273, 122);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(211, 65);
            this.btnread.TabIndex = 4;
            this.btnread.Text = "Reading the file using read()\r\n";
            this.btnread.UseVisualStyleBackColor = false;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnreadtoend
            // 
            this.btnreadtoend.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnreadtoend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadtoend.Location = new System.Drawing.Point(542, 122);
            this.btnreadtoend.Name = "btnreadtoend";
            this.btnreadtoend.Size = new System.Drawing.Size(211, 65);
            this.btnreadtoend.TabIndex = 5;
            this.btnreadtoend.Text = "Reading the file using ReadToEnd()\r\n";
            this.btnreadtoend.UseVisualStyleBackColor = false;
            this.btnreadtoend.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreadall
            // 
            this.btnreadall.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnreadall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadall.Location = new System.Drawing.Point(22, 214);
            this.btnreadall.Name = "btnreadall";
            this.btnreadall.Size = new System.Drawing.Size(211, 65);
            this.btnreadall.TabIndex = 6;
            this.btnreadall.Text = "Reading the file using ReadAll()";
            this.btnreadall.UseVisualStyleBackColor = false;
            this.btnreadall.Click += new System.EventHandler(this.btnreadall_Click);
            // 
            // btnotherfunction
            // 
            this.btnotherfunction.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnotherfunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnotherfunction.Location = new System.Drawing.Point(290, 331);
            this.btnotherfunction.Name = "btnotherfunction";
            this.btnotherfunction.Size = new System.Drawing.Size(211, 65);
            this.btnotherfunction.TabIndex = 7;
            this.btnotherfunction.Text = "Reading  other function";
            this.btnotherfunction.UseVisualStyleBackColor = false;
            this.btnotherfunction.Click += new System.EventHandler(this.btnotherfunction_Click);
            // 
            // btndeletefile
            // 
            this.btndeletefile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btndeletefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletefile.Location = new System.Drawing.Point(523, 225);
            this.btndeletefile.Name = "btndeletefile";
            this.btndeletefile.Size = new System.Drawing.Size(211, 65);
            this.btndeletefile.TabIndex = 8;
            this.btndeletefile.Text = "Delete the file";
            this.btndeletefile.UseVisualStyleBackColor = false;
            this.btndeletefile.Click += new System.EventHandler(this.btndeletefile_Click);
            // 
            // btndeleteitem
            // 
            this.btndeleteitem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btndeleteitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteitem.Location = new System.Drawing.Point(22, 331);
            this.btndeleteitem.Name = "btndeleteitem";
            this.btndeleteitem.Size = new System.Drawing.Size(211, 65);
            this.btndeleteitem.TabIndex = 9;
            this.btndeleteitem.Text = "Delete the item file";
            this.btndeleteitem.UseVisualStyleBackColor = false;
            this.btndeleteitem.Click += new System.EventHandler(this.btndeleteitem_Click);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 20;
            this.Result.Location = new System.Drawing.Point(829, 36);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(391, 464);
            this.Result.TabIndex = 10;
            // 
            // bbtnalltext
            // 
            this.bbtnalltext.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bbtnalltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnalltext.Location = new System.Drawing.Point(273, 214);
            this.bbtnalltext.Name = "bbtnalltext";
            this.bbtnalltext.Size = new System.Drawing.Size(211, 65);
            this.bbtnalltext.TabIndex = 11;
            this.bbtnalltext.Text = "Reading the file using ReadAlltext()\r\n";
            this.bbtnalltext.UseVisualStyleBackColor = false;
            this.bbtnalltext.Click += new System.EventHandler(this.bbtnalltext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 625);
            this.Controls.Add(this.bbtnalltext);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.btndeleteitem);
            this.Controls.Add(this.btndeletefile);
            this.Controls.Add(this.btnotherfunction);
            this.Controls.Add(this.btnreadall);
            this.Controls.Add(this.btnreadtoend);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnreadline);
            this.Controls.Add(this.Append);
            this.Controls.Add(this.btnpath);
            this.Controls.Add(this.btncreate);
            this.Name = "Form1";
            this.Text = "files";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnpath;
        private System.Windows.Forms.Button Append;
        private System.Windows.Forms.Button btnreadline;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnreadtoend;
        private System.Windows.Forms.Button btnreadall;
        private System.Windows.Forms.Button btnotherfunction;
        private System.Windows.Forms.Button btndeletefile;
        private System.Windows.Forms.Button btndeleteitem;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Button bbtnalltext;
    }
}

