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
    public partial class Add_Kabinet_Form : Form
    {
        public Add_Kabinet_Form()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Edit_Tehnika_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invetPerspectivaDataSet.Кабинет". При необходимости она может быть перемещена или удалена.
            this.кабинетTableAdapter.Fill(this.invetPerspectivaDataSet.Кабинет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invetPerspectivaDataSet.Состяние". При необходимости она может быть перемещена или удалена.
            this.состяниеTableAdapter.Fill(this.invetPerspectivaDataSet.Состяние);

        }
    }
}
