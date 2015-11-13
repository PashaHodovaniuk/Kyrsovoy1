namespace Kyrsovoy
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metod1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metod2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metod3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metod1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metod2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metod3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.metodToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveImageToolStripMenuItem,
            this.saveKeyToolStripMenuItem,
            this.allSaveToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            resources.ApplyResources(this.openImageToolStripMenuItem, "openImageToolStripMenuItem");
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.DoubleClickEnabled = true;
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            resources.ApplyResources(this.saveImageToolStripMenuItem, "saveImageToolStripMenuItem");
            // 
            // saveKeyToolStripMenuItem
            // 
            this.saveKeyToolStripMenuItem.Name = "saveKeyToolStripMenuItem";
            resources.ApplyResources(this.saveKeyToolStripMenuItem, "saveKeyToolStripMenuItem");
            // 
            // allSaveToolStripMenuItem
            // 
            this.allSaveToolStripMenuItem.Name = "allSaveToolStripMenuItem";
            resources.ApplyResources(this.allSaveToolStripMenuItem, "allSaveToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // metodToolStripMenuItem
            // 
            this.metodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptionToolStripMenuItem,
            this.decryptionToolStripMenuItem});
            this.metodToolStripMenuItem.Name = "metodToolStripMenuItem";
            resources.ApplyResources(this.metodToolStripMenuItem, "metodToolStripMenuItem");
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metod1ToolStripMenuItem,
            this.metod2ToolStripMenuItem,
            this.metod3ToolStripMenuItem});
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            resources.ApplyResources(this.encryptionToolStripMenuItem, "encryptionToolStripMenuItem");
            // 
            // metod1ToolStripMenuItem
            // 
            this.metod1ToolStripMenuItem.Name = "metod1ToolStripMenuItem";
            resources.ApplyResources(this.metod1ToolStripMenuItem, "metod1ToolStripMenuItem");
            // 
            // metod2ToolStripMenuItem
            // 
            this.metod2ToolStripMenuItem.Name = "metod2ToolStripMenuItem";
            resources.ApplyResources(this.metod2ToolStripMenuItem, "metod2ToolStripMenuItem");
            // 
            // metod3ToolStripMenuItem
            // 
            this.metod3ToolStripMenuItem.Name = "metod3ToolStripMenuItem";
            resources.ApplyResources(this.metod3ToolStripMenuItem, "metod3ToolStripMenuItem");
            // 
            // decryptionToolStripMenuItem
            // 
            this.decryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metod1ToolStripMenuItem1,
            this.metod2ToolStripMenuItem1,
            this.metod3ToolStripMenuItem1});
            this.decryptionToolStripMenuItem.Name = "decryptionToolStripMenuItem";
            resources.ApplyResources(this.decryptionToolStripMenuItem, "decryptionToolStripMenuItem");
            // 
            // metod1ToolStripMenuItem1
            // 
            this.metod1ToolStripMenuItem1.Name = "metod1ToolStripMenuItem1";
            resources.ApplyResources(this.metod1ToolStripMenuItem1, "metod1ToolStripMenuItem1");
            // 
            // metod2ToolStripMenuItem1
            // 
            this.metod2ToolStripMenuItem1.Name = "metod2ToolStripMenuItem1";
            resources.ApplyResources(this.metod2ToolStripMenuItem1, "metod2ToolStripMenuItem1");
            // 
            // metod3ToolStripMenuItem1
            // 
            this.metod3ToolStripMenuItem1.Name = "metod3ToolStripMenuItem1";
            resources.ApplyResources(this.metod3ToolStripMenuItem1, "metod3ToolStripMenuItem1");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metod1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metod2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metod3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metod1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem metod2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem metod3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem allSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

