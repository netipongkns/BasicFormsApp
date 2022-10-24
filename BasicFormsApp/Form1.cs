using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //string str = "ตัวแปรระดับฟอร์ม";
        
        private void Form1_Load(object sender, EventArgs e)
        {
           // String str = "Local Variable";
           // lbLocal1.Text = str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // lbLocal2.Text = str;
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            
            var a = "1";
            var b = 2;
            var c = 3.23;
            //show variable
            //const ค่าคงที่
            MessageBox.Show("a = " + a.GetType().ToString() + Environment.NewLine
                           + "b = " + b.GetType().ToString() + Environment.NewLine
                           + "c = " + c.GetType().ToString() + Environment.NewLine, "ชนิดข้อมูล");
            (int ID, string Name) person = (1,"Netipong");
            //โชว์อีก 1 หน้าต่าง
            MessageBox.Show(person.ID.ToString() +" "+ person.Name,"ตัวแปร 2 ค่า");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String FullName;
            FullName = "Netipong Kaewsri";
            MessageBox.Show(FullName.Length.ToString(), "จำนวนตัวอักษร"); //นับตัวอักษร = 16





        }
    }
}
