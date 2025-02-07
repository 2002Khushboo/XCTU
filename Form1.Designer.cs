namespace XCTU_COPY
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button01 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.baud_rate = new System.Windows.Forms.Button();
            this.ComboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.ComboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonScanPort = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.PictureBoxConnectionStatus = new System.Windows.Forms.PictureBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButttonDisconnect = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button0F = new System.Windows.Forms.Button();
            this.button0E = new System.Windows.Forms.Button();
            this.button0D = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(534, 588);
            this.textBox1.TabIndex = 0;
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(25, 53);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(81, 44);
            this.button01.TabIndex = 1;
            this.button01.Text = "0X01";
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button01_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(25, 103);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(81, 45);
            this.button02.TabIndex = 2;
            this.button02.Text = "0X02";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // button09
            // 
            this.button09.Location = new System.Drawing.Point(199, 53);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(81, 44);
            this.button09.TabIndex = 3;
            this.button09.Text = "0X09";
            this.button09.UseVisualStyleBackColor = true;
            this.button09.Click += new System.EventHandler(this.button09_Click);
            // 
            // baud_rate
            // 
            this.baud_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.baud_rate.Cursor = System.Windows.Forms.Cursors.Default;
            this.baud_rate.Enabled = false;
            this.baud_rate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(38)))), ((int)(((byte)(138)))));
            this.baud_rate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(7)))), ((int)(((byte)(114)))));
            this.baud_rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baud_rate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.baud_rate.ForeColor = System.Drawing.Color.Black;
            this.baud_rate.Location = new System.Drawing.Point(25, 367);
            this.baud_rate.Name = "baud_rate";
            this.baud_rate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baud_rate.Size = new System.Drawing.Size(130, 30);
            this.baud_rate.TabIndex = 191;
            this.baud_rate.Text = "BAUD RATE";
            this.baud_rate.UseVisualStyleBackColor = false;
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.ComboBoxBaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ComboBoxBaudRate.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "115200"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(182, 370);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(121, 26);
            this.ComboBoxBaudRate.TabIndex = 190;
            // 
            // ComboBoxPort
            // 
            this.ComboBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.ComboBoxPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPort.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxPort.FormattingEnabled = true;
            this.ComboBoxPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBoxPort.Location = new System.Drawing.Point(182, 332);
            this.ComboBoxPort.Name = "ComboBoxPort";
            this.ComboBoxPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBoxPort.Size = new System.Drawing.Size(121, 26);
            this.ComboBoxPort.TabIndex = 189;
            // 
            // buttonScanPort
            // 
            this.buttonScanPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.buttonScanPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(38)))), ((int)(((byte)(138)))));
            this.buttonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(7)))), ((int)(((byte)(114)))));
            this.buttonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScanPort.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScanPort.ForeColor = System.Drawing.Color.Black;
            this.buttonScanPort.Location = new System.Drawing.Point(25, 330);
            this.buttonScanPort.Name = "buttonScanPort";
            this.buttonScanPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonScanPort.Size = new System.Drawing.Size(130, 30);
            this.buttonScanPort.TabIndex = 188;
            this.buttonScanPort.Text = "SCAN PORT";
            this.buttonScanPort.UseVisualStyleBackColor = false;
            this.buttonScanPort.Click += new System.EventHandler(this.buttonScanPort_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.ButtonConnect);
            this.panel4.Controls.Add(this.ButttonDisconnect);
            this.panel4.Location = new System.Drawing.Point(17, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 210);
            this.panel4.TabIndex = 192;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.panel5.Controls.Add(this.LabelStatus);
            this.panel5.Controls.Add(this.PictureBoxConnectionStatus);
            this.panel5.Location = new System.Drawing.Point(41, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 40);
            this.panel5.TabIndex = 181;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.LabelStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(106)))), ((int)(((byte)(10)))));
            this.LabelStatus.Location = new System.Drawing.Point(17, 13);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelStatus.Size = new System.Drawing.Size(155, 13);
            this.LabelStatus.TabIndex = 69;
            this.LabelStatus.Text = "STATUS: DISCONNECTED";
            // 
            // PictureBoxConnectionStatus
            // 
            this.PictureBoxConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.PictureBoxConnectionStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBoxConnectionStatus.Location = new System.Drawing.Point(173, 14);
            this.PictureBoxConnectionStatus.Name = "PictureBoxConnectionStatus";
            this.PictureBoxConnectionStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PictureBoxConnectionStatus.Size = new System.Drawing.Size(10, 10);
            this.PictureBoxConnectionStatus.TabIndex = 70;
            this.PictureBoxConnectionStatus.TabStop = false;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackColor = System.Drawing.Color.Green;
            this.ButtonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(95)))));
            this.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonConnect.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnect.ForeColor = System.Drawing.Color.White;
            this.ButtonConnect.Location = new System.Drawing.Point(42, 101);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonConnect.Size = new System.Drawing.Size(210, 44);
            this.ButtonConnect.TabIndex = 240;
            this.ButtonConnect.Text = "CONNECT";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButttonDisconnect
            // 
            this.ButttonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.ButttonDisconnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButttonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ButttonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ButttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButttonDisconnect.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.ButttonDisconnect.ForeColor = System.Drawing.Color.White;
            this.ButttonDisconnect.Location = new System.Drawing.Point(42, 101);
            this.ButttonDisconnect.Name = "ButttonDisconnect";
            this.ButttonDisconnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButttonDisconnect.Size = new System.Drawing.Size(210, 44);
            this.ButttonDisconnect.TabIndex = 241;
            this.ButttonDisconnect.Text = "DISCONNECT";
            this.ButttonDisconnect.UseVisualStyleBackColor = false;
            this.ButttonDisconnect.Click += new System.EventHandler(this.ButttonDisconnect_Click);
            // 
            // serialPort
            // 
            this.serialPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort_ErrorReceived);
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // button0F
            // 
            this.button0F.Location = new System.Drawing.Point(199, 204);
            this.button0F.Name = "button0F";
            this.button0F.Size = new System.Drawing.Size(81, 44);
            this.button0F.TabIndex = 196;
            this.button0F.Text = "0X0F";
            this.button0F.UseVisualStyleBackColor = true;
            this.button0F.Click += new System.EventHandler(this.button0F_Click);
            // 
            // button0E
            // 
            this.button0E.Location = new System.Drawing.Point(199, 154);
            this.button0E.Name = "button0E";
            this.button0E.Size = new System.Drawing.Size(81, 43);
            this.button0E.TabIndex = 195;
            this.button0E.Text = "0X0E";
            this.button0E.UseVisualStyleBackColor = true;
            this.button0E.Click += new System.EventHandler(this.button0E_Click);
            // 
            // button0D
            // 
            this.button0D.Location = new System.Drawing.Point(199, 104);
            this.button0D.Name = "button0D";
            this.button0D.Size = new System.Drawing.Size(81, 44);
            this.button0D.TabIndex = 194;
            this.button0D.Text = "0X0D";
            this.button0D.UseVisualStyleBackColor = true;
            this.button0D.Click += new System.EventHandler(this.button0D_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(286, 53);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 44);
            this.button10.TabIndex = 197;
            this.button10.Text = "0X10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button03
            // 
            this.button03.Location = new System.Drawing.Point(25, 154);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(81, 44);
            this.button03.TabIndex = 198;
            this.button03.Text = "0X03";
            this.button03.UseVisualStyleBackColor = true;
            this.button03.Click += new System.EventHandler(this.button03_Click);
            // 
            // button04
            // 
            this.button04.Location = new System.Drawing.Point(25, 204);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(81, 44);
            this.button04.TabIndex = 199;
            this.button04.Text = "0X04";
            this.button04.UseVisualStyleBackColor = true;
            this.button04.Click += new System.EventHandler(this.button04_Click);
            // 
            // button05
            // 
            this.button05.Location = new System.Drawing.Point(112, 53);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(81, 44);
            this.button05.TabIndex = 200;
            this.button05.Text = "0X05";
            this.button05.UseVisualStyleBackColor = true;
            this.button05.Click += new System.EventHandler(this.button05_Click);
            // 
            // button06
            // 
            this.button06.Location = new System.Drawing.Point(112, 103);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(81, 44);
            this.button06.TabIndex = 201;
            this.button06.Text = "0X06";
            this.button06.UseVisualStyleBackColor = true;
            this.button06.Click += new System.EventHandler(this.button06_Click);
            // 
            // button07
            // 
            this.button07.Location = new System.Drawing.Point(112, 153);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(81, 44);
            this.button07.TabIndex = 202;
            this.button07.Text = "0X07";
            this.button07.UseVisualStyleBackColor = true;
            this.button07.Click += new System.EventHandler(this.button07_Click);
            // 
            // button08
            // 
            this.button08.Location = new System.Drawing.Point(112, 204);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(81, 44);
            this.button08.TabIndex = 203;
            this.button08.Text = "0X08";
            this.button08.UseVisualStyleBackColor = true;
            this.button08.Click += new System.EventHandler(this.button08_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.button08);
            this.Controls.Add(this.button07);
            this.Controls.Add(this.button06);
            this.Controls.Add(this.button05);
            this.Controls.Add(this.button04);
            this.Controls.Add(this.button03);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button0F);
            this.Controls.Add(this.button0E);
            this.Controls.Add(this.button0D);
            this.Controls.Add(this.baud_rate);
            this.Controls.Add(this.ComboBoxBaudRate);
            this.Controls.Add(this.ComboBoxPort);
            this.Controls.Add(this.buttonScanPort);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button09);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button baud_rate;
        private System.Windows.Forms.ComboBox ComboBoxBaudRate;
        private System.Windows.Forms.ComboBox ComboBoxPort;
        private System.Windows.Forms.Button buttonScanPort;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.PictureBox PictureBoxConnectionStatus;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButttonDisconnect;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button0F;
        private System.Windows.Forms.Button button0E;
        private System.Windows.Forms.Button button0D;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button button08;
    }
}

