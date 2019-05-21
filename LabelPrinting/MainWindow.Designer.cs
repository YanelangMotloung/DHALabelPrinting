using System.Windows.Forms;

namespace LabelPrinting
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChange5 = new System.Windows.Forms.Button();
            this.btnChange4 = new System.Windows.Forms.Button();
            this.btnChange3 = new System.Windows.Forms.Button();
            this.btnChange2 = new System.Windows.Forms.Button();
            this.btnChange1 = new System.Windows.Forms.Button();
            this.lblDirectory5 = new System.Windows.Forms.Label();
            this.lblDirectory4 = new System.Windows.Forms.Label();
            this.lblDirectory3 = new System.Windows.Forms.Label();
            this.lblDirectory2 = new System.Windows.Forms.Label();
            this.lblDirectory1 = new System.Windows.Forms.Label();
            this.lblDirectory5Access = new System.Windows.Forms.Label();
            this.lblDirectory4Access = new System.Windows.Forms.Label();
            this.lblDirectory3Access = new System.Windows.Forms.Label();
            this.lblDirectory2Access = new System.Windows.Forms.Label();
            this.lblDirectory1Access = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(99, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(350, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(353, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(353, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Processing File Type     :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Proccesing File Name     :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Files in current Directory :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Reading From Folder      :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currently Perfoming";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(99, 421);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 43);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(328, 420);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(147, 44);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(576, 420);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(172, 44);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChange5);
            this.groupBox2.Controls.Add(this.btnChange4);
            this.groupBox2.Controls.Add(this.btnChange3);
            this.groupBox2.Controls.Add(this.btnChange2);
            this.groupBox2.Controls.Add(this.btnChange1);
            this.groupBox2.Controls.Add(this.lblDirectory5);
            this.groupBox2.Controls.Add(this.lblDirectory4);
            this.groupBox2.Controls.Add(this.lblDirectory3);
            this.groupBox2.Controls.Add(this.lblDirectory2);
            this.groupBox2.Controls.Add(this.lblDirectory1);
            this.groupBox2.Controls.Add(this.lblDirectory5Access);
            this.groupBox2.Controls.Add(this.lblDirectory4Access);
            this.groupBox2.Controls.Add(this.lblDirectory3Access);
            this.groupBox2.Controls.Add(this.lblDirectory2Access);
            this.groupBox2.Controls.Add(this.lblDirectory1Access);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(806, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 351);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnChange5
            // 
            this.btnChange5.Location = new System.Drawing.Point(306, 289);
            this.btnChange5.Name = "btnChange5";
            this.btnChange5.Size = new System.Drawing.Size(75, 23);
            this.btnChange5.TabIndex = 15;
            this.btnChange5.Text = "Change";
            this.btnChange5.UseVisualStyleBackColor = true;
            // 
            // btnChange4
            // 
            this.btnChange4.Location = new System.Drawing.Point(306, 234);
            this.btnChange4.Name = "btnChange4";
            this.btnChange4.Size = new System.Drawing.Size(75, 23);
            this.btnChange4.TabIndex = 14;
            this.btnChange4.Text = "Change";
            this.btnChange4.UseVisualStyleBackColor = true;
            // 
            // btnChange3
            // 
            this.btnChange3.Location = new System.Drawing.Point(306, 178);
            this.btnChange3.Name = "btnChange3";
            this.btnChange3.Size = new System.Drawing.Size(75, 23);
            this.btnChange3.TabIndex = 13;
            this.btnChange3.Text = "Change";
            this.btnChange3.UseVisualStyleBackColor = true;
            // 
            // btnChange2
            // 
            this.btnChange2.Location = new System.Drawing.Point(306, 120);
            this.btnChange2.Name = "btnChange2";
            this.btnChange2.Size = new System.Drawing.Size(75, 23);
            this.btnChange2.TabIndex = 12;
            this.btnChange2.Text = "Change";
            this.btnChange2.UseVisualStyleBackColor = true;
            // 
            // btnChange1
            // 
            this.btnChange1.Location = new System.Drawing.Point(306, 67);
            this.btnChange1.Name = "btnChange1";
            this.btnChange1.Size = new System.Drawing.Size(75, 23);
            this.btnChange1.TabIndex = 11;
            this.btnChange1.Text = "Change";
            this.btnChange1.UseVisualStyleBackColor = true;
            this.btnChange1.Click += new System.EventHandler(this.btnChange1_Click);
            // 
            // lblDirectory5
            // 
            this.lblDirectory5.AutoSize = true;
            this.lblDirectory5.Location = new System.Drawing.Point(71, 299);
            this.lblDirectory5.Name = "lblDirectory5";
            this.lblDirectory5.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory5.TabIndex = 10;
            this.lblDirectory5.Text = "label25";
            // 
            // lblDirectory4
            // 
            this.lblDirectory4.AutoSize = true;
            this.lblDirectory4.Location = new System.Drawing.Point(71, 244);
            this.lblDirectory4.Name = "lblDirectory4";
            this.lblDirectory4.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory4.TabIndex = 9;
            this.lblDirectory4.Text = "label24";
            // 
            // lblDirectory3
            // 
            this.lblDirectory3.AutoSize = true;
            this.lblDirectory3.Location = new System.Drawing.Point(71, 183);
            this.lblDirectory3.Name = "lblDirectory3";
            this.lblDirectory3.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory3.TabIndex = 8;
            this.lblDirectory3.Text = "label23";
            // 
            // lblDirectory2
            // 
            this.lblDirectory2.AutoSize = true;
            this.lblDirectory2.Location = new System.Drawing.Point(71, 130);
            this.lblDirectory2.Name = "lblDirectory2";
            this.lblDirectory2.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory2.TabIndex = 7;
            this.lblDirectory2.Text = "label22";
            // 
            // lblDirectory1
            // 
            this.lblDirectory1.AutoSize = true;
            this.lblDirectory1.Location = new System.Drawing.Point(71, 67);
            this.lblDirectory1.Name = "lblDirectory1";
            this.lblDirectory1.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory1.TabIndex = 6;
            this.lblDirectory1.Text = "label21";
            // 
            // lblDirectory5Access
            // 
            this.lblDirectory5Access.AutoSize = true;
            this.lblDirectory5Access.Location = new System.Drawing.Point(6, 299);
            this.lblDirectory5Access.Name = "lblDirectory5Access";
            this.lblDirectory5Access.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory5Access.TabIndex = 5;
            this.lblDirectory5Access.Text = "label20";
            // 
            // lblDirectory4Access
            // 
            this.lblDirectory4Access.AutoSize = true;
            this.lblDirectory4Access.Location = new System.Drawing.Point(6, 244);
            this.lblDirectory4Access.Name = "lblDirectory4Access";
            this.lblDirectory4Access.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory4Access.TabIndex = 4;
            this.lblDirectory4Access.Text = "label19";
            // 
            // lblDirectory3Access
            // 
            this.lblDirectory3Access.AutoSize = true;
            this.lblDirectory3Access.Location = new System.Drawing.Point(6, 183);
            this.lblDirectory3Access.Name = "lblDirectory3Access";
            this.lblDirectory3Access.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory3Access.TabIndex = 3;
            this.lblDirectory3Access.Text = "label18";
            // 
            // lblDirectory2Access
            // 
            this.lblDirectory2Access.AutoSize = true;
            this.lblDirectory2Access.Location = new System.Drawing.Point(6, 130);
            this.lblDirectory2Access.Name = "lblDirectory2Access";
            this.lblDirectory2Access.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory2Access.TabIndex = 2;
            this.lblDirectory2Access.Text = "label17";
            // 
            // lblDirectory1Access
            // 
            this.lblDirectory1Access.AutoSize = true;
            this.lblDirectory1Access.Location = new System.Drawing.Point(6, 67);
            this.lblDirectory1Access.Name = "lblDirectory1Access";
            this.lblDirectory1Access.Size = new System.Drawing.Size(41, 13);
            this.lblDirectory1Access.TabIndex = 1;
            this.lblDirectory1Access.Text = "label16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Configured Directory";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(806, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 106);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Printer Status        :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Connected Printer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Printer Status";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "DHA LABEL PRINTER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnStart;
        private Button btnPause;
        private Button btnStop;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnChange5;
        private Button btnChange4;
        private Button btnChange3;
        private Button btnChange2;
        private Button btnChange1;
        private Label lblDirectory5;
        private Label lblDirectory4;
        private Label lblDirectory3;
        private Label lblDirectory2;
        private Label lblDirectory1;
        private Label lblDirectory5Access;
        private Label lblDirectory4Access;
        private Label lblDirectory3Access;
        private Label lblDirectory2Access;
        private Label lblDirectory1Access;
    }
}

