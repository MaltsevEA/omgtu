using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace maltsev_tasks_2s_zas123
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            tstrsl_Main.Text = String.Empty;

            foreach (ToolStripItem stripbutton in tstr_Main.Items)
            {
                if (stripbutton.Tag is string)
                {
                    stripbutton.MouseEnter += new EventHandler(Items_MouseEnter);
                    stripbutton.MouseLeave += new EventHandler(Items_MouseLeave);
                }
            }

            foreach (ToolStripMenuItem mainitem in mstr_Main.Items)
            {
                foreach (ToolStripItem menuitem in mainitem.DropDownItems)
                {
                    if (menuitem.Tag is string)
                    {
                        menuitem.MouseEnter += new EventHandler(Items_MouseEnter);
                        menuitem.MouseLeave += new EventHandler(Items_MouseLeave);
                    }
                }
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("{0} ({1})", AssemblyTitle, AssemblyCompany);
        }

        private void Items_MouseEnter(object sender, EventArgs e)
        {
            if (sender is ToolStripButton)
            {
                tstrsl_Main.Text = (string)((ToolStripButton)sender).Tag;
            }

            if (sender is ToolStripMenuItem)
            {
                tstrsl_Main.Text = (string)((ToolStripMenuItem)sender).Tag;
            }
        }

        private void Items_MouseLeave(object sender, EventArgs e)
        {
            tstrsl_Main.Text = String.Empty;
        }

        private void tstrmi_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Вы согласны выйти из программы?";
            string caption = "Выход из программы...";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icons = MessageBoxIcon.Question;

            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icons);

            if (result == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void tstrmi_Horizontale_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void tstrb_Task1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fTask1"] == null)
            {
                fTask1 newMDIChild = new fTask1();
                newMDIChild.MdiParent = this;
                newMDIChild.Text = "Задача №1";
                newMDIChild.Show();
            }
            else
            {
                Application.OpenForms["fTask1"].BringToFront();
            }
        }

        private void tstrb_Task2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fTask2"] == null)
            {
                fTask2 newMDIChild = new fTask2();
                newMDIChild.MdiParent = this;
                newMDIChild.Text = "Задача №2";
                newMDIChild.Show();
            }
            else
            {
                Application.OpenForms["fTask2"].BringToFront();
            }
        }

        private void tstrb_Task3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fTask3"] == null)
            {
                fTask3 newMDIChild = new fTask3();
                newMDIChild.MdiParent = this;
                newMDIChild.Text = "Задача №3";
                newMDIChild.Show();
            }
            else
            {
                Application.OpenForms["fTask3"].BringToFront();
            }
        }

        private void tstrmi_About_Click(object sender, EventArgs e)
        {
            AboutBox AboutBoxForm = new AboutBox();
            AboutBoxForm.Show();
        }

        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fCProject"] == null)
            {
                fCProject newMDIChild = new fCProject();
                newMDIChild.MdiParent = this;
                newMDIChild.Text = "Курсовая задача";
                newMDIChild.Show();
            }
            else
            {
                Application.OpenForms["fTask3"].BringToFront();
            }            
        }
    }
}
