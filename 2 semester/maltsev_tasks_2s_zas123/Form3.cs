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
    public partial class fTask2 : Form
    {
        public fTask2()
        {
            InitializeComponent();
        }

        private void fTask2_Load(object sender, EventArgs e)
        {
            lab_Description.Text = "Описание задачи: " + Properties.Settings.Default.Task2Description;
            rtb_Text.Text = Properties.Settings.Default.Task2Text;
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

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            string texts;
            string[] words;
            int evens = 0;

            texts = rtb_Text.Text;
            texts = Regex.Replace(texts, "[-.?!)(,:#]", "");
            words = texts.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < words.Count(); i++)
            {
                if (words[i].Length % 2 == 0)
                {
                    evens++;
                }
            }

            string caption, message;

            if (evens == 0)
            {
                caption = "Задача не выполнена";
                message = "В приведенном тексте нет слов содержащих четное количество символов, замените текст и повторите еще раз...";
            }
            else
            {
                caption = "Задача выполнена";
                message = "В результате, после подсчета слов содержащих четное количество символов, обнаружено " + Convert.ToString(evens) + " слов/а с четным количеством символов.";
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icons = MessageBoxIcon.Information;

            MessageBox.Show(message, caption, buttons, icons);
        }
    }
}