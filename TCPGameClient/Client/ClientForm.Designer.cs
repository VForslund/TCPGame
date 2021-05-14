
namespace Client
{
    partial class ClientForm
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
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionIcon = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.Panel();
            this.AI = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.Location = new System.Drawing.Point(421, 479);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(271, 20);
            this.StatusTextBox.TabIndex = 1;
            // 
            // ConnectionIcon
            // 
            this.ConnectionIcon.Enabled = false;
            this.ConnectionIcon.Location = new System.Drawing.Point(394, 478);
            this.ConnectionIcon.Name = "ConnectionIcon";
            this.ConnectionIcon.Size = new System.Drawing.Size(21, 20);
            this.ConnectionIcon.TabIndex = 4;
            this.ConnectionIcon.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Enabled = false;
            this.statusLabel.Location = new System.Drawing.Point(657, 461);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Red;
            this.Player.Location = new System.Drawing.Point(519, 179);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(80, 80);
            this.Player.TabIndex = 6;
            // 
            // AI
            // 
            this.AI.BackColor = System.Drawing.Color.Blue;
            this.AI.Location = new System.Drawing.Point(108, 179);
            this.AI.Name = "AI";
            this.AI.Size = new System.Drawing.Size(80, 80);
            this.AI.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.frameUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Move the red box with the keyboard arrows";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AI);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ConnectionIcon);
            this.Controls.Add(this.StatusTextBox);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Button ConnectionIcon;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel Player;
        private System.Windows.Forms.Panel AI;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

