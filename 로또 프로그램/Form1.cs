using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 로또_프로그램
{
    public partial class Form1 : Form
    {

        List<string> list = new List<string>();

        Random random = new Random();
        int[] number = new int[7];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e) // 번호 생성
        {

            int b=0;
            
            MessageBox.Show("로또추첨을 시작합니다.");
            int a;

            for (int i = 0; i < number.Length; i++)
            {
                a = random.Next() % 45 + 1; // 1~45
                if (true == Check(i, a))
                {
                    number[i] = a;
                }
                else
                {
                    i--;
                }
            }

            num1.Text = number[0].ToString();
            num2.Text = number[1].ToString();
            num3.Text = number[2].ToString();
            num4.Text = number[3].ToString();
            num5.Text = number[4].ToString();
            num6.Text = number[5].ToString();
            bonus.Text = number[6].ToString();

            MessageBox.Show("결과값을 생성합니다.");

            for (int k = 0; k < number.Length; k++)
            {
                b = number[k];
            }
        }

        private bool Check(int index, int value)
        {

            for (int i = 0; i < index; i++)
            {
                if (value == number[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e) // 번호 저장
        {

                list.Add(user1.Text.ToString());
                list.Add(user2.Text.ToString());
                list.Add(user3.Text.ToString());
                list.Add(user4.Text.ToString());
                list.Add(user5.Text.ToString());
                list.Add(user6.Text.ToString());


                foreach (var test in list)
                {
                    user_num_save.Text += test + "      ";
                }
        }

        private void button3_Click(object sender, EventArgs e) // 결과보기
        {

        }
    }
}