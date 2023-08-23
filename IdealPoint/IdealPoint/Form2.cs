using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealPoint
{
    public partial class Form2 : Form
    {
        double[,] Norm = new double[4,6];
        double[] perfectdot = new double[5];
        double[,] Arr = new double[8,8];
        int elm;
        bool flag = false, flag2 = false, flag3 = false;

        public Form2()
        {
            InitializeComponent();
        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        { flag = true; }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { flag = true; }

        public void cerf(ManeForm maneForm)
        {
            label9.Text = maneForm.cashr[0];    label23.Text = maneForm.cashr[0];
            label10.Text = maneForm.cashr[1];   label22.Text = maneForm.cashr[1];
            label11.Text = maneForm.cashr[2];   label21.Text = maneForm.cashr[2];

            label29.Text = maneForm.cashl[0];
            label30.Text = maneForm.cashl[1];
            label31.Text = maneForm.cashl[2];
            label32.Text = maneForm.cashl[3];
            label33.Text = maneForm.cashl[4];

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        { flag = true; }

        private void button1_Click(object sender, EventArgs e)
        {
            Arr[0, 0] = double.Parse(textBox1.Text);   Arr[1, 0] = double.Parse(textBox9.Text);    Arr[2, 0] = double.Parse(textBox17.Text);//веса
            Arr[0, 1] = int.Parse(textBox2.Text);   Arr[1, 1] = int.Parse(textBox10.Text);   Arr[2, 1] = int.Parse(textBox18.Text);
            Arr[0, 2] = int.Parse(textBox3.Text);   Arr[1, 2] = int.Parse(textBox11.Text);   Arr[2, 2] = int.Parse(textBox19.Text);
            Arr[0, 3] = int.Parse(textBox4.Text);   Arr[1, 3] = int.Parse(textBox12.Text);   Arr[2, 3] = int.Parse(textBox20.Text);
            Arr[0, 4] = int.Parse(textBox5.Text);   Arr[1, 4] = int.Parse(textBox13.Text);   Arr[2, 4] = int.Parse(textBox21.Text);
            Arr[0, 5] = int.Parse(textBox6.Text);   Arr[1, 5] = int.Parse(textBox14.Text);   Arr[2, 5] = int.Parse(textBox22.Text);
            Arr[0, 6] = int.Parse(textBox7.Text);   Arr[1, 6] = int.Parse(textBox15.Text);   Arr[2, 6] = int.Parse(textBox23.Text);//max значения
            Arr[0, 7] = int.Parse(textBox8.Text);   Arr[1, 7] = int.Parse(textBox16.Text);   Arr[2, 7] = int.Parse(textBox24.Text);//min значения

            if(checkBox1.Checked == true)
            {
                Norm[0, 0] = (Arr[0, 6] - Arr[0, 1]) / (Arr[0, 6] - Arr[0, 7]);
                Norm[0, 1] = (Arr[0, 6] - Arr[0, 2]) / (Arr[0, 6] - Arr[0, 7]);
                Norm[0, 2] = (Arr[0, 6] - Arr[0, 3]) / (Arr[0, 6] - Arr[0, 7]);
                Norm[0, 3] = (Arr[0, 6] - Arr[0, 4]) / (Arr[0, 6] - Arr[0, 7]);
                Norm[0, 4] = (Arr[0, 6] - Arr[0, 5]) / (Arr[0, 6] - Arr[0, 7]);
            }
            else 
            {
                Norm[0, 0] = (Arr[0, 1] - Arr[0, 7]) / (Arr[0, 6] - Arr[0, 7]); 
                Norm[0, 1] = (Arr[0, 2] - Arr[0, 7]) / (Arr[0, 6] - Arr[0, 7]); 
                Norm[0, 2] = (Arr[0, 3] - Arr[0, 7]) / (Arr[0, 6] - Arr[0, 7]); 
                Norm[0, 3] = (Arr[0, 4] - Arr[0, 7]) / (Arr[0, 6] - Arr[0, 7]); 
                Norm[0, 4] = (Arr[0, 5] - Arr[0, 7]) / (Arr[0, 6] - Arr[0, 7]);
            }

            textBox30.Text = Norm[0, 0].ToString();
            textBox31.Text = Norm[0, 1].ToString();
            textBox32.Text = Norm[0, 2].ToString();
            textBox33.Text = Norm[0, 3].ToString();
            textBox34.Text = Norm[0, 4].ToString();


            if (checkBox2.Checked == true)
            {
                Norm[1, 0] = (Arr[1, 6] - Arr[1, 1]) / (Arr[1, 6] - Arr[1, 7]);
                Norm[1, 1] = (Arr[1, 6] - Arr[1, 2]) / (Arr[1, 6] - Arr[1, 7]);
                Norm[1, 2] = (Arr[1, 6] - Arr[1, 3]) / (Arr[1, 6] - Arr[1, 7]);
                Norm[1, 3] = (Arr[1, 6] - Arr[1, 4]) / (Arr[1, 6] - Arr[1, 7]);
                Norm[1, 4] = (Arr[1, 6] - Arr[1, 5]) / (Arr[1, 6] - Arr[1, 7]);
            }
            else
            {
                Norm[1, 0] = (Arr[1, 1] - Arr[1, 7]) / (Arr[1, 6] - Arr[1, 7]);
                Norm[1, 1] = (Arr[1, 2] - Arr[1, 7]) / (Arr[1, 6] - Arr[1, 7]);
                Norm[1, 2] = (Arr[1, 3] - Arr[1, 7]) / (Arr[1, 6] - Arr[1, 7]);
                Norm[1, 3] = (Arr[1, 4] - Arr[1, 7]) / (Arr[1, 6] - Arr[1, 7]);
                Norm[1, 4] = (Arr[1, 5] - Arr[1, 7]) / (Arr[1, 6] - Arr[1, 7]);
            }

            textBox35.Text = Norm[1, 0].ToString();
            textBox36.Text = Norm[1, 1].ToString();
            textBox37.Text = Norm[1, 2].ToString();
            textBox38.Text = Norm[1, 3].ToString();
            textBox39.Text = Norm[1, 4].ToString();

            if (checkBox3.Checked == true)
            {
                Norm[2, 0] = (Arr[2, 6] - Arr[2, 1]) / (Arr[2, 6] - Arr[2, 7]);
                Norm[2, 1] = (Arr[2, 6] - Arr[2, 2]) / (Arr[2, 6] - Arr[2, 7]);
                Norm[2, 2] = (Arr[2, 6] - Arr[2, 3]) / (Arr[2, 6] - Arr[2, 7]);
                Norm[2, 3] = (Arr[2, 6] - Arr[2, 4]) / (Arr[2, 6] - Arr[2, 7]);
                Norm[2, 4] = (Arr[2, 6] - Arr[2, 5]) / (Arr[2, 6] - Arr[2, 7]);
            }
            else
            {
                Norm[2, 0] = (Arr[2, 1] - Arr[2, 7]) / (Arr[2, 6] - Arr[2, 7]);
                Norm[2, 1] = (Arr[2, 2] - Arr[2, 7]) / (Arr[2, 6] - Arr[2, 7]);
                Norm[2, 2] = (Arr[2, 3] - Arr[2, 7]) / (Arr[2, 6] - Arr[2, 7]);
                Norm[2, 3] = (Arr[2, 4] - Arr[2, 7]) / (Arr[2, 6] - Arr[2, 7]);
                Norm[2, 4] = (Arr[2, 5] - Arr[2, 7]) / (Arr[2, 6] - Arr[2, 7]);
            }

            textBox40.Text = Norm[2, 0].ToString();
            textBox41.Text = Norm[2, 1].ToString();
            textBox42.Text = Norm[2, 2].ToString();
            textBox43.Text = Norm[2, 3].ToString();
            textBox44.Text = Norm[2, 4].ToString();

            perfectdot[0] = Math.Sqrt(Arr[0, 0] * Math.Pow(1 - Norm[0, 0], 2) + Arr[1, 0] * Math.Pow(1 - Norm[1, 0], 2) + Arr[2, 0] * Math.Pow(1 - Norm[2, 0], 2));
            perfectdot[1] = Math.Sqrt(Arr[0, 0] * Math.Pow(1 - Norm[0, 1], 2) + Arr[1, 0] * Math.Pow(1 - Norm[1, 1], 2) + Arr[2, 0] * Math.Pow(1 - Norm[2, 1], 2));
            perfectdot[2] = Math.Sqrt(Arr[0, 0] * Math.Pow(1 - Norm[0, 2], 2) + Arr[1, 0] * Math.Pow(1 - Norm[1, 2], 2) + Arr[2, 0] * Math.Pow(1 - Norm[2, 2], 2));
            perfectdot[3] = Math.Sqrt(Arr[0, 0] * Math.Pow(1 - Norm[0, 3], 2) + Arr[1, 0] * Math.Pow(1 - Norm[1, 3], 2) + Arr[2, 0] * Math.Pow(1 - Norm[2, 3], 2));
            perfectdot[4] = Math.Sqrt(Arr[0, 0] * Math.Pow(1 - Norm[0, 4], 2) + Arr[1, 0] * Math.Pow(1 - Norm[1, 4], 2) + Arr[2, 0] * Math.Pow(1 - Norm[2, 4], 2));


            textBox25.Text = perfectdot[0].ToString();
            textBox26.Text = perfectdot[1].ToString();
            textBox27.Text = perfectdot[2].ToString();
            textBox28.Text = perfectdot[3].ToString();
            textBox29.Text = perfectdot[4].ToString();

            double min = 1;
            int key = 0;
            for(int i = 0; i < 5; i++)
            {
                if (min > perfectdot[i])
                {
                    min = perfectdot[i];
                    key = i+1;
                }
            }
            label13.Text = "наилучшим объектом по результатам подсчета стал о" + System.Convert.ToString(key);





        }
        
    }
}
