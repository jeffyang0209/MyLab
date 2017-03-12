using System;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double height = Convert.ToDouble(textBox2.Text);
            double kg = Convert.ToDouble(textBox3.Text);
            bool sex = checkBox1.Checked;

            Humanity humanity = new Humanity(name, height, kg, sex);
            // 取得BMI並且設定健康狀態
            humanity.SetHealthStatus(new Calculator(humanity).GetBMI());

            MessageBox.Show($"{name}現在的健康狀態為：{humanity.Health}");
        }
    }
}
