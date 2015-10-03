using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace maltsev_tasks_2s_zas123
{
    public partial class fTask3 : Form
    {
        public fTask3()
        {
            InitializeComponent();
        }

        private void fTask3_Load(object sender, EventArgs e)
        {
            lab_Description.Text = "Описание задачи: " + Properties.Settings.Default.Task3Description;
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            string fileNameF = "sample.txt";

            using (FileStream fs = new FileStream(fileNameF, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.Default))
                {
                    writer.Write(Properties.Settings.Default.Task3Text);
                }
            }

            rtb_Text.LoadFile(fileNameF, RichTextBoxStreamType.PlainText);

            string texts;
            string[] offers;
            char[] offersSeparators = new char[] { '.' };

            texts = rtb_Text.Text;
            offers = texts.Split(offersSeparators, StringSplitOptions.RemoveEmptyEntries);

            int[] wordArray = new int[offers.Length];

            string text;
            string[] word;
            int count = 0;

            for (int i = 0; i < offers.Length; i++)
            {
                text = Regex.Replace(offers[i], "[-.?!)(,:#]", "");
                word = text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

                wordArray[i] = 0;
                
                for(int x = 0; x < word.Count(); x++)
                {
                    if (word[x].Length == nUD_Count.Value)
                    {
                        wordArray[i]++;
                        count++;
                    }

                }
            }

            if (count != 0)
            {
                count = 0;

                for (int i = 0; i < offers.Count(); i++)
                {
                    if (wordArray[i] == wordArray.Max())
                    {
                        if (count == 0)
                        {
                            rtb_Text.Text = offers[i] + ".";
                        }
                        else
                        {
                            rtb_Text.Text = rtb_Text.Text + offers[i] + ".";
                        }

                        count++;
                    }
                }
            }
            
            string fileNameG = "result.txt";

            using (FileStream fs = new FileStream(fileNameG, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.Default))
                {
                    writer.Write(rtb_Text.Text);
                }
            }

            string caption, message;

            if (count == 0)
            {
                caption = "Задача не выполнена";
                message = "В приведенном тексте нет слов содержащих указанное количество символов, измените колличество символов и повторите еще раз...";
            }
            else
            {
                caption = "Задача выполнена";
                message = "В результате, после подсчета слов содержащих указанное количество символов, обнаружено " + Convert.ToString(count) + " предложений с максимальным колличеством слов состоящих из заданного количества символов.";
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icons = MessageBoxIcon.Information;

            MessageBox.Show(message, caption, buttons, icons);
        }
    }
}
