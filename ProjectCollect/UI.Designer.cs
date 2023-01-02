namespace ProjectCollect
{
    partial class UI
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClsBox = new System.Windows.Forms.ListBox();
            this.IteBox = new System.Windows.Forms.ListBox();
            this.RecBox = new System.Windows.Forms.ListBox();
            this.EnuBox = new System.Windows.Forms.ListBox();
            this.AnoBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Dir";
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(162, 23);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(507, 35);
            this.Path.TabIndex = 2;
            // 
            // Display
            // 
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Display.Location = new System.Drawing.Point(162, 79);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(626, 142);
            this.Display.TabIndex = 3;
            this.Display.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Information";
            // 
            // ClsBox
            // 
            this.ClsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClsBox.FormattingEnabled = true;
            this.ClsBox.ItemHeight = 24;
            this.ClsBox.Location = new System.Drawing.Point(3, 3);
            this.ClsBox.Name = "ClsBox";
            this.ClsBox.Size = new System.Drawing.Size(750, 468);
            this.ClsBox.TabIndex = 6;
            // 
            // IteBox
            // 
            this.IteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IteBox.FormattingEnabled = true;
            this.IteBox.ItemHeight = 24;
            this.IteBox.Location = new System.Drawing.Point(3, 3);
            this.IteBox.Name = "IteBox";
            this.IteBox.Size = new System.Drawing.Size(750, 468);
            this.IteBox.TabIndex = 8;
            // 
            // RecBox
            // 
            this.RecBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecBox.FormattingEnabled = true;
            this.RecBox.ItemHeight = 24;
            this.RecBox.Location = new System.Drawing.Point(0, 0);
            this.RecBox.Name = "RecBox";
            this.RecBox.Size = new System.Drawing.Size(756, 474);
            this.RecBox.TabIndex = 10;
            // 
            // EnuBox
            // 
            this.EnuBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnuBox.FormattingEnabled = true;
            this.EnuBox.ItemHeight = 24;
            this.EnuBox.Location = new System.Drawing.Point(0, 0);
            this.EnuBox.Name = "EnuBox";
            this.EnuBox.Size = new System.Drawing.Size(756, 474);
            this.EnuBox.TabIndex = 12;
            // 
            // AnoBox
            // 
            this.AnoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnoBox.FormattingEnabled = true;
            this.AnoBox.ItemHeight = 24;
            this.AnoBox.Location = new System.Drawing.Point(0, 0);
            this.AnoBox.Name = "AnoBox";
            this.AnoBox.Size = new System.Drawing.Size(756, 474);
            this.AnoBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 774);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(770, 70);
            this.button2.TabIndex = 15;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(16, 236);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 521);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ClsBox);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Class";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.IteBox);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Interface";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.EnuBox);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(756, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Enum";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.AnoBox);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(756, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Annotation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.RecBox);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(756, 474);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Record(Some Bugs)";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 1197);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UI";
            this.Text = "Java Status Tools";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.RichTextBox Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ClsBox;
        private System.Windows.Forms.ListBox IteBox;
        private System.Windows.Forms.ListBox RecBox;
        private System.Windows.Forms.ListBox EnuBox;
        private System.Windows.Forms.ListBox AnoBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}