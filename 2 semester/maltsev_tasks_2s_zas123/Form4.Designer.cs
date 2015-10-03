namespace maltsev_tasks_2s_zas123
{
    partial class fTask3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTask3));
            this.rtb_Text = new System.Windows.Forms.RichTextBox();
            this.pan_Bottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nUD_Count = new System.Windows.Forms.NumericUpDown();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.lab_Description = new System.Windows.Forms.Label();
            this.oFD_RtfFile = new System.Windows.Forms.OpenFileDialog();
            this.sFD_RtfFile = new System.Windows.Forms.SaveFileDialog();
            this.pan_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_Text
            // 
            this.rtb_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Text.Location = new System.Drawing.Point(0, 0);
            this.rtb_Text.Name = "rtb_Text";
            this.rtb_Text.ReadOnly = true;
            this.rtb_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_Text.Size = new System.Drawing.Size(1008, 330);
            this.rtb_Text.TabIndex = 6;
            this.rtb_Text.Text = "";
            // 
            // pan_Bottom
            // 
            this.pan_Bottom.Controls.Add(this.label1);
            this.pan_Bottom.Controls.Add(this.nUD_Count);
            this.pan_Bottom.Controls.Add(this.btn_Execute);
            this.pan_Bottom.Controls.Add(this.lab_Description);
            this.pan_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Bottom.Location = new System.Drawing.Point(0, 330);
            this.pan_Bottom.Name = "pan_Bottom";
            this.pan_Bottom.Size = new System.Drawing.Size(1008, 60);
            this.pan_Bottom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во симв.";
            // 
            // nUD_Count
            // 
            this.nUD_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUD_Count.Location = new System.Drawing.Point(851, 10);
            this.nUD_Count.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUD_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Count.Name = "nUD_Count";
            this.nUD_Count.Size = new System.Drawing.Size(47, 20);
            this.nUD_Count.TabIndex = 2;
            this.nUD_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_Count.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btn_Execute
            // 
            this.btn_Execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Execute.Image = global::maltsev_tasks_2s_zas123.Properties.Resources.apply;
            this.btn_Execute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Execute.Location = new System.Drawing.Point(904, 6);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(92, 28);
            this.btn_Execute.TabIndex = 1;
            this.btn_Execute.Text = "Выполнить";
            this.btn_Execute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // lab_Description
            // 
            this.lab_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Description.Location = new System.Drawing.Point(12, 14);
            this.lab_Description.Name = "lab_Description";
            this.lab_Description.Size = new System.Drawing.Size(754, 37);
            this.lab_Description.TabIndex = 0;
            this.lab_Description.Text = "label1";
            // 
            // oFD_RtfFile
            // 
            this.oFD_RtfFile.DefaultExt = "txt";
            this.oFD_RtfFile.FileName = "sample.txt";
            this.oFD_RtfFile.Filter = "Файл в формате TXT|*.txt";
            this.oFD_RtfFile.Title = "Открытий текстового файла";
            // 
            // sFD_RtfFile
            // 
            this.sFD_RtfFile.DefaultExt = "txt";
            this.sFD_RtfFile.FileName = "result.txt";
            this.sFD_RtfFile.Filter = "Файл в формате TXT|*.txt";
            this.sFD_RtfFile.Title = "Сохранение текстового файла";
            // 
            // fTask3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 390);
            this.Controls.Add(this.rtb_Text);
            this.Controls.Add(this.pan_Bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTask3";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.fTask3_Load);
            this.pan_Bottom.ResumeLayout(false);
            this.pan_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Text;
        private System.Windows.Forms.Panel pan_Bottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUD_Count;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Label lab_Description;
        private System.Windows.Forms.OpenFileDialog oFD_RtfFile;
        private System.Windows.Forms.SaveFileDialog sFD_RtfFile;
    }
}