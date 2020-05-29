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
using T = ShutDownAPP.TimeSpanUtil;


namespace ShutDownAPP
{
    public partial class Form1 : Form
    {
        Process cmdProcess = new Process();
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        public void stopShutdown_Click(object sender, EventArgs e)
        {
            cmdProcess.StartInfo.Arguments = "-a";
            cmdProcess.StartInfo.FileName = "shutdown";
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.Start();

            MessageBox.Show("Foi cancelado com sucesso!");
        }

        private void startShutdown_Click(object sender, EventArgs e)
        {
            string[] vars = new string[4];
            string horas = numericUpDown1.Value.ToString();
            string minutos = numericUpDown2.Value.ToString();
            string segundos = numericUpDown3.Value.ToString();

            int valor1 = Convert.ToInt32(horas), valor2 = Convert.ToInt32(minutos), valor3 = Convert.ToInt32(segundos);
            string strv1 = RetornaHoras(valor1), strv2 = RetornaMinutos(valor2), strv3 = RetornaSegundos(valor3);
            valor1 = Convert.ToInt32(strv1); valor2 = Convert.ToInt32(strv2); valor3 = Convert.ToInt32(strv3);
            int valor = valor1 + valor2 + valor3;
            string conc = string.Format("{0}", valor);
            foreach (Control rdbutton in this.groupBox1.Controls)
            {
                if (rdbutton.GetType().ToString() == "System.Windows.Forms.RadioButton")
                {
                    if (((RadioButton)rdbutton).Checked == true)
                    {
                        if (rdbutton.Name == "radioButton1")
                        {
                            vars[0] = "-s"; vars[1] = "-f"; vars[2] = "-t";
                        }
                        if (rdbutton.Name == "radioButton2")
                        {
                            vars[0] = "-r"; vars[1] = "-f"; vars[2] = "-t";
                        }
                        if (rdbutton.Name == "radioButton3")
                        {
                            vars[0] = "-l"; vars[1] = vars[2] = null;
                        }
                    }
                }
            }

            Func_Desl(vars[0], vars[1], vars[2], T.ConvertMillisecondsToSeconds(valor));
        }
        private void Func_Desl(string var1, string var2, string var3, double val)
        {
            cmdProcess.StartInfo.Arguments = var1 + " " + var2 + " " + var3 + " " + val;
            cmdProcess.StartInfo.FileName = "shutdown";
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.Start();
        }
        public string RetornaHoras(int h)
        {
            string horas = String.Format("{0}", (1000 * h * 60 * 60));
            return horas;
        }
        public string RetornaMinutos(int m)
        {
            string minutos = String.Format("{0}", (1000 * m * 60));
            return minutos;
        }
        public string RetornaSegundos(int s)
        {
            string segundos = String.Format("{0}", (1000 * s));
            return segundos;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }
    }
    public static class TimeSpanUtil
    {
        public static double ConvertMillisecondsToSeconds(double milliseconds)
        {
            return TimeSpan.FromMilliseconds(milliseconds).TotalSeconds;
        }
    }
}
