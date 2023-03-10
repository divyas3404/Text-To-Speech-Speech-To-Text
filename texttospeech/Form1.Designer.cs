namespace texttospeech
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.stoptts = new System.Windows.Forms.Button();
            this.resumetts = new System.Windows.Forms.Button();
            this.pausetts = new System.Windows.Forms.Button();
            this.speaktts = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stopstt = new System.Windows.Forms.Button();
            this.speakstt = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.stoptts);
            this.panel1.Controls.Add(this.resumetts);
            this.panel1.Controls.Add(this.pausetts);
            this.panel1.Controls.Add(this.speaktts);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(44, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 525);
            this.panel1.TabIndex = 0;
            // 
            // stoptts
            // 
            this.stoptts.BackColor = System.Drawing.Color.LightSalmon;
            this.stoptts.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoptts.ForeColor = System.Drawing.Color.Teal;
            this.stoptts.Location = new System.Drawing.Point(166, 363);
            this.stoptts.Name = "stoptts";
            this.stoptts.Size = new System.Drawing.Size(75, 41);
            this.stoptts.TabIndex = 4;
            this.stoptts.Text = "Stop";
            this.stoptts.UseVisualStyleBackColor = false;
            this.stoptts.Click += new System.EventHandler(this.button4_Click);
            // 
            // resumetts
            // 
            this.resumetts.BackColor = System.Drawing.Color.White;
            this.resumetts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resumetts.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumetts.ForeColor = System.Drawing.Color.Teal;
            this.resumetts.Location = new System.Drawing.Point(271, 363);
            this.resumetts.Name = "resumetts";
            this.resumetts.Size = new System.Drawing.Size(88, 41);
            this.resumetts.TabIndex = 3;
            this.resumetts.Text = "Resume";
            this.resumetts.UseVisualStyleBackColor = false;
            this.resumetts.Click += new System.EventHandler(this.button3_Click);
            // 
            // pausetts
            // 
            this.pausetts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pausetts.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausetts.ForeColor = System.Drawing.Color.Teal;
            this.pausetts.Location = new System.Drawing.Point(54, 363);
            this.pausetts.Name = "pausetts";
            this.pausetts.Size = new System.Drawing.Size(88, 41);
            this.pausetts.TabIndex = 2;
            this.pausetts.Text = "Pause";
            this.pausetts.UseVisualStyleBackColor = false;
            this.pausetts.Click += new System.EventHandler(this.button2_Click);
            // 
            // speaktts
            // 
            this.speaktts.BackColor = System.Drawing.Color.PaleTurquoise;
            this.speaktts.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speaktts.ForeColor = System.Drawing.Color.Teal;
            this.speaktts.Location = new System.Drawing.Point(146, 293);
            this.speaktts.Name = "speaktts";
            this.speaktts.Size = new System.Drawing.Size(122, 41);
            this.speaktts.TabIndex = 1;
            this.speaktts.Text = "Speak";
            this.speaktts.UseVisualStyleBackColor = false;
            this.speaktts.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(378, 198);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.stopstt);
            this.panel2.Controls.Add(this.speakstt);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Location = new System.Drawing.Point(514, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 525);
            this.panel2.TabIndex = 1;
            // 
            // stopstt
            // 
            this.stopstt.BackColor = System.Drawing.Color.LightSalmon;
            this.stopstt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopstt.ForeColor = System.Drawing.Color.Teal;
            this.stopstt.Location = new System.Drawing.Point(240, 293);
            this.stopstt.Name = "stopstt";
            this.stopstt.Size = new System.Drawing.Size(97, 41);
            this.stopstt.TabIndex = 5;
            this.stopstt.Text = "Stop";
            this.stopstt.UseVisualStyleBackColor = false;
            this.stopstt.Click += new System.EventHandler(this.stopstt_Click);
            // 
            // speakstt
            // 
            this.speakstt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.speakstt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speakstt.ForeColor = System.Drawing.Color.Teal;
            this.speakstt.Location = new System.Drawing.Point(83, 293);
            this.speakstt.Name = "speakstt";
            this.speakstt.Size = new System.Drawing.Size(101, 41);
            this.speakstt.TabIndex = 2;
            this.speakstt.Text = "Speak";
            this.speakstt.UseVisualStyleBackColor = false;
            this.speakstt.Click += new System.EventHandler(this.button5_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(22, 55);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(378, 198);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(116, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 52);
            this.label5.TabIndex = 7;
            this.label5.Text = "Text To Speech";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(588, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Speech To Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(988, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stoptts;
        private System.Windows.Forms.Button resumetts;
        private System.Windows.Forms.Button pausetts;
        private System.Windows.Forms.Button speaktts;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button speakstt;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopstt;
    }
}

