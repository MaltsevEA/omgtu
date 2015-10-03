namespace maltsev_tasks_2s_zas123
{
    partial class fCProject
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
            this.rtb_Text = new System.Windows.Forms.RichTextBox();
            this.pan_Bottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nUD_Number = new System.Windows.Forms.NumericUpDown();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.lab_Description = new System.Windows.Forms.Label();
            this.pan_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Number)).BeginInit();
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
            this.rtb_Text.TabIndex = 8;
            this.rtb_Text.Text = "";
            // 
            // pan_Bottom
            // 
            this.pan_Bottom.Controls.Add(this.label1);
            this.pan_Bottom.Controls.Add(this.nUD_Number);
            this.pan_Bottom.Controls.Add(this.btn_Execute);
            this.pan_Bottom.Controls.Add(this.lab_Description);
            this.pan_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Bottom.Location = new System.Drawing.Point(0, 330);
            this.pan_Bottom.Name = "pan_Bottom";
            this.pan_Bottom.Size = new System.Drawing.Size(1008, 60);
            this.pan_Bottom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число";
            // 
            // nUD_Number
            // 
            this.nUD_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUD_Number.Location = new System.Drawing.Point(830, 10);
            this.nUD_Number.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUD_Number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Number.Name = "nUD_Number";
            this.nUD_Number.Size = new System.Drawing.Size(68, 20);
            this.nUD_Number.TabIndex = 2;
            this.nUD_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_Number.Value = new decimal(new int[] {
            1,
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
            // fCProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 390);
            this.Controls.Add(this.rtb_Text);
            this.Controls.Add(this.pan_Bottom);
            this.Name = "fCProject";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.fCProject_Load);
            this.pan_Bottom.ResumeLayout(false);
            this.pan_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Number)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Text;
        private System.Windows.Forms.Panel pan_Bottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUD_Number;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Label lab_Description;

    }
}