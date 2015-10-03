namespace maltsev_tasks_2s_zas123
{
    partial class fTask2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTask2));
            this.rtb_Text = new System.Windows.Forms.RichTextBox();
            this.pan_Bottom = new System.Windows.Forms.Panel();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.lab_Description = new System.Windows.Forms.Label();
            this.pan_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Text
            // 
            this.rtb_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Text.Location = new System.Drawing.Point(0, 0);
            this.rtb_Text.Name = "rtb_Text";
            this.rtb_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_Text.Size = new System.Drawing.Size(1008, 330);
            this.rtb_Text.TabIndex = 4;
            this.rtb_Text.Text = "";
            this.rtb_Text.TextChanged += new System.EventHandler(this.rtb_Start_TextChanged);
            // 
            // pan_Bottom
            // 
            this.pan_Bottom.Controls.Add(this.btn_Execute);
            this.pan_Bottom.Controls.Add(this.lab_Description);
            this.pan_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Bottom.Location = new System.Drawing.Point(0, 330);
            this.pan_Bottom.Name = "pan_Bottom";
            this.pan_Bottom.Size = new System.Drawing.Size(1008, 60);
            this.pan_Bottom.TabIndex = 3;
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
            this.lab_Description.Size = new System.Drawing.Size(886, 37);
            this.lab_Description.TabIndex = 0;
            this.lab_Description.Text = "label1";
            // 
            // fTask2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 390);
            this.Controls.Add(this.rtb_Text);
            this.Controls.Add(this.pan_Bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTask2";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.fTask2_Load);
            this.pan_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Text;
        private System.Windows.Forms.Panel pan_Bottom;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Label lab_Description;
    }
}