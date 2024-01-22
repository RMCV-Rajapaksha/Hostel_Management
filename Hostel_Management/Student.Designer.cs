namespace Hostel_Management
{
    partial class Student
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StudUsn = new System.Windows.Forms.MaskedTextBox();
            this.FatherName = new System.Windows.Forms.MaskedTextBox();
            this.MotherName = new System.Windows.Forms.MaskedTextBox();
            this.AddressTb = new System.Windows.Forms.MaskedTextBox();
            this.CollegeTb = new System.Windows.Forms.MaskedTextBox();
            this.StudName = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StudRoomCd = new System.Windows.Forms.ComboBox();
            this.StudentDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.StduStatusCb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 100);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(887, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 43);
            this.label5.TabIndex = 14;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(269, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT INFORMATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 23);
            this.panel2.TabIndex = 2;
            // 
            // StudUsn
            // 
            this.StudUsn.ForeColor = System.Drawing.Color.Crimson;
            this.StudUsn.Location = new System.Drawing.Point(38, 153);
            this.StudUsn.Name = "StudUsn";
            this.StudUsn.Size = new System.Drawing.Size(211, 26);
            this.StudUsn.TabIndex = 4;
            this.StudUsn.Text = "Student USN";
            this.StudUsn.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // FatherName
            // 
            this.FatherName.ForeColor = System.Drawing.Color.Crimson;
            this.FatherName.Location = new System.Drawing.Point(38, 238);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(211, 26);
            this.FatherName.TabIndex = 6;
            this.FatherName.Text = "Father Name";
            this.FatherName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // MotherName
            // 
            this.MotherName.ForeColor = System.Drawing.Color.Crimson;
            this.MotherName.Location = new System.Drawing.Point(38, 280);
            this.MotherName.Name = "MotherName";
            this.MotherName.Size = new System.Drawing.Size(211, 26);
            this.MotherName.TabIndex = 7;
            this.MotherName.Text = "Mother Name";
            // 
            // AddressTb
            // 
            this.AddressTb.ForeColor = System.Drawing.Color.Crimson;
            this.AddressTb.Location = new System.Drawing.Point(38, 325);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(211, 26);
            this.AddressTb.TabIndex = 8;
            this.AddressTb.Text = "Address";
            // 
            // CollegeTb
            // 
            this.CollegeTb.ForeColor = System.Drawing.Color.Crimson;
            this.CollegeTb.Location = new System.Drawing.Point(29, 371);
            this.CollegeTb.Name = "CollegeTb";
            this.CollegeTb.Size = new System.Drawing.Size(211, 26);
            this.CollegeTb.TabIndex = 9;
            this.CollegeTb.Text = "College";
            this.CollegeTb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // StudName
            // 
            this.StudName.ForeColor = System.Drawing.Color.Crimson;
            this.StudName.Location = new System.Drawing.Point(38, 193);
            this.StudName.Name = "StudName";
            this.StudName.Size = new System.Drawing.Size(211, 26);
            this.StudName.TabIndex = 12;
            this.StudName.Text = "Student Name";
            this.StudName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox8_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(34, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Room Num ";
            // 
            // StudRoomCd
            // 
            this.StudRoomCd.FormattingEnabled = true;
            this.StudRoomCd.Location = new System.Drawing.Point(187, 403);
            this.StudRoomCd.Name = "StudRoomCd";
            this.StudRoomCd.Size = new System.Drawing.Size(62, 28);
            this.StudRoomCd.TabIndex = 15;
            // 
            // StudentDGV
            // 
            this.StudentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDGV.Location = new System.Drawing.Point(262, 193);
            this.StudentDGV.Name = "StudentDGV";
            this.StudentDGV.RowHeadersWidth = 62;
            this.StudentDGV.RowTemplate.Height = 28;
            this.StudentDGV.Size = new System.Drawing.Size(647, 300);
            this.StudentDGV.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(491, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "STUDENT LIST";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 575);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 26);
            this.panel3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(34, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Student Status";
            // 
            // StduStatusCb
            // 
            this.StduStatusCb.FormattingEnabled = true;
            this.StduStatusCb.Items.AddRange(new object[] {
            "Living",
            "Left"});
            this.StduStatusCb.Location = new System.Drawing.Point(187, 449);
            this.StduStatusCb.Name = "StduStatusCb";
            this.StduStatusCb.Size = new System.Drawing.Size(62, 28);
            this.StduStatusCb.TabIndex = 16;
            this.StduStatusCb.SelectedIndexChanged += new System.EventHandler(this.StduStatusCb_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(240, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 23;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(132, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(39, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(131, 535);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 32);
            this.button4.TabIndex = 24;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.StudentDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StduStatusCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StudRoomCd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudName);
            this.Controls.Add(this.CollegeTb);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.MotherName);
            this.Controls.Add(this.FatherName);
            this.Controls.Add(this.StudUsn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox StudUsn;
        private System.Windows.Forms.MaskedTextBox FatherName;
        private System.Windows.Forms.MaskedTextBox MotherName;
        private System.Windows.Forms.MaskedTextBox AddressTb;
        private System.Windows.Forms.MaskedTextBox CollegeTb;
        private System.Windows.Forms.MaskedTextBox StudName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StudRoomCd;
        private System.Windows.Forms.DataGridView StudentDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StduStatusCb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}