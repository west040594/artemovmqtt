namespace MQTT_Client
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form

        
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.PublishButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.PubMessageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PubTopicTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HostTextBox.Location = new System.Drawing.Point(125, 11);
            this.HostTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HostTextBox.MaxLength = 128;
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(332, 23);
            this.HostTextBox.TabIndex = 2;
            // 
            // PublishButton
            // 
            this.PublishButton.Enabled = false;
            this.PublishButton.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PublishButton.Location = new System.Drawing.Point(12, 161);
            this.PublishButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(555, 31);
            this.PublishButton.TabIndex = 9;
            this.PublishButton.Text = "Publish";
            this.PublishButton.UseVisualStyleBackColor = true;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConnectButton.Location = new System.Drawing.Point(464, 8);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(110, 31);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // PubMessageTextBox
            // 
            this.PubMessageTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PubMessageTextBox.Location = new System.Drawing.Point(118, 127);
            this.PubMessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PubMessageTextBox.MaxLength = 128;
            this.PubMessageTextBox.Name = "PubMessageTextBox";
            this.PubMessageTextBox.Size = new System.Drawing.Size(448, 23);
            this.PubMessageTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Message:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 668);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 10;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DisconnectButton.Location = new System.Drawing.Point(464, 47);
            this.DisconnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(110, 31);
            this.DisconnectButton.TabIndex = 12;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(125, 49);
            this.PortTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortTextBox.MaxLength = 4;
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(52, 23);
            this.PortTextBox.TabIndex = 3;
            this.PortTextBox.Text = "1883";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(75, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(5, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Topic for pub:";
            // 
            // PubTopicTextBox
            // 
            this.PubTopicTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PubTopicTextBox.Location = new System.Drawing.Point(118, 89);
            this.PubTopicTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PubTopicTextBox.MaxLength = 128;
            this.PubTopicTextBox.Name = "PubTopicTextBox";
            this.PubTopicTextBox.Size = new System.Drawing.Size(448, 23);
            this.PubTopicTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 200);
            this.Controls.Add(this.PubTopicTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PubMessageTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PublishButton);
            this.Controls.Add(this.HostTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = " MQTT Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox PubMessageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PubTopicTextBox;
    }
}

