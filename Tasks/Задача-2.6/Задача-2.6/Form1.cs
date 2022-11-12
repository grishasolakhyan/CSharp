using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace calculator
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    char znak;
    string a;
    string b;
    bool pomnish = false;
    private void button9_Click(object sender, EventArgs e)
    {
        textBox1.Text += "3";
    }
    private void button3_Click(object sender, EventArgs e)
    {
        textBox1.Text += "7";
    }
    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text += "1";
    }
    private void button6_Click(object sender, EventArgs e)
    {
        textBox1.Text += "2";
    }
    private void button2_Click(object sender, EventArgs e)
    {
        textBox1.Text += "4";
    }
    private void button5_Click(object sender, EventArgs e)
    {
        textBox1.Text += "5";
    }
    private void button8_Click(object sender, EventArgs e)
    {
        textBox1.Text += "6";
    }
    private void button4_Click(object sender, EventArgs e)
    {
        textBox1.Text += "8";
    }
    private void button7_Click(object sender, EventArgs e)
    {
        textBox1.Text += "9";
    }
    private void button18_Click(object sender, EventArgs e)
    {
        textBox1.Text += "0";
    }
    private void button16_Click(object sender, EventArgs e)
    {
        textBox1.Text += '.';
    }
    private void button14_Click(object sender, EventArgs e)
    {
        string rez = "";
        byte i = 0;
        while (i < textBox1.Text.Length - 1) 
        {
            rez += textBox1.Text[i];
            i++;
        }
        textBox1.Text = rez; 
    }
    private void button11_Click(object sender, EventArgs e)
    {
        if (pomnish) { schitaem(); }
        znak = '*';
        a = textBox1.Text;
        textBox1.Text += "*";
        pomnish = true;
    }
    private void button15_Click(object sender, EventArgs e)
    {
        if (pomnish) { schitaem(); }
        znak = '-';
        a = textBox1.Text;
        textBox1.Text += "-";
        pomnish = true;
    }
    private void button10_Click(object sender, EventArgs e)
    {
        if (pomnish) { schitaem(); }
        znak = '+';
        a = textBox1.Text;
        textBox1.Text += "+";
        pomnish = true;
    }
    private void button12_Click(object sender, EventArgs e)
    {
        if (pomnish) { schitaem(); }
        znak = '/';
        a = textBox1.Text;
        textBox1.Text += "/";
        pomnish = true;
    }
    private void button17_Click(object sender, EventArgs e)
    {
        schitaem();
        pomnish = false;
    }
    public void schitaem()
    {
        int i = a.Length + 1;
        while (i < textBox1.Text.Length)
        {
            b += textBox1.Text[i];
            i++;
        }
        if (znak == '+') { textBox1.Text = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b)); }
        if (znak == '-') { textBox1.Text = Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(b)); }
        if (znak == '*') { textBox1.Text = Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b)); }
        if (znak == '/') { textBox1.Text = Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(b)); }
        b = null;
    }
    private void button13_Click(object sender, EventArgs e)
    {
        textBox1.Text = null;
        pomnish = false;
    }
}
}
