namespace Manager2
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
            this.view = new System.Windows.Forms.ListView();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.перейменуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.створитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.папкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.поділитиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.BackButton = new System.Windows.Forms.Button();
            this.adressView = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.папкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.українськаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            resources.ApplyResources(this.view, "view");
            this.view.ContextMenuStrip = this.ContextMenu;
            this.view.Name = "view";
            this.view.UseCompatibleStateImageBehavior = false;
            this.view.DoubleClick += new System.EventHandler(this.view_DoubleClick);
            this.view.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.view_KeyPress);
            // 
            // ContextMenu
            // 
            resources.ApplyResources(this.ContextMenu, "ContextMenu");
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.перейменуватиToolStripMenuItem,
            this.toolStripSeparator1,
            this.створитиToolStripMenuItem1,
            this.toolStripSeparator2,
            this.поділитиФайлToolStripMenuItem,
            this.створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // перейменуватиToolStripMenuItem
            // 
            resources.ApplyResources(this.перейменуватиToolStripMenuItem, "перейменуватиToolStripMenuItem");
            this.перейменуватиToolStripMenuItem.Name = "перейменуватиToolStripMenuItem";
            this.перейменуватиToolStripMenuItem.Click += new System.EventHandler(this.перейменуватиToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // створитиToolStripMenuItem1
            // 
            resources.ApplyResources(this.створитиToolStripMenuItem1, "створитиToolStripMenuItem1");
            this.створитиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem3,
            this.папкуToolStripMenuItem1});
            this.створитиToolStripMenuItem1.Name = "створитиToolStripMenuItem1";
            // 
            // файлToolStripMenuItem3
            // 
            resources.ApplyResources(this.файлToolStripMenuItem3, "файлToolStripMenuItem3");
            this.файлToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem1,
            this.htmlToolStripMenuItem1});
            this.файлToolStripMenuItem3.Name = "файлToolStripMenuItem3";
            // 
            // txtToolStripMenuItem1
            // 
            resources.ApplyResources(this.txtToolStripMenuItem1, "txtToolStripMenuItem1");
            this.txtToolStripMenuItem1.Name = "txtToolStripMenuItem1";
            this.txtToolStripMenuItem1.Click += new System.EventHandler(this.txtToolStripMenuItem1_Click);
            // 
            // htmlToolStripMenuItem1
            // 
            resources.ApplyResources(this.htmlToolStripMenuItem1, "htmlToolStripMenuItem1");
            this.htmlToolStripMenuItem1.Name = "htmlToolStripMenuItem1";
            this.htmlToolStripMenuItem1.Click += new System.EventHandler(this.htmlToolStripMenuItem1_Click);
            // 
            // папкуToolStripMenuItem1
            // 
            resources.ApplyResources(this.папкуToolStripMenuItem1, "папкуToolStripMenuItem1");
            this.папкуToolStripMenuItem1.Name = "папкуToolStripMenuItem1";
            this.папкуToolStripMenuItem1.Click += new System.EventHandler(this.папкуToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // поділитиФайлToolStripMenuItem
            // 
            resources.ApplyResources(this.поділитиФайлToolStripMenuItem, "поділитиФайлToolStripMenuItem");
            this.поділитиФайлToolStripMenuItem.Name = "поділитиФайлToolStripMenuItem";
            this.поділитиФайлToolStripMenuItem.Click += new System.EventHandler(this.поділитиФайлToolStripMenuItem_Click);
            // 
            // створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem
            // 
            resources.ApplyResources(this.створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem, "створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem");
            this.створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem.Name = "створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem";
            this.створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem.Click += new System.EventHandler(this.створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem_Click);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "Folder.png");
            this.images.Images.SetKeyName(1, "Hard-Drive.png");
            this.images.Images.SetKeyName(2, "Notepad.png");
            this.images.Images.SetKeyName(3, "InDesignCS2.png");
            this.images.Images.SetKeyName(4, "Wrench.png");
            this.images.Images.SetKeyName(5, "Word-Processor.png");
            this.images.Images.SetKeyName(6, "Chrome.png");
            this.images.Images.SetKeyName(7, "Zip.png");
            // 
            // BackButton
            // 
            resources.ApplyResources(this.BackButton, "BackButton");
            this.BackButton.Name = "BackButton";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // adressView
            // 
            resources.ApplyResources(this.adressView, "adressView");
            this.adressView.Name = "adressView";
            this.adressView.ReadOnly = true;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.файлToolStripMenuItem,
            this.моваToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem1
            // 
            resources.ApplyResources(this.файлToolStripMenuItem1, "файлToolStripMenuItem1");
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиToolStripMenuItem});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            // 
            // створитиToolStripMenuItem
            // 
            resources.ApplyResources(this.створитиToolStripMenuItem, "створитиToolStripMenuItem");
            this.створитиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem2,
            this.папкуToolStripMenuItem});
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            // 
            // файлToolStripMenuItem2
            // 
            resources.ApplyResources(this.файлToolStripMenuItem2, "файлToolStripMenuItem2");
            this.файлToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem,
            this.htmlToolStripMenuItem});
            this.файлToolStripMenuItem2.Name = "файлToolStripMenuItem2";
            // 
            // txtToolStripMenuItem
            // 
            resources.ApplyResources(this.txtToolStripMenuItem, "txtToolStripMenuItem");
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
            // 
            // htmlToolStripMenuItem
            // 
            resources.ApplyResources(this.htmlToolStripMenuItem, "htmlToolStripMenuItem");
            this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
            this.htmlToolStripMenuItem.Click += new System.EventHandler(this.htmlToolStripMenuItem_Click);
            // 
            // папкуToolStripMenuItem
            // 
            resources.ApplyResources(this.папкуToolStripMenuItem, "папкуToolStripMenuItem");
            this.папкуToolStripMenuItem.Name = "папкуToolStripMenuItem";
            this.папкуToolStripMenuItem.Click += new System.EventHandler(this.папкуToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копіюватиToolStripMenuItem,
            this.вставитиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            // 
            // копіюватиToolStripMenuItem
            // 
            resources.ApplyResources(this.копіюватиToolStripMenuItem, "копіюватиToolStripMenuItem");
            this.копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            this.копіюватиToolStripMenuItem.Click += new System.EventHandler(this.копіюватиToolStripMenuItem_Click);
            // 
            // вставитиToolStripMenuItem
            // 
            resources.ApplyResources(this.вставитиToolStripMenuItem, "вставитиToolStripMenuItem");
            this.вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            this.вставитиToolStripMenuItem.Click += new System.EventHandler(this.вставитиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            resources.ApplyResources(this.видалитиToolStripMenuItem, "видалитиToolStripMenuItem");
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // моваToolStripMenuItem
            // 
            resources.ApplyResources(this.моваToolStripMenuItem, "моваToolStripMenuItem");
            this.моваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.українськаToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.моваToolStripMenuItem.Name = "моваToolStripMenuItem";
            // 
            // українськаToolStripMenuItem
            // 
            resources.ApplyResources(this.українськаToolStripMenuItem, "українськаToolStripMenuItem");
            this.українськаToolStripMenuItem.Name = "українськаToolStripMenuItem";
            this.українськаToolStripMenuItem.Click += new System.EventHandler(this.українськаToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.adressView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.view);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.ListView view;
        private System.Windows.Forms.ListView view;
        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox adressView;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem українськаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem папкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem папкуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem перейменуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem поділитиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem;
    }
}

