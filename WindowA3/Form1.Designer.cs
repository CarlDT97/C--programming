namespace WindowA3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            HomeMenuItem = new ToolStripMenuItem();
            RegMenuItem = new ToolStripMenuItem();
            LämmnaMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            labelfirstName = new Label();
            labelLastName = new Label();
            labelPnr = new Label();
            labelGender = new Label();
            panelHome = new Panel();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { HomeMenuItem, RegMenuItem, LämmnaMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // HomeMenuItem
            // 
            HomeMenuItem.Name = "HomeMenuItem";
            HomeMenuItem.Size = new Size(45, 20);
            HomeMenuItem.Text = "Hem";
            HomeMenuItem.Click += HomeMenuItem_Click;
            // 
            // RegMenuItem
            // 
            RegMenuItem.Name = "RegMenuItem";
            RegMenuItem.Size = new Size(71, 20);
            RegMenuItem.Text = "Registrera";
            RegMenuItem.Click += RegMenuItem_Click;
            // 
            // LämmnaMenuItem
            // 
            LämmnaMenuItem.Name = "LämmnaMenuItem";
            LämmnaMenuItem.Size = new Size(66, 20);
            LämmnaMenuItem.Text = "Lämmna";
            LämmnaMenuItem.Click += LämmnaMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 48);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Förnamn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Efternamn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 106);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "PersonNr";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(83, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(205, 73);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(205, 102);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Rensa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelfirstName
            // 
            labelfirstName.AutoSize = true;
            labelfirstName.Location = new Point(28, 177);
            labelfirstName.Name = "labelfirstName";
            labelfirstName.Size = new Size(58, 15);
            labelfirstName.TabIndex = 9;
            labelfirstName.Text = "Förnamn:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(28, 207);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(68, 15);
            labelLastName.TabIndex = 10;
            labelLastName.Text = "Efternamn: ";
            // 
            // labelPnr
            // 
            labelPnr.AutoSize = true;
            labelPnr.Location = new Point(28, 236);
            labelPnr.Name = "labelPnr";
            labelPnr.Size = new Size(97, 15);
            labelPnr.TabIndex = 11;
            labelPnr.Text = "Person Nummer:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(28, 265);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(31, 15);
            labelGender.TabIndex = 12;
            labelGender.Text = "Kön:";
            // 
            // panelHome
            // 
            panelHome.Location = new Point(0, 26);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(298, 254);
            panelHome.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(345, 177);
            label4.Name = "label4";
            label4.Size = new Size(157, 37);
            label4.TabIndex = 14;
            label4.Text = "Välkommen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(panelHome);
            Controls.Add(labelLastName);
            Controls.Add(labelPnr);
            Controls.Add(labelGender);
            Controls.Add(labelfirstName);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "App";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem HomeMenuItem;
        private ToolStripMenuItem RegMenuItem;
        private ToolStripMenuItem LämmnaMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label labelfirstName;
        private Label labelLastName;
        private Label labelPnr;
        private Label labelGender;
        private Panel panelHome;
        private Label label4;
    }
}