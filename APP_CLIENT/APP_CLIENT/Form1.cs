using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_CLIENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            try
            {
                // выводим отладку в форму 
                Debugging debugging = new Debugging();
                string[] otladka = debugging.considers();
                //------------- Заполнение полей -------------------------

                textBox25.Text = otladka[0];
                textBox11.Text = otladka[1];
                textBox12.Text = otladka[2];
                textBox13.Text = otladka[3];
                textBox14.Text = otladka[4];
                textBox15.Text = otladka[5];
                textBox16.Text = otladka[6];
                textBox17.Text = otladka[7];
                textBox18.Text = otladka[8];
                textBox19.Text = otladka[9];
                textBox20.Text = otladka[10];
                textBox21.Text = otladka[11];
                textBox22.Text = otladka[12];
                textBox23.Text = otladka[13];
                textBox24.Text = otladka[14];

                checkBox1.Checked = Convert.ToBoolean(otladka[15]);
                checkBox2.Checked = Convert.ToBoolean(otladka[16]);
                checkBox3.Checked = Convert.ToBoolean(otladka[17]);
                checkBox4.Checked = Convert.ToBoolean(otladka[18]);
                checkBox5.Checked = Convert.ToBoolean(otladka[19]);
                checkBox6.Checked = Convert.ToBoolean(otladka[20]);
                checkBox7.Checked = Convert.ToBoolean(otladka[21]);
                checkBox8.Checked = Convert.ToBoolean(otladka[22]);
                checkBox9.Checked = Convert.ToBoolean(otladka[23]);
                checkBox10.Checked = Convert.ToBoolean(otladka[24]);
                checkBox11.Checked = Convert.ToBoolean(otladka[25]);
                checkBox12.Checked = Convert.ToBoolean(otladka[26]);
                checkBox13.Checked = Convert.ToBoolean(otladka[27]);
                checkBox14.Checked = Convert.ToBoolean(otladka[28]);

            }
            catch(Exception)
            {                
                string caption = "Ошибка !";
                string message = "Не удаётся прочитать файл отладки !";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            try
            {
                // выводим настройки в форму 
                Setting setting = new Setting();
                string[] nastroiki = setting.Considers();

                //------------- Заполнение полей -------------------------
                textBox1.Text = nastroiki[0];
                textBox2.Text = nastroiki[1];
                textBox3.Text = nastroiki[2];
                textBox4.Text = nastroiki[3];
                textBox5.Text = nastroiki[4];
                textBox6.Text = nastroiki[5];
                textBox7.Text = nastroiki[6];
                textBox8.Text = nastroiki[7];
                textBox9.Text = nastroiki[8];
                textBox10.Text = nastroiki[9];
                textBox26.Text = nastroiki[10];
                textBox27.Text = nastroiki[11];
                textBox28.Text = nastroiki[12];
                textBox29.Text = nastroiki[13];

                checkBox23.Checked = Convert.ToBoolean(nastroiki[14]);
                checkBox20.Checked = Convert.ToBoolean(nastroiki[15]);
                checkBox19.Checked = Convert.ToBoolean(nastroiki[16]);
                checkBox18.Checked = Convert.ToBoolean(nastroiki[17]);
                checkBox22.Checked = Convert.ToBoolean(nastroiki[18]);
                checkBox17.Checked = Convert.ToBoolean(nastroiki[19]);
                checkBox21.Checked = Convert.ToBoolean(nastroiki[20]);
                checkBox30.Checked = Convert.ToBoolean(nastroiki[21]);
                checkBox28.Checked = Convert.ToBoolean(nastroiki[22]);
                checkBox27.Checked = Convert.ToBoolean(nastroiki[22]);
                checkBox26.Checked = Convert.ToBoolean(nastroiki[23]);
                checkBox25.Checked = Convert.ToBoolean(nastroiki[24]);
                checkBox29.Checked = Convert.ToBoolean(nastroiki[25]);
                checkBox24.Checked = Convert.ToBoolean(nastroiki[26]);

            }
            catch(Exception)
            {
                string caption = "Ошибка !";
                string message = "Не удаётся прочитать файл с настройками !";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            Awesomium.Core.WebCore.ClearCookies();
       
            webControl1.LoadURL(textBox25.Text);
        }

        private void webControl1_OpenExternalLink(object sender, Awesomium.Core.OpenExternalLinkEventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // сохраняем данные из отладки класса            
            try
            {
                Debugging debugging = new Debugging();
                debugging.save(textBox25.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text,
                    textBox16.Text, textBox17.Text, textBox18.Text, textBox19.Text, textBox20.Text, textBox21.Text, textBox22.Text,
                    textBox23.Text, textBox24.Text, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked,
                    checkBox5.Checked, checkBox6.Checked, checkBox7.Checked, checkBox8.Checked, checkBox9.Checked, checkBox10.Checked,
                    checkBox11.Checked, checkBox12.Checked, checkBox13.Checked, checkBox14.Checked);
                label31.Visible = true;
            }
            catch (Exception)
            {
                label31.Visible = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // сохраняем данные из настроек класса
           
            try{

                Setting setting = new Setting();
                setting.Save(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, int.Parse(textBox6.Text),
                 textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox26.Text, textBox27.Text, textBox28.Text, textBox29.Text,
                 checkBox23.Checked, checkBox20.Checked, checkBox19.Checked, checkBox18.Checked, checkBox22.Checked, checkBox17.Checked,
                 checkBox21.Checked, checkBox30.Checked, checkBox28.Checked, checkBox27.Checked, checkBox26.Checked, checkBox25.Checked,
                 checkBox29.Checked, checkBox24.Checked);
                label30.Visible = true;
            } catch (Exception)
            {
                label30.Visible = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Close();               
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            label30.Visible = false;
            label31.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox1.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text+"/?"+textBox11.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox2.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox12.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox3.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox13.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox4.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox14.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox5.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox15.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox6.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox16.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox7.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox17.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox8.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox18.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox9.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox19.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox10.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox20.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox11.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox21.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox12.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox22.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox13.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox23.Text);
            }
            else
            {
                // Post запрос

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // обрабатываем запрос 1
            if (checkBox21.Checked == true)
            {
                Awesomium.Core.WebCore.ClearCookies();
                Awesomium.Core.WebCore.SetCookie("http://" + textBox25.Text, "; domain=" + textBox25.Text, true, true);
            }

            // переключаем запросы
            if (checkBox14.Checked == false)
            {
                // Get запрос
                webControl1.LoadURL("http://" + textBox25.Text + "/?" + textBox24.Text);
            }
            else
            {
                // Post запрос

            }
        }
    }
}
