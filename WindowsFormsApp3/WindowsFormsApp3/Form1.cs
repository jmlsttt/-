using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet1.Выдача_книг". При необходимости она может быть перемещена или удалена.
            this.выдача_книгTableAdapter.Fill(this.библиотекаDataSet1.Выдача_книг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.библиотекаDataSet.Книги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            книгиTableAdapter.Update(библиотекаDataSet);
            выдача_книгTableAdapter.Update(библиотекаDataSet1);
        }

    }
}
