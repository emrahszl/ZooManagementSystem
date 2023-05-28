namespace ZooManagementSystem
{
    partial class MainPage
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
            hayvanİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            çalışanİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            hayvanEkleToolStripMenuItem = new ToolStripMenuItem();
            hayvanGüncelleToolStripMenuItem = new ToolStripMenuItem();
            hayvanSilToolStripMenuItem = new ToolStripMenuItem();
            çalışanEkleToolStripMenuItem = new ToolStripMenuItem();
            çalışanGüncelleToolStripMenuItem = new ToolStripMenuItem();
            çalışanSilToolStripMenuItem = new ToolStripMenuItem();
            dgvEmployees = new DataGridView();
            dgvAnimals = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pbMain = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hayvanİşlemleriToolStripMenuItem, çalışanİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(767, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hayvanİşlemleriToolStripMenuItem
            // 
            hayvanİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hayvanEkleToolStripMenuItem, hayvanGüncelleToolStripMenuItem, hayvanSilToolStripMenuItem });
            hayvanİşlemleriToolStripMenuItem.Name = "hayvanİşlemleriToolStripMenuItem";
            hayvanİşlemleriToolStripMenuItem.Size = new Size(106, 19);
            hayvanİşlemleriToolStripMenuItem.Text = "Hayvan İşlemleri";
            // 
            // çalışanİşlemleriToolStripMenuItem
            // 
            çalışanİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çalışanEkleToolStripMenuItem, çalışanGüncelleToolStripMenuItem, çalışanSilToolStripMenuItem });
            çalışanİşlemleriToolStripMenuItem.Name = "çalışanİşlemleriToolStripMenuItem";
            çalışanİşlemleriToolStripMenuItem.Size = new Size(104, 19);
            çalışanİşlemleriToolStripMenuItem.Text = "Çalışan İşlemleri";
            // 
            // hayvanEkleToolStripMenuItem
            // 
            hayvanEkleToolStripMenuItem.Name = "hayvanEkleToolStripMenuItem";
            hayvanEkleToolStripMenuItem.Size = new Size(180, 22);
            hayvanEkleToolStripMenuItem.Text = "Hayvan Ekle";
            // 
            // hayvanGüncelleToolStripMenuItem
            // 
            hayvanGüncelleToolStripMenuItem.Name = "hayvanGüncelleToolStripMenuItem";
            hayvanGüncelleToolStripMenuItem.Size = new Size(180, 22);
            hayvanGüncelleToolStripMenuItem.Text = "Hayvan Güncelle";
            // 
            // hayvanSilToolStripMenuItem
            // 
            hayvanSilToolStripMenuItem.Name = "hayvanSilToolStripMenuItem";
            hayvanSilToolStripMenuItem.Size = new Size(180, 22);
            hayvanSilToolStripMenuItem.Text = "Hayvan Sil";
            // 
            // çalışanEkleToolStripMenuItem
            // 
            çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            çalışanEkleToolStripMenuItem.Size = new Size(180, 22);
            çalışanEkleToolStripMenuItem.Text = "Çalışan Ekle";
            // 
            // çalışanGüncelleToolStripMenuItem
            // 
            çalışanGüncelleToolStripMenuItem.Name = "çalışanGüncelleToolStripMenuItem";
            çalışanGüncelleToolStripMenuItem.Size = new Size(180, 22);
            çalışanGüncelleToolStripMenuItem.Text = "Çalışan Güncelle";
            // 
            // çalışanSilToolStripMenuItem
            // 
            çalışanSilToolStripMenuItem.Name = "çalışanSilToolStripMenuItem";
            çalışanSilToolStripMenuItem.Size = new Size(180, 22);
            çalışanSilToolStripMenuItem.Text = "Çalışan Sil";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(386, 272);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowTemplate.Height = 25;
            dgvEmployees.Size = new Size(368, 176);
            dgvEmployees.TabIndex = 1;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(12, 272);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowTemplate.Height = 25;
            dgvAnimals.Size = new Size(368, 176);
            dgvAnimals.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 206);
            label1.Name = "label1";
            label1.Size = new Size(743, 30);
            label1.TabIndex = 2;
            label1.Text = "Hayvanat bahçesi yönetim sistemine hoşgeldiniz.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 248);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 3;
            label2.Text = "Hayvanlar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 248);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 3;
            label3.Text = "Çalışanlar";
            // 
            // pbMain
            // 
            pbMain.Image = Properties.Resources._396;
            pbMain.Location = new Point(12, 54);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(742, 139);
            pbMain.SizeMode = PictureBoxSizeMode.Zoom;
            pbMain.TabIndex = 4;
            pbMain.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 460);
            Controls.Add(pbMain);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAnimals);
            Controls.Add(dgvEmployees);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainPage";
            Text = "Ana Sayfa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hayvanİşlemleriToolStripMenuItem;
        private ToolStripMenuItem hayvanEkleToolStripMenuItem;
        private ToolStripMenuItem hayvanGüncelleToolStripMenuItem;
        private ToolStripMenuItem hayvanSilToolStripMenuItem;
        private ToolStripMenuItem çalışanİşlemleriToolStripMenuItem;
        private ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private ToolStripMenuItem çalışanGüncelleToolStripMenuItem;
        private ToolStripMenuItem çalışanSilToolStripMenuItem;
        private DataGridView dgvEmployees;
        private DataGridView dgvAnimals;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pbMain;
    }
}