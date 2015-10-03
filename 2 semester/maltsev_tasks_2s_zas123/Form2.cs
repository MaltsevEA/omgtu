using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace maltsev_tasks_2s_zas123
{
    public partial class fTask1 : Form
    {
        public fTask1()
        {
            InitializeComponent();
        }

        private void fTask1_Load(object sender, EventArgs e)
        {
            lab_Description.Text = "Описание задачи: " + Properties.Settings.Default.Task1Description;
            rtb_Text.Text = Properties.Settings.Default.Task1Text;
        }

        private void but_Task1_Run_Click(object sender, EventArgs e)
        {
            string texts;
            string[] words;
            int wcount, rcount;

            texts = rtb_Text.Text;
            texts = Regex.Replace(texts, "[-.?!)(,:#]", "");
            words = texts.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            wcount = words.Count();
            words = words.Distinct().ToArray();
            rcount = words.Count();
            rtb_Text.Text = string.Join(" ", words);

            string caption, message;

            if (wcount == rcount)
            {
                caption = "Задача не выполнена";
                message = "В приведенном тексте нет повторяющихся слов, замените текст и повторите еще раз...";
            }
            else
            {
                caption = "Задача выполнена";
                message = "В результате, после удаление повторяющихся слов, количество слов с " + Convert.ToString(wcount) + " уменьшилось до " + Convert.ToString(rcount);
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icons = MessageBoxIcon.Information;

            MessageBox.Show(message, caption, buttons, icons);
        }

        private void rtb_Start_TextChanged(object sender, EventArgs e)
        {
            if (rtb_Text.Text == "")
            {
                btn_Execute.Enabled = false;
            }
            else
            {
                btn_Execute.Enabled = true;
            }
        }
    }
}
