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
            this.components = new System.ComponentModel.Container();
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
            this.decryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateAKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metod1E = new System.Windows.Forms.ToolStripMenuItem();
            this.metod2E = new System.Windows.Forms.ToolStripMenuItem();
            this.metod3E = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metod1D = new System.Windows.Forms.ToolStripMenuItem();
            this.metod2D = new System.Windows.Forms.ToolStripMenuItem();
            this.metod3D = new System.Windows.Forms.ToolStripMenuItem();
            this.MetodStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.encryption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.metodToolStripMenuItem,
            this.startToolStripMenuItem});
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
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            resources.ApplyResources(this.encryptionToolStripMenuItem, "encryptionToolStripMenuItem");
            this.encryptionToolStripMenuItem.Click += new System.EventHandler(this.encryptionToolStripMenuItem_Click);
            // 
            // decryptionToolStripMenuItem
            // 
            this.decryptionToolStripMenuItem.Name = "decryptionToolStripMenuItem";
            resources.ApplyResources(this.decryptionToolStripMenuItem, "decryptionToolStripMenuItem");
            this.decryptionToolStripMenuItem.Click += new System.EventHandler(this.decryptionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MetodStatus});
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
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Name = "label2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ContextMenuStrip = this.contextMenuStrip4;
            this.label3.Name = "label3";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateAKeyToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // generateAKeyToolStripMenuItem
            // 
            this.generateAKeyToolStripMenuItem.Name = "generateAKeyToolStripMenuItem";
            resources.ApplyResources(this.generateAKeyToolStripMenuItem, "generateAKeyToolStripMenuItem");
            this.generateAKeyToolStripMenuItem.Click += new System.EventHandler(this.generateAKeyToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metod1E,
            this.metod2E,
            this.metod3E});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // metod1E
            // 
            this.metod1E.CheckOnClick = true;
            this.metod1E.Name = "metod1E";
            resources.ApplyResources(this.metod1E, "metod1E");
            this.metod1E.Click += new System.EventHandler(this.metod1E_Click);
            // 
            // metod2E
            // 
            this.metod2E.CheckOnClick = true;
            this.metod2E.Name = "metod2E";
            resources.ApplyResources(this.metod2E, "metod2E");
            this.metod2E.Click += new System.EventHandler(this.metod2E_Click);
            // 
            // metod3E
            // 
            this.metod3E.CheckOnClick = true;
            this.metod3E.Name = "metod3E";
            resources.ApplyResources(this.metod3E, "metod3E");
            this.metod3E.Click += new System.EventHandler(this.metod3E_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metod1D,
            this.metod2D,
            this.metod3D});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            resources.ApplyResources(this.contextMenuStrip3, "contextMenuStrip3");
            // 
            // metod1D
            // 
            this.metod1D.CheckOnClick = true;
            this.metod1D.DoubleClickEnabled = true;
            this.metod1D.Name = "metod1D";
            resources.ApplyResources(this.metod1D, "metod1D");
            this.metod1D.Click += new System.EventHandler(this.metod1D_Click);
            // 
            // metod2D
            // 
            this.metod2D.CheckOnClick = true;
            this.metod2D.DoubleClickEnabled = true;
            this.metod2D.Name = "metod2D";
            resources.ApplyResources(this.metod2D, "metod2D");
            this.metod2D.Click += new System.EventHandler(this.metod2D_Click);
            // 
            // metod3D
            // 
            this.metod3D.CheckOnClick = true;
            this.metod3D.DoubleClickEnabled = true;
            this.metod3D.Name = "metod3D";
            resources.ApplyResources(this.metod3D, "metod3D");
            this.metod3D.Click += new System.EventHandler(this.metod3D_Click);
            // 
            // MetodStatus
            // 
            this.MetodStatus.ActiveLinkColor = System.Drawing.Color.Black;
            this.MetodStatus.Name = "MetodStatus";
            resources.ApplyResources(this.MetodStatus, "MetodStatus");
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryption});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            resources.ApplyResources(this.contextMenuStrip4, "contextMenuStrip4");
            // 
            // encryption
            // 
            this.encryption.Name = "encryption";
            resources.ApplyResources(this.encryption, "encryption");
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem decryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem allSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateAKeyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem metod1E;
        private System.Windows.Forms.ToolStripMenuItem metod2E;
        private System.Windows.Forms.ToolStripMenuItem metod3E;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem metod1D;
        private System.Windows.Forms.ToolStripMenuItem metod2D;
        private System.Windows.Forms.ToolStripMenuItem metod3D;
        private System.Windows.Forms.ToolStripStatusLabel MetodStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem encryption;

    }
}

