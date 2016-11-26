namespace LightBulbInstance
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
            this.moveFormPanel = new System.Windows.Forms.Panel();
            this.controlsContainer1 = new System.Windows.Forms.Panel();
            this.cmdDown = new System.Windows.Forms.Button();
            this.cmdUp = new System.Windows.Forms.Button();
            this.cmdDestroy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.controlsContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveFormPanel
            // 
            this.moveFormPanel.BackColor = System.Drawing.Color.White;
            this.moveFormPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.moveFormPanel.Location = new System.Drawing.Point(0, 0);
            this.moveFormPanel.Name = "moveFormPanel";
            this.moveFormPanel.Size = new System.Drawing.Size(128, 128);
            this.moveFormPanel.TabIndex = 0;
            this.moveFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveFormPanel_MouseDown);
            // 
            // controlsContainer1
            // 
            this.controlsContainer1.BackColor = System.Drawing.Color.White;
            this.controlsContainer1.Controls.Add(this.cmdDown);
            this.controlsContainer1.Controls.Add(this.cmdUp);
            this.controlsContainer1.Controls.Add(this.cmdDestroy);
            this.controlsContainer1.Location = new System.Drawing.Point(130, -2);
            this.controlsContainer1.Name = "controlsContainer1";
            this.controlsContainer1.Size = new System.Drawing.Size(99, 148);
            this.controlsContainer1.TabIndex = 2;
            // 
            // cmdDown
            // 
            this.cmdDown.BackColor = System.Drawing.Color.White;
            this.cmdDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDown.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmdDown.Image = global::LightBulbInstance.Properties.Resources.orange_arrow_down;
            this.cmdDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDown.Location = new System.Drawing.Point(3, 85);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(86, 30);
            this.cmdDown.TabIndex = 3;
            this.cmdDown.Text = "Disminuir";
            this.cmdDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDown.UseVisualStyleBackColor = false;
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // cmdUp
            // 
            this.cmdUp.BackColor = System.Drawing.Color.White;
            this.cmdUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmdUp.Image = global::LightBulbInstance.Properties.Resources.green_arrow_up;
            this.cmdUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdUp.Location = new System.Drawing.Point(3, 49);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(86, 30);
            this.cmdUp.TabIndex = 2;
            this.cmdUp.Text = "Aumentar";
            this.cmdUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdUp.UseVisualStyleBackColor = false;
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // cmdDestroy
            // 
            this.cmdDestroy.BackColor = System.Drawing.Color.White;
            this.cmdDestroy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDestroy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmdDestroy.Image = global::LightBulbInstance.Properties.Resources.destroyIcon;
            this.cmdDestroy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDestroy.Location = new System.Drawing.Point(3, 13);
            this.cmdDestroy.Name = "cmdDestroy";
            this.cmdDestroy.Size = new System.Drawing.Size(86, 30);
            this.cmdDestroy.TabIndex = 1;
            this.cmdDestroy.Text = "Destruir";
            this.cmdDestroy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDestroy.UseVisualStyleBackColor = false;
            this.cmdDestroy.Click += new System.EventHandler(this.cmdDestroy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblCurrentValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 31);
            this.panel1.TabIndex = 3;
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentValue.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentValue.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(45, 16);
            this.lblCurrentValue.TabIndex = 0;
            this.lblCurrentValue.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 156);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moveFormPanel);
            this.Controls.Add(this.controlsContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlsContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel moveFormPanel;
        private System.Windows.Forms.Button cmdDestroy;
        private System.Windows.Forms.Panel controlsContainer1;
        private System.Windows.Forms.Button cmdUp;
        private System.Windows.Forms.Button cmdDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Timer timer1;
    }
}

