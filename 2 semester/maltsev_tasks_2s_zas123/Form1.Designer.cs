namespace maltsev_tasks_2s_zas123
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.mstr_Main = new System.Windows.Forms.MenuStrip();
            this.tstrmi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrmi_Window = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrmi_TileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrmi_TileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrmi_Cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrmi_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstrmi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrmi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.sstr_Main = new System.Windows.Forms.StatusStrip();
            this.tstrsl_Main = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstr_Main = new System.Windows.Forms.ToolStrip();
            this.tstrb_Task1 = new System.Windows.Forms.ToolStripButton();
            this.tstrb_Task2 = new System.Windows.Forms.ToolStripButton();
            this.tstrb_Task3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mstr_Main.SuspendLayout();
            this.sstr_Main.SuspendLayout();
            this.tstr_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstr_Main
            // 
            this.mstr_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrmi_File,
            this.tstrmi_Window,
            this.tstrmi_Help});
            this.mstr_Main.Location = new System.Drawing.Point(0, 0);
            this.mstr_Main.MdiWindowListItem = this.tstrmi_Window;
            this.mstr_Main.Name = "mstr_Main";
            this.mstr_Main.Size = new System.Drawing.Size(921, 24);
            this.mstr_Main.TabIndex = 0;
            this.mstr_Main.Text = "menuStrip1";
            // 
            // tstrmi_File
            // 
            this.tstrmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrmi_Exit});
            this.tstrmi_File.MergeIndex = 0;
            this.tstrmi_File.Name = "tstrmi_File";
            this.tstrmi_File.Size = new System.Drawing.Size(48, 20);
            this.tstrmi_File.Text = "Файл";
            // 
            // tstrmi_Exit
            // 
            this.tstrmi_Exit.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.exit;
            this.tstrmi_Exit.Name = "tstrmi_Exit";
            this.tstrmi_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tstrmi_Exit.Size = new System.Drawing.Size(150, 22);
            this.tstrmi_Exit.Tag = "Выход из программы";
            this.tstrmi_Exit.Text = "Выход";
            this.tstrmi_Exit.Click += new System.EventHandler(this.tstrmi_Exit_Click);
            // 
            // tstrmi_Window
            // 
            this.tstrmi_Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrmi_TileHorizontal,
            this.tstrmi_TileVertical,
            this.tstrmi_Cascade,
            this.tstrmi_Separator1});
            this.tstrmi_Window.MergeIndex = 2;
            this.tstrmi_Window.Name = "tstrmi_Window";
            this.tstrmi_Window.Size = new System.Drawing.Size(48, 20);
            this.tstrmi_Window.Text = "Окно";
            // 
            // tstrmi_TileHorizontal
            // 
            this.tstrmi_TileHorizontal.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.tilehorizontal;
            this.tstrmi_TileHorizontal.Name = "tstrmi_TileHorizontal";
            this.tstrmi_TileHorizontal.Size = new System.Drawing.Size(158, 22);
            this.tstrmi_TileHorizontal.Tag = "Расположить окна горизонтально";
            this.tstrmi_TileHorizontal.Text = "Горизонтально";
            this.tstrmi_TileHorizontal.Click += new System.EventHandler(this.tstrmi_Horizontale_Click);
            // 
            // tstrmi_TileVertical
            // 
            this.tstrmi_TileVertical.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.tilevertical;
            this.tstrmi_TileVertical.Name = "tstrmi_TileVertical";
            this.tstrmi_TileVertical.Size = new System.Drawing.Size(158, 22);
            this.tstrmi_TileVertical.Tag = "Расположить окна вертикально";
            this.tstrmi_TileVertical.Text = "Вертикально";
            this.tstrmi_TileVertical.Click += new System.EventHandler(this.вертикальноToolStripMenuItem_Click);
            // 
            // tstrmi_Cascade
            // 
            this.tstrmi_Cascade.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.cascade;
            this.tstrmi_Cascade.Name = "tstrmi_Cascade";
            this.tstrmi_Cascade.Size = new System.Drawing.Size(158, 22);
            this.tstrmi_Cascade.Tag = "Расположить окна каскадом";
            this.tstrmi_Cascade.Text = "Каскадом";
            this.tstrmi_Cascade.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // tstrmi_Separator1
            // 
            this.tstrmi_Separator1.Name = "tstrmi_Separator1";
            this.tstrmi_Separator1.Size = new System.Drawing.Size(155, 6);
            // 
            // tstrmi_Help
            // 
            this.tstrmi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrmi_About});
            this.tstrmi_Help.MergeIndex = 3;
            this.tstrmi_Help.Name = "tstrmi_Help";
            this.tstrmi_Help.Size = new System.Drawing.Size(68, 20);
            this.tstrmi_Help.Text = "Помощь";
            // 
            // tstrmi_About
            // 
            this.tstrmi_About.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.about1;
            this.tstrmi_About.Name = "tstrmi_About";
            this.tstrmi_About.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tstrmi_About.Size = new System.Drawing.Size(168, 22);
            this.tstrmi_About.Tag = "Информация о программе";
            this.tstrmi_About.Text = "О программе";
            this.tstrmi_About.Click += new System.EventHandler(this.tstrmi_About_Click);
            // 
            // sstr_Main
            // 
            this.sstr_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrsl_Main});
            this.sstr_Main.Location = new System.Drawing.Point(0, 368);
            this.sstr_Main.Name = "sstr_Main";
            this.sstr_Main.ShowItemToolTips = true;
            this.sstr_Main.Size = new System.Drawing.Size(921, 22);
            this.sstr_Main.TabIndex = 1;
            this.sstr_Main.Text = "statusStrip1";
            // 
            // tstrsl_Main
            // 
            this.tstrsl_Main.Name = "tstrsl_Main";
            this.tstrsl_Main.Size = new System.Drawing.Size(64, 17);
            this.tstrsl_Main.Text = "tstrsl_Main";
            // 
            // tstr_Main
            // 
            this.tstr_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrb_Task1,
            this.tstrb_Task2,
            this.tstrb_Task3,
            this.toolStripButton1});
            this.tstr_Main.Location = new System.Drawing.Point(0, 24);
            this.tstr_Main.Name = "tstr_Main";
            this.tstr_Main.Size = new System.Drawing.Size(921, 25);
            this.tstr_Main.TabIndex = 2;
            this.tstr_Main.Tag = "jkshdkasdhaksh";
            this.tstr_Main.Text = "toolStrip1";
            // 
            // tstrb_Task1
            // 
            this.tstrb_Task1.AutoToolTip = false;
            this.tstrb_Task1.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.documents;
            this.tstrb_Task1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrb_Task1.Name = "tstrb_Task1";
            this.tstrb_Task1.Size = new System.Drawing.Size(74, 22);
            this.tstrb_Task1.Tag = "Решение задачи № 1";
            this.tstrb_Task1.Text = "Задача 1";
            this.tstrb_Task1.Click += new System.EventHandler(this.tstrb_Task1_Click);
            // 
            // tstrb_Task2
            // 
            this.tstrb_Task2.AutoToolTip = false;
            this.tstrb_Task2.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.documents;
            this.tstrb_Task2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrb_Task2.Name = "tstrb_Task2";
            this.tstrb_Task2.Size = new System.Drawing.Size(74, 22);
            this.tstrb_Task2.Tag = "Решение задачи № 2";
            this.tstrb_Task2.Text = "Задача 2";
            this.tstrb_Task2.Click += new System.EventHandler(this.tstrb_Task2_Click);
            // 
            // tstrb_Task3
            // 
            this.tstrb_Task3.AutoToolTip = false;
            this.tstrb_Task3.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.documents;
            this.tstrb_Task3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstrb_Task3.Name = "tstrb_Task3";
            this.tstrb_Task3.Size = new System.Drawing.Size(74, 22);
            this.tstrb_Task3.Tag = "Решение задачи № 3";
            this.tstrb_Task3.Text = "Задача 3";
            this.tstrb_Task3.Click += new System.EventHandler(this.tstrb_Task3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.documents;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton1.Tag = "Решение курсовой задачи";
            this.toolStripButton1.Text = "Курсовая";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 390);
            this.Controls.Add(this.tstr_Main);
            this.Controls.Add(this.sstr_Main);
            this.Controls.Add(this.mstr_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstr_Main;
            this.Name = "fMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.mstr_Main.ResumeLayout(false);
            this.mstr_Main.PerformLayout();
            this.sstr_Main.ResumeLayout(false);
            this.sstr_Main.PerformLayout();
            this.tstr_Main.ResumeLayout(false);
            this.tstr_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstr_Main;
        private System.Windows.Forms.ToolStripMenuItem tstrmi_File;
        private System.Windows.Forms.ToolStripMenuItem tstrmi_Exit;
        private System.Windows.Forms.ToolStripMenuItem tstrmi_Help;
        private System.Windows.Forms.ToolStripMenuItem tstrmi_About;
        private System.Windows.Forms.ToolStrip tstr_Main;
        private System.Windows.Forms.ToolStripButton tstrb_Task2;
        private System.Windows.Forms.ToolStripButton tstrb_Task3;
        private System.Windows.Forms.StatusStrip sstr_Main;
        private System.Windows.Forms.ToolStripStatusLabel tstrsl_Main;
        private System.Windows.Forms.ToolStripMenuItem tstrmi_Window;
        private System.Windows.Forms.ToolStripMenuItem tstrmi_TileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tstrmi_TileVertical;
        private System.Windows.Forms.ToolStripSeparator tstrmi_Separator1;
        private System.Windows.Forms.ToolStripMenuItem tstrmi_Cascade;
        private System.Windows.Forms.ToolStripButton tstrb_Task1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

