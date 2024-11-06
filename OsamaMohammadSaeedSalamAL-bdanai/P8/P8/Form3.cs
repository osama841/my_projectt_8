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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string mytext;
        string[] words;
        string  selectedWord;

      
      

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (listBox3.SelectedItem !=null) // تحقق من أن هناك عنصر محدد
            {
                mytext = listBox3.SelectedItem.ToString(); // الحصول على النص المحدد
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

      
            // لنفترض أنك تريد تحديد الكلمة التي تنقر عليها
            // يمكنك استخدام قائمة الكلمات وتحديد الكلمة التي تريدها
            // words = selectedText.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // عوضًا عن استخدام index ثابت، يمكنك تنفيذ منطق لتحديد الكلمة بناءً على النقر
            //    // مثال: تحديد أول كلمة
            //    if (words.Length > 0)
            //    {
            //        MessageBox.Show("الكلمة المحددة هي: " + words[0]); // عرض أول كلمة كمثال
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("يرجى تحديد عنصر من القائمة."); // رسالة للمستخدم في حال عدم تحديد عنصر
            //}

            //             
        }
        private void button6_Click(object sender, EventArgs e)
        {

            //if (!string.IsNullOrWhiteSpace(mytext)) // تحقق من أن mytext ليس فارغًا
            //{ 

            listBox1.Items.Add(mytext); // إضافة النص إلى listBox3
            // }
        }
    }
}
