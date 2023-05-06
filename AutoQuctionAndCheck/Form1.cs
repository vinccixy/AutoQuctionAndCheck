using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoQuctionAndCheck {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int num1 = 10;//算术最大可取值
        int rule_ = 1;//加减乘除法则
        //自动出题
        private void timer1_Tick(object sender, EventArgs e) {
            //判断是否勾选了自动出题按钮,是则自动出题
            if (AntoNext_check.Checked) {
                string title = TitleInput();
                if (AntoResult_Check.Checked) {
                    ResultOutput(title);
                    //result_tbx.Click += Result_tbx_Click;
                } else {
                    result_tbx.Text = "";
                    while(AntoResult_Check.Checked){
                        if (Next_btn.Enabled) {
                            break;
                        }
                        ResultOutput(title);
                       // result_tbx.Click += Result_tbx_Click;
                    }
                }

            }
        }

       

        //选择10内的加减算法
        private void radio_10_CheckedChanged(object sender, EventArgs e) {
            //随机数最大可取10 法则为+-
            num1 = 10;
            rule_ = 1;
        }
        //选择100内的加减算法
        private void radio_100_CheckedChanged(object sender, EventArgs e) {
            num1 = 100;
            rule_ = 1;
        }
        //选择乘法100内
        private void multi_radio_CheckedChanged(object sender, EventArgs e) {
            num1 = 100;
            rule_ = 2;
        }
        //出题
        string TitleInput() {
            Random rnd = new Random();
            int numA = rnd.Next(num1);
            int numB = rnd.Next(num1);
            int rul = rnd.Next(0, rule_);
            string rule = "";
            if (rul == 0) {
                rule = "-";
            } else if (rule_ == 1) {
                rule = "+";
            } 
            if (multi_radio.Checked) {
                    rule = "*";
            }
            string title = numA + rule + numB;
            quection_tbx.Text = title;
            return title;
        }
        int result_out = 0;
        //出答案
        void ResultOutput(string title) {
            result_out = 0;
            if (title.Contains("+")) {
                string[] nums = title.Split('+');
                result_out = int.Parse(nums[0]) + int.Parse(nums[1]);
            } else if (title.Contains("-")) {
                string[] nums = title.Split('-');
                result_out = int.Parse(nums[0]) - int.Parse(nums[1]);
            } else if (title.Contains("*")) {
                string[] nums = title.Split('*');
                result_out = int.Parse(nums[0]) * int.Parse(nums[1]);
            }
            if (result_tbx.Text==result_out.ToString()) {
                result_tbx.ForeColor = Color.Green;
            }else {
                result_tbx.ForeColor = Color.Blue;
            }
            result_tbx.Text = result_out.ToString();
        }

        private void Result_tbx_Click(object sender, EventArgs e) {
           TextBox box =sender as TextBox;
            // throw new NotImplementedException();
            if (box.Text != result_out.ToString()) {
                box.ForeColor = Color.Red;
            }
            box.Text = result_out.ToString();
        }

        private void Next_btn_Click(object sender, EventArgs e) {
            result_tbx.Text = "";
            string title = TitleInput();
            if (AntoResult_Check.Checked) {
                ResultOutput(title);
            } 
            else {
                result_tbx.Text = "";
                while (AntoResult_Check.Checked) {
                    if (Next_btn.Enabled) {
                        break;
                    }
                    ResultOutput(title);
                }
            }
        }

        private void quick_btn_Click(object sender, EventArgs e) {
            timer1.Interval = 500;
        }

        private void slow_btn_Click(object sender, EventArgs e) {
            timer1.Interval = 500 * 3;
        }

        //自动出答案按钮
        private void AntoResult_Check_CheckedChanged(object sender, EventArgs e) {
            if (!AntoResult_Check.Checked) {
                result_tbx.Text = "";
            }
            else {
                if (result_tbx.Text == result_out.ToString()) {
                   
                    result_tbx.ForeColor = Color.Green;
                }
                result_tbx.Text = result_out.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
