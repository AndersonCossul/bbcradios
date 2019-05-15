namespace BBCRadios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRadio1 = new System.Windows.Forms.Button();
            this.btnRadio2 = new System.Windows.Forms.Button();
            this.btnRadio3 = new System.Windows.Forms.Button();
            this.btnRadio4 = new System.Windows.Forms.Button();
            this.lblPlaying = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(306, 251);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnRadio1
            // 
            this.btnRadio1.Enabled = false;
            this.btnRadio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadio1.Image = ((System.Drawing.Image)(resources.GetObject("btnRadio1.Image")));
            this.btnRadio1.Location = new System.Drawing.Point(28, 31);
            this.btnRadio1.Name = "btnRadio1";
            this.btnRadio1.Size = new System.Drawing.Size(148, 154);
            this.btnRadio1.TabIndex = 1;
            this.btnRadio1.UseVisualStyleBackColor = true;
            // 
            // btnRadio2
            // 
            this.btnRadio2.Enabled = false;
            this.btnRadio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadio2.Image = ((System.Drawing.Image)(resources.GetObject("btnRadio2.Image")));
            this.btnRadio2.Location = new System.Drawing.Point(182, 31);
            this.btnRadio2.Name = "btnRadio2";
            this.btnRadio2.Size = new System.Drawing.Size(154, 154);
            this.btnRadio2.TabIndex = 2;
            this.btnRadio2.UseVisualStyleBackColor = true;
            // 
            // btnRadio3
            // 
            this.btnRadio3.Enabled = false;
            this.btnRadio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadio3.Image = ((System.Drawing.Image)(resources.GetObject("btnRadio3.Image")));
            this.btnRadio3.Location = new System.Drawing.Point(342, 31);
            this.btnRadio3.Name = "btnRadio3";
            this.btnRadio3.Size = new System.Drawing.Size(150, 154);
            this.btnRadio3.TabIndex = 3;
            this.btnRadio3.UseVisualStyleBackColor = true;
            // 
            // btnRadio4
            // 
            this.btnRadio4.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRadio4.Image = ((System.Drawing.Image)(resources.GetObject("btnRadio4.Image")));
            this.btnRadio4.Location = new System.Drawing.Point(498, 31);
            this.btnRadio4.Name = "btnRadio4";
            this.btnRadio4.Size = new System.Drawing.Size(151, 154);
            this.btnRadio4.TabIndex = 4;
            this.btnRadio4.UseVisualStyleBackColor = true;
            this.btnRadio4.Click += new System.EventHandler(this.BtnRadio4_Click);
            // 
            // lblPlaying
            // 
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.Location = new System.Drawing.Point(240, 218);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(225, 13);
            this.lblPlaying.TabIndex = 5;
            this.lblPlaying.Text = "Might take some seconds to connect. Enjoy it.";
            this.lblPlaying.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 286);
            this.Controls.Add(this.lblPlaying);
            this.Controls.Add(this.btnRadio4);
            this.Controls.Add(this.btnRadio3);
            this.Controls.Add(this.btnRadio2);
            this.Controls.Add(this.btnRadio1);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBC Radios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRadio1;
        private System.Windows.Forms.Button btnRadio2;
        private System.Windows.Forms.Button btnRadio3;
        private System.Windows.Forms.Button btnRadio4;
        private System.Windows.Forms.Label lblPlaying;
    }
}

