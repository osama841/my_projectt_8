using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = text_all.Text.Length.ToString();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (text_all.SelectedText.Length > 0)
            {
                textBox2.Text = text_all.SelectionLength.ToString();
            }
            else
            {
                MessageBox.Show("قم بي تحديد النص");
                textBox2.Text = "";

            }
        }
        string str;
        private void button10_Click(object sender, EventArgs e)
        {

            //string[] str;
            //str = text_all.Text.Trim().Split(' ');
            //textBox3.Text=(str.Length -1).ToString();
            str = text_all.Text;
            string[] arstr = str.Split(' ');
            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                    textBox3.Text = count.ToString();
                }
            }

        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (text_all.SelectionLength > 0)
            {
                text_all.SelectedText = "";
            }
            else
            {
                MessageBox.Show("قم بي تحديد النص");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            text_all.SelectionLength = 0;
        }
        string mytext;
        private void button13_Click(object sender, EventArgs e)
        {
            mytext = text_all.SelectedText;
        }

        /// <summary>
        /// التكليف النشاط
        /// </summary>
        private string[] cutHistory = new string[10];
        private int currentIndex = 0; 
        private void button14_Click(object sender, EventArgs e)
        {
            if (text_all.SelectedText.Length > 0)
            {
                // إضافة النص المقتطع إلى المصفوفة
                cutHistory[currentIndex] = text_all.SelectedText;

                // تحديث المؤشر إلى العنصر التالي
                currentIndex = (currentIndex + 1) % cutHistory.Length;  // لضمان العودة إلى البداية عند الوصول إلى الحد الأقصى

                // تنفيذ عملية القص
                text_all.Cut();
            }
               
            //if (text_all.SelectedText.Length > 0)
            //{

            //    text_all.Cut();
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = cutHistory.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(cutHistory[i]))  // إذا كان هناك نص مضاف في هذه الخانة
                {
                    // استرجاع النص المقطوع
                    text_all.SelectedText = cutHistory[i];

                    // مسح النص من المصفوفة بعد التراجع عنه
                    cutHistory[i] = null;
                    break;  // التوقف عند أول نص موجود
                }
            }
            //if (text_all.CanUndo)
            //{
            //    text_all.Undo();
            //}
        }
        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(mytext.Trim());
        }
        private void button16_Click(object sender, EventArgs e)
        {
            text_all.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < text_all.Text.Length; i++)
            {
                if (text_all.Text[i] != ' ')
                {
                    x++;
                }
                MessageBox.Show(x.ToString());
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < text_all.SelectedText.Length; i++)
            {
                if (text_all.Text[i] != ' ')
                {
                    x++;
                }
                MessageBox.Show(x.ToString());
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (text_all.SelectionLength > 0)
            {
                if (textBox5.Text.Trim() != "")
                {
                    text_all.SelectedText = textBox5.Text;

                }
                else
                {
                    MessageBox.Show("ادخل النص الجديد");
                }
            }
            else
            {
                MessageBox.Show(" ادخل النص المرد حذفه");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textserch.Text.Trim() != "")
            {
                int index = text_all.Text.IndexOf(textserch.Text, 0);
                if (index > -1)
                {
                    text_all.SelectionStart = index;
                    text_all.SelectionLength = textserch.Text.Length;

                    //  text_all.Select(index, textserch.Text.Length);
                    text_all.Focus();
                }
                else
                {
                    MessageBox.Show("not fond");
                }
            }
            else
            {
                MessageBox.Show("ادخل النص المراد حذفة");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textserch.Text))
            {
                int startIndex = 0;
                int index = text_all.Text.IndexOf(textserch.Text, startIndex);

                // تحقق إذا كانت الكلمة موجودة
                if (index > -1)
                {
                    // تحديد النص المدخل في text_all
                    text_all.Focus();
                    text_all.Select(index, textserch.Text.Length);

                    // احصل على النص بعد الكلمة المدخلة
                    string remainingText = text_all.Text.Substring(index + textserch.Text.Length).Trim();
   
                    // احصل على الكلمة الأولى من النص المتبقي
                    string[] words = remainingText.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 0)
                    {
                        MessageBox.Show("الكلمة التالية هي: " + words[0]);
                    }
                    else
                    {
                        MessageBox.Show("لا توجد كلمة بعد الكلمة المدخلة.");
                    }
                }
                else
                {
                    MessageBox.Show("النص غير موجود.");
                }
            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنه.");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

}