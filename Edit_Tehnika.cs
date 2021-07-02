using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvetPerspectiva
{
    public partial class Edit_Tehnika : Form
    {
        public Edit_Tehnika()
        {
            InitializeComponent();
        }

        private void Edit_Tehnika_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invetPerspectivaDataSet.Состяние". При необходимости она может быть перемещена или удалена.
            this.состяниеTableAdapter.Fill(this.invetPerspectivaDataSet.Состяние);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invetPerspectivaDataSet.Модель". При необходимости она может быть перемещена или удалена.
            this.модельTableAdapter.Fill(this.invetPerspectivaDataSet.Модель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invetPerspectivaDataSet.Кабинет". При необходимости она может быть перемещена или удалена.
            this.кабинетTableAdapter.Fill(this.invetPerspectivaDataSet.Кабинет);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
