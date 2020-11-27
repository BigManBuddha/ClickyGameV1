namespace ClickyGameV1
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
            this.btn_Click = new System.Windows.Forms.Button();
            this.lbl_Click = new System.Windows.Forms.Label();
            this.lbl_PassiveClicks = new System.Windows.Forms.Label();
            this.lbl_NumberOfClicks = new System.Windows.Forms.Label();
            this.lblPassiveClicks = new System.Windows.Forms.Label();
            this.Btn_Buy = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wwToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listbox_PassiveItems = new System.Windows.Forms.ListBox();
            this.lbl_clickValue = new System.Windows.Forms.Label();
            this.btn_SurpriseItem1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Click
            // 
            this.btn_Click.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Click.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_Click.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Click.FlatAppearance.BorderSize = 5;
            this.btn_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Click.Font = new System.Drawing.Font("Burbank Big Cd Bd", 50F, System.Drawing.FontStyle.Bold);
            this.btn_Click.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Click.Location = new System.Drawing.Point(370, 389);
            this.btn_Click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Click.Name = "btn_Click";
            this.btn_Click.Size = new System.Drawing.Size(324, 127);
            this.btn_Click.TabIndex = 4;
            this.btn_Click.Text = "Click";
            this.btn_Click.UseVisualStyleBackColor = false;
            this.btn_Click.Click += new System.EventHandler(this.btn_Click_Click);
            // 
            // lbl_Click
            // 
            this.lbl_Click.AutoSize = true;
            this.lbl_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbl_Click.Font = new System.Drawing.Font("Burbank Big Cd Bd", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Click.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Click.Location = new System.Drawing.Point(366, 29);
            this.lbl_Click.Name = "lbl_Click";
            this.lbl_Click.Size = new System.Drawing.Size(56, 22);
            this.lbl_Click.TabIndex = 5;
            this.lbl_Click.Text = "Clicks:";
            // 
            // lbl_PassiveClicks
            // 
            this.lbl_PassiveClicks.AutoSize = true;
            this.lbl_PassiveClicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbl_PassiveClicks.Font = new System.Drawing.Font("Burbank Big Cd Bd", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_PassiveClicks.ForeColor = System.Drawing.Color.Silver;
            this.lbl_PassiveClicks.Location = new System.Drawing.Point(366, 301);
            this.lbl_PassiveClicks.Name = "lbl_PassiveClicks";
            this.lbl_PassiveClicks.Size = new System.Drawing.Size(139, 22);
            this.lbl_PassiveClicks.TabIndex = 6;
            this.lbl_PassiveClicks.Text = "Passive Click rate:";
            // 
            // lbl_NumberOfClicks
            // 
            this.lbl_NumberOfClicks.AutoSize = true;
            this.lbl_NumberOfClicks.Font = new System.Drawing.Font("Burbank Big Cd Bd", 70F, System.Drawing.FontStyle.Bold);
            this.lbl_NumberOfClicks.ForeColor = System.Drawing.Color.Silver;
            this.lbl_NumberOfClicks.Location = new System.Drawing.Point(178, 121);
            this.lbl_NumberOfClicks.Name = "lbl_NumberOfClicks";
            this.lbl_NumberOfClicks.Size = new System.Drawing.Size(0, 94);
            this.lbl_NumberOfClicks.TabIndex = 7;
            // 
            // lblPassiveClicks
            // 
            this.lblPassiveClicks.AutoSize = true;
            this.lblPassiveClicks.Font = new System.Drawing.Font("Burbank Big Cd Bd", 25F, System.Drawing.FontStyle.Bold);
            this.lblPassiveClicks.ForeColor = System.Drawing.Color.Silver;
            this.lblPassiveClicks.Location = new System.Drawing.Point(375, 341);
            this.lblPassiveClicks.Name = "lblPassiveClicks";
            this.lblPassiveClicks.Size = new System.Drawing.Size(0, 34);
            this.lblPassiveClicks.TabIndex = 8;
            // 
            // Btn_Buy
            // 
            this.Btn_Buy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Buy.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Btn_Buy.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Btn_Buy.FlatAppearance.BorderSize = 5;
            this.Btn_Buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.Btn_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Buy.Font = new System.Drawing.Font("Burbank Big Cd Bd", 16F, System.Drawing.FontStyle.Bold);
            this.Btn_Buy.ForeColor = System.Drawing.Color.DarkOrange;
            this.Btn_Buy.Location = new System.Drawing.Point(480, 524);
            this.Btn_Buy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Buy.Name = "Btn_Buy";
            this.Btn_Buy.Size = new System.Drawing.Size(95, 30);
            this.Btn_Buy.TabIndex = 9;
            this.Btn_Buy.Text = "Buy";
            this.Btn_Buy.UseVisualStyleBackColor = false;
            this.Btn_Buy.Click += new System.EventHandler(this.Btn_Buy_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripMenuItem1,
            this.wwToolStripMenuItem,
            this.wwToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 97);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // wwToolStripMenuItem
            // 
            this.wwToolStripMenuItem.Name = "wwToolStripMenuItem";
            this.wwToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.wwToolStripMenuItem.Text = "ww";
            // 
            // wwToolStripMenuItem1
            // 
            this.wwToolStripMenuItem1.Name = "wwToolStripMenuItem1";
            this.wwToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.wwToolStripMenuItem1.Text = "ww";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Silver;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(700, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 525);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listbox_PassiveItems
            // 
            this.listbox_PassiveItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listbox_PassiveItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_PassiveItems.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_PassiveItems.ForeColor = System.Drawing.Color.Silver;
            this.listbox_PassiveItems.FormattingEnabled = true;
            this.listbox_PassiveItems.ItemHeight = 21;
            this.listbox_PassiveItems.Location = new System.Drawing.Point(12, 6);
            this.listbox_PassiveItems.Name = "listbox_PassiveItems";
            this.listbox_PassiveItems.Size = new System.Drawing.Size(352, 525);
            this.listbox_PassiveItems.TabIndex = 12;
            this.listbox_PassiveItems.SelectedIndexChanged += new System.EventHandler(this.listbox_PassiveItems_SelectedIndexChanged);
            // 
            // lbl_clickValue
            // 
            this.lbl_clickValue.AutoSize = true;
            this.lbl_clickValue.Font = new System.Drawing.Font("Burbank Big Cd Bd", 72F, System.Drawing.FontStyle.Bold);
            this.lbl_clickValue.ForeColor = System.Drawing.Color.Silver;
            this.lbl_clickValue.Location = new System.Drawing.Point(354, 101);
            this.lbl_clickValue.Name = "lbl_clickValue";
            this.lbl_clickValue.Size = new System.Drawing.Size(134, 96);
            this.lbl_clickValue.TabIndex = 13;
            this.lbl_clickValue.Text = "0.0";
            // 
            // btn_SurpriseItem1
            // 
            this.btn_SurpriseItem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_SurpriseItem1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_SurpriseItem1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_SurpriseItem1.FlatAppearance.BorderSize = 5;
            this.btn_SurpriseItem1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_SurpriseItem1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_SurpriseItem1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SurpriseItem1.Font = new System.Drawing.Font("Burbank Big Cd Bd", 16F, System.Drawing.FontStyle.Bold);
            this.btn_SurpriseItem1.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_SurpriseItem1.Location = new System.Drawing.Point(370, 252);
            this.btn_SurpriseItem1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SurpriseItem1.Name = "btn_SurpriseItem1";
            this.btn_SurpriseItem1.Size = new System.Drawing.Size(152, 45);
            this.btn_SurpriseItem1.TabIndex = 14;
            this.btn_SurpriseItem1.Text = "Buy Surprise (500)";
            this.btn_SurpriseItem1.UseVisualStyleBackColor = false;
            this.btn_SurpriseItem1.Click += new System.EventHandler(this.btn_SurpriseItem1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Burbank Big Cd Bd", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(542, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Buy Surprise (500)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Burbank Big Cd Bd", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Description.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Description.Location = new System.Drawing.Point(375, 180);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(0, 22);
            this.lbl_Description.TabIndex = 16;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Burbank Big Cd Bd", 16F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.Silver;
            this.lblDescription.Location = new System.Drawing.Point(370, 175);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 22);
            this.lblDescription.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1106, 554);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_SurpriseItem1);
            this.Controls.Add(this.lbl_clickValue);
            this.Controls.Add(this.listbox_PassiveItems);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Btn_Buy);
            this.Controls.Add(this.lblPassiveClicks);
            this.Controls.Add(this.lbl_NumberOfClicks);
            this.Controls.Add(this.lbl_PassiveClicks);
            this.Controls.Add(this.lbl_Click);
            this.Controls.Add(this.btn_Click);
            this.Font = new System.Drawing.Font("Burbank Big Cd Bd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Click;
        private System.Windows.Forms.Label lbl_Click;
        private System.Windows.Forms.Label lbl_PassiveClicks;
        private System.Windows.Forms.Label lbl_NumberOfClicks;
        private System.Windows.Forms.Label lblPassiveClicks;
        private System.Windows.Forms.Button Btn_Buy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wwToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listbox_PassiveItems;
        private System.Windows.Forms.Label lbl_clickValue;
        private System.Windows.Forms.Button btn_SurpriseItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Timer timer1;
    }
}

