namespace OpenAndSaveDialogAssignment
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
            this.btnopen = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.textinfo = new System.Windows.Forms.TextBox();
            this.Displaying = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnopen.Location = new System.Drawing.Point(24, 323);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(239, 58);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "O&pen File Dialog";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(24, 31);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(201, 36);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Text = "Enter The Text :";
            this.lblinfo.Click += new System.EventHandler(this.lblinfo_Click);
            // 
            // textinfo
            // 
            this.textinfo.Location = new System.Drawing.Point(282, 33);
            this.textinfo.Name = "textinfo";
            this.textinfo.Size = new System.Drawing.Size(252, 26);
            this.textinfo.TabIndex = 2;
            // 
            // Displaying
            // 
            this.Displaying.FormattingEnabled = true;
            this.Displaying.ItemHeight = 20;
            this.Displaying.Location = new System.Drawing.Point(738, 16);
            this.Displaying.Name = "Displaying";
            this.Displaying.Size = new System.Drawing.Size(446, 404);
            this.Displaying.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnclear.Location = new System.Drawing.Point(190, 461);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(239, 58);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsave.Location = new System.Drawing.Point(316, 323);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(239, 58);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save File Dialog";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 552);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.Displaying);
            this.Controls.Add(this.textinfo);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnopen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.TextBox textinfo;
        private System.Windows.Forms.ListBox Displaying;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
    }
}

