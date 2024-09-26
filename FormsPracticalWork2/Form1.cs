using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPracticalWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            Admin admin1 = new Admin();
            Admin admin2 = new Admin(1, "admin", "admin", "admin", 3);
            Admin admin3 = new Admin(admin2);
            string xd = $"Класс Администраторов и демонстрация метода Print():\n" +
                $"Конструктор без параметров: {admin1.Print()}\n" +
                $"Конструктор с параметрами: {admin2.Print()}\n" +
                $"Конструктор копирования: {admin3.Print()}\n\n" +
                $"Демонтрация метода Access(): {admin2.Access()}";
            listBox1.Items.AddRange(xd.Split('\n'));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Anon anon1 = new Anon();
            Anon anon2 = new Anon(0, "1login1", "1password1", "Anonimous", "111.111.111.111");
            Anon anon3 = new Anon(anon2);
            string xd = $"Класс Администраторов и демонстрация метода Print():\n" +
                $"Конструктор без параметров: {anon1.Print()}\n" +
                $"Конструктор с параметрами: {anon2.Print()}\n" +
                $"Конструктор копирования: {anon3.Print()}\n\n" +
                $"Демонтрация метода WhereFrom(): {anon2.WhereFrom()}";
            listBox1.Items.AddRange(xd.Split('\n'));
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Customer customer1 = new Customer();
            Customer customer2 = new Customer(1321, "Destroyer1288", "ilikeStarWars", "RegularUser", "My life goes on");
            Customer customer3 = new Customer(customer2);
            string xd = $"Класс Администраторов и демонстрация метода Print():\n" +
                $"Конструктор без параметров: {customer1.Print()}\n" +
                $"Конструктор с параметрами: {customer2.Print()}\n" +
                $"Конструктор копирования: {customer3.Print()}\n\n" +
                $"Демонтрация метода NameQuote(): {customer2.NameQuote()}";
            listBox1.Items.AddRange(xd.Split('\n'));
        }
    }
}
