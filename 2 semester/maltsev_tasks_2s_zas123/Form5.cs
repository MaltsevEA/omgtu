using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace maltsev_tasks_2s_zas123
{
    public partial class fCProject : Form
    {
        public fCProject()
        {
            InitializeComponent();
        }

        private void fCProject_Load(object sender, EventArgs e)
        {
            lab_Description.Text = "Описание задачи: " + Properties.Settings.Default.Task4Description;
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {            
            rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Запуск");
            rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Проверяем число " + Convert.ToString(nUD_Number.Value) + " на простоту с помощью решета Эратосфена");

            int[] s = new int[Convert.ToInt32(nUD_Number.Value) + 1];
            s[1] = 0;

            Stopwatch st = new Stopwatch();

            st.Start();

            for (int k = 2; k <= nUD_Number.Value; k++)
            {
                s[k] = 1;
            }

            for (int k = 2; k * k <= nUD_Number.Value; k++)
            {
                if (s[k] == 1)
                {
                    for (int l = k * k; l <= nUD_Number.Value; l += k)
                    {
                        s[l] = 0;
                    }
                }
            }

            long result1, result2;

            st.Stop();

            result1 = st.ElapsedMilliseconds;
                       
            rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] Затрачено {1} м.с.\r\n", DateTime.Now, result1);

            if (s[Convert.ToInt32(nUD_Number.Value)] == 1)
            {
                rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Результат: число " + Convert.ToString(nUD_Number.Value) + " простое");
            } else
            {
                rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Результат: число " + Convert.ToString(nUD_Number.Value) + " не простое");
            }

            rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Проверяем число " + Convert.ToString(nUD_Number.Value) + " на простоту с помощью перебора делителей");

            st.Reset();
            st.Start();

            Boolean flag = true;

            if (nUD_Number.Value != 1)
            {
                for (int d = 2; d * d <= nUD_Number.Value; d++)
                {
                    if (nUD_Number.Value % d == 0)
                    {
                        flag = false;
                        break;
                    }
                 }
            }
            else
            {
               flag = false;
            }

            st.Stop();

            result2 = st.ElapsedMilliseconds;

            rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] Затрачено {1} м.с.\r\n", DateTime.Now, result2);

            if (flag)
            {
               rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Результат: число " + Convert.ToString(nUD_Number.Value) + " простое");
            } 
            else
            {
               rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Результат: число " + Convert.ToString(nUD_Number.Value) + " не простое");
            }

            rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Завершение");

            if ((result1 != 0) || (result2 != 0))
            {
                if (result1 > result2) 
                {
                    rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Оптимальным алгоритмом является алгоритм - Перебор делителей");
                } else 
                {
                    rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Оптимальным алгоритмом является алгоритм - Решето Эратосфена ");
                }
            }
            else 
            {
                rtb_Text.Text += string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, "Сравнение алгоритмов невозможно, проверки происходят очень быстро. Введите новое число и повторите вычисления.");
            }

            rtb_Text.SelectionStart = rtb_Text.TextLength;
            rtb_Text.ScrollToCaret();
        }
    }
}

