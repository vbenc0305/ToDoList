namespace ToDoList
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuPanel = new Panel();
            MenuGomb3 = new Button();
            MenuGomb2 = new Button();
            MenuGomb1 = new Button();
            MenuGomb = new PictureBox();
            idozit = new System.Windows.Forms.Timer(components);
            UdvLabel = new Label();
            label1 = new Label();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuGomb).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = SystemColors.ActiveCaption;
            menuPanel.Controls.Add(MenuGomb3);
            menuPanel.Controls.Add(MenuGomb2);
            menuPanel.Controls.Add(MenuGomb1);
            menuPanel.Location = new Point(0, 87);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(127, 253);
            menuPanel.TabIndex = 0;
            // 
            // MenuGomb3
            // 
            MenuGomb3.Cursor = Cursors.Hand;
            MenuGomb3.Location = new Point(0, 185);
            MenuGomb3.Name = "MenuGomb3";
            MenuGomb3.Size = new Size(127, 29);
            MenuGomb3.TabIndex = 2;
            MenuGomb3.Text = "Névjegy";
            MenuGomb3.UseVisualStyleBackColor = true;
            MenuGomb3.Click += button1_Click;
            // 
            // MenuGomb2
            // 
            MenuGomb2.Cursor = Cursors.Hand;
            MenuGomb2.Location = new Point(0, 107);
            MenuGomb2.Name = "MenuGomb2";
            MenuGomb2.Size = new Size(124, 29);
            MenuGomb2.TabIndex = 2;
            MenuGomb2.Text = "Beállítások";
            MenuGomb2.UseVisualStyleBackColor = true;
            MenuGomb2.Click += MenuGomb2_Click;
            // 
            // MenuGomb1
            // 
            MenuGomb1.Cursor = Cursors.Hand;
            MenuGomb1.Location = new Point(0, 22);
            MenuGomb1.Name = "MenuGomb1";
            MenuGomb1.Size = new Size(127, 29);
            MenuGomb1.TabIndex = 0;
            MenuGomb1.Text = "Feladatok";
            MenuGomb1.UseVisualStyleBackColor = true;
            // 
            // MenuGomb
            // 
            MenuGomb.Image = (Image)resources.GetObject("MenuGomb.Image");
            MenuGomb.Location = new Point(12, 12);
            MenuGomb.Name = "MenuGomb";
            MenuGomb.Size = new Size(51, 52);
            MenuGomb.SizeMode = PictureBoxSizeMode.StretchImage;
            MenuGomb.TabIndex = 1;
            MenuGomb.TabStop = false;
            MenuGomb.Click += pictureBox1_Click;
            // 
            // idozit
            // 
            idozit.Interval = 10;
            idozit.Tick += idozit_Tick;
            // 
            // UdvLabel
            // 
            UdvLabel.AutoSize = true;
            UdvLabel.Location = new Point(344, 84);
            UdvLabel.Name = "UdvLabel";
            UdvLabel.Size = new Size(87, 20);
            UdvLabel.TabIndex = 2;
            UdvLabel.Text = "Üdvözöllek!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 157);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 3;
            label1.Text = "A mai nap: " + DateTime.Now.ToString("yyyy.MM.dd");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 403);
            Controls.Add(label1);
            Controls.Add(UdvLabel);
            Controls.Add(MenuGomb);
            Controls.Add(menuPanel);
            Name = "MainForm";
            Text = "ToDoApp";
            Load += Form1_Load;
            menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenuGomb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel menuPanel;
        private PictureBox MenuGomb;
        private System.Windows.Forms.Timer idozit;
        private Button MenuGomb2;
        private Button MenuGomb1;
        private Button MenuGomb3;
        private Label UdvLabel;
        private Label label1;
    }
}
