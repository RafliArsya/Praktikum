namespace BankOM
{
    partial class Deposit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit_Form));
            this.btn10000 = new System.Windows.Forms.Button();
            this.btn25000 = new System.Windows.Forms.Button();
            this.btn50000 = new System.Windows.Forms.Button();
            this.btn100000 = new System.Windows.Forms.Button();
            this.btn500000 = new System.Windows.Forms.Button();
            this.btn1000000 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn10000
            // 
            this.btn10000.Location = new System.Drawing.Point(178, 130);
            this.btn10000.Name = "btn10000";
            this.btn10000.Size = new System.Drawing.Size(163, 69);
            this.btn10000.TabIndex = 0;
            this.btn10000.Text = "10000";
            this.btn10000.UseVisualStyleBackColor = true;
            this.btn10000.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn25000
            // 
            this.btn25000.Location = new System.Drawing.Point(178, 232);
            this.btn25000.Name = "btn25000";
            this.btn25000.Size = new System.Drawing.Size(163, 69);
            this.btn25000.TabIndex = 1;
            this.btn25000.Text = "25000";
            this.btn25000.UseVisualStyleBackColor = true;
            this.btn25000.Click += new System.EventHandler(this.Btn25000_Click);
            // 
            // btn50000
            // 
            this.btn50000.Location = new System.Drawing.Point(178, 333);
            this.btn50000.Name = "btn50000";
            this.btn50000.Size = new System.Drawing.Size(163, 69);
            this.btn50000.TabIndex = 2;
            this.btn50000.Text = "50000";
            this.btn50000.UseVisualStyleBackColor = true;
            this.btn50000.Click += new System.EventHandler(this.Btn50000_Click);
            // 
            // btn100000
            // 
            this.btn100000.Location = new System.Drawing.Point(419, 130);
            this.btn100000.Name = "btn100000";
            this.btn100000.Size = new System.Drawing.Size(163, 69);
            this.btn100000.TabIndex = 3;
            this.btn100000.Text = "100000";
            this.btn100000.UseVisualStyleBackColor = true;
            this.btn100000.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btn500000
            // 
            this.btn500000.Location = new System.Drawing.Point(419, 232);
            this.btn500000.Name = "btn500000";
            this.btn500000.Size = new System.Drawing.Size(163, 69);
            this.btn500000.TabIndex = 4;
            this.btn500000.Text = "500000";
            this.btn500000.UseVisualStyleBackColor = true;
            this.btn500000.Click += new System.EventHandler(this.Btn500000_Click);
            // 
            // btn1000000
            // 
            this.btn1000000.Location = new System.Drawing.Point(419, 333);
            this.btn1000000.Name = "btn1000000";
            this.btn1000000.Size = new System.Drawing.Size(163, 69);
            this.btn1000000.TabIndex = 5;
            this.btn1000000.Text = "1000000";
            this.btn1000000.UseVisualStyleBackColor = true;
            this.btn1000000.Click += new System.EventHandler(this.Btn1000000_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(318, 416);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(570, 29);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(163, 20);
            this.tbBalance.TabIndex = 8;
            this.tbBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(440, 29);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(124, 20);
            this.tbName.TabIndex = 7;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(514, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Receiver";
            // 
            // Deposit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn1000000);
            this.Controls.Add(this.btn500000);
            this.Controls.Add(this.btn100000);
            this.Controls.Add(this.btn50000);
            this.Controls.Add(this.btn25000);
            this.Controls.Add(this.btn10000);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Deposit_Form";
            this.Text = "Deposit_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn10000;
        private System.Windows.Forms.Button btn25000;
        private System.Windows.Forms.Button btn50000;
        private System.Windows.Forms.Button btn100000;
        private System.Windows.Forms.Button btn500000;
        private System.Windows.Forms.Button btn1000000;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}