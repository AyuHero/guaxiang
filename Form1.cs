using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] d = { "000000", "000001", "000010", "000011", "000100", "000101", "000110", "000111", "001000", "001001", "001010", "001011", "001100", "001101", "001110", "001111", "010000", "010001", "010010", "010011", "010100", "010101", "010110", "010111", "011000", "011001", "011010", "011011", "011100", "011101", "011110", "011111", "100000", "100001", "100010", "100011", "100100", "100101", "100110", "100111", "101000", "101001", "101010", "101011", "101100", "101101", "101110", "101111", "110000", "110001", "110010", "110011", "110100", "110101","110110", "110111", "111000", "111001", "111010", "111011", "111100", "111101", "111110", "111111",  };
        private string[] f = { "地为坤", "地雷复", "地水师", "地泽临", "地山谦", "地火明夷", "地风升", "地天泰", "雷地豫", "震为雷", "雷水解", "雷泽归妹", "雷山小过", "雷火丰", "雷风恒", "雷天大壮", "水地比", "水雷屯", "坎为水", "水泽节", "水山蹇", "水火既济", "水风井", "水天需", "泽地萃", "泽雷随", "泽水困", "兑为泽", "泽山咸", "泽火革", "泽风大过", "泽天央", "山地剥", "山雷颐", "山水蒙", "山泽损", "艮为山", "山火贲", "山风蛊", "山天大畜", "火地晋", "火雷噬嗑", "火水未济", "火泽瞬", "火山旅", "离为火", "火风鼎", "火天大有", "风地观", "风雷益", "风水涣", "风泽中孚", "风山渐", "风火家人", "翼为风", "风天小畜", "天地否", "天雷无妄", "天水讼", "天泽履", "天山遁", "天火同人", "天风始", "乾为天", };
        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            string[] b = new string[6];
            string c = "";
            for (int i = 0; i < 6; i++)
            {
                string a =  rd.Next(0,2).ToString();
                if (a == "1")
                {
                    b[i] = "---";
                    System.Threading.Thread.Sleep(10);
                }
                if (a == "0")
                {
                    b[i] = "- -";
                    System.Threading.Thread.Sleep(10);
                }

                c += a;
            }
            l1.Text = b[0];
            l2.Text = b[1];
            l3.Text = b[2];
            l4.Text = b[3];
            l5.Text = b[4];
            l6.Text = b[5];

            int ia = 0;
            int ib = 0;
            for (ia = 0; ia < 64; ia++)
            {
                if (c == d[ia])
                {
                    ib = ia;
                    break;
                }
            }
            label1.Text = f[ib];




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void l6_Click(object sender, EventArgs e)
        {

        }
    }
}
