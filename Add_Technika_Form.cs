using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InvetPerspectiva
{
    public partial class Add_Technika_Form : Form
    {

        Form1 MForm;

        public Add_Technika_Form(Form1 form)
        {
            MForm = form;
            InitializeComponent();
        }

       private void Get_table (string table_name, int num_dG)
        {
            string CommandText = "SELECT * FROM ";
            CommandText += table_name;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, MForm.ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, table_name);
            if (num_dG == 1)
            {
                dataGridViewTehnika.DataSource = ds.Tables[table_name].DefaultView;
                dataGridViewTehnika.Columns[0].Visible = false;
            }
            if (num_dG == 2)
            {
                dataGridViewType_tehnika.DataSource = ds.Tables[table_name].DefaultView;
                dataGridViewType_tehnika.Columns[0].Visible = false;
            }
            if (num_dG == 3)
            {
                dataGridViewModel.DataSource = ds.Tables[table_name].DefaultView;
                dataGridViewModel.Columns[0].Visible = false;
            }
            if (num_dG == 4)
            {
                dataGridViewSotrudniki.DataSource = ds.Tables[table_name].DefaultView;
                dataGridViewSotrudniki.Columns[0].Visible = false;
            }
            if (num_dG == 6)
            {
                dataGridViewStatus.DataSource = ds.Tables[table_name].DefaultView;
                dataGridViewStatus.Columns[0].Visible = false;
            }
            if (num_dG == 7)
            {
                dataGridViewKabinet.DataSource = ds.Tables[table_name].DefaultView;
                dataGridViewKabinet.Columns[0].Visible = false;
            }
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            MForm.button1_Click(sender, e);
        }

        private void Add_Technika_Form_Load(object sender, EventArgs e)
        {
            Get_table("Техника", 1);
            Get_table("Тип_техники", 2);
            Get_table("Модель", 3);
            Get_table("Сотрудники", 4);
            Get_table("Состяние", 6);
            Get_table("Кабинет", 7);
        }
        private void dataGridViewType_tehnika_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = dataGridViewType_tehnika.CurrentCell.RowIndex;
            label1.Text = "Тип техники: " + Convert.ToString(dataGridViewType_tehnika[1, row].Value);
        }

        private void dataGridViewSotrudniki_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = dataGridViewSotrudniki.CurrentCell.RowIndex;
            label2.Text = "ФИО Сотрудника: " + Convert.ToString(dataGridViewSotrudniki[1, row].Value);
        }

        private void dataGridViewStatus_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = dataGridViewStatus.CurrentCell.RowIndex;
            label3.Text = "Статус техники: " + Convert.ToString(dataGridViewStatus[1, row].Value);
        }

        private void dataGridViewModel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = dataGridViewModel.CurrentCell.RowIndex;
            label4.Text = "Модель техники: " + Convert.ToString(dataGridViewModel[1, row].Value);
        }
        private void dataGridViewKabinet_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = dataGridViewKabinet.CurrentCell.RowIndex;
            label5.Text = "Номер кабинета: " + Convert.ToString(dataGridViewKabinet[1, row].Value);
        }

        private void replace_button_Click(object sender, EventArgs e)
        {
            string CommandText;
            string ID;
            int row;
            string ID_Status;
            row = dataGridViewTehnika.CurrentCell.RowIndex;
            ID = Convert.ToString(dataGridViewTehnika[0, row].Value);
            row = dataGridViewStatus.CurrentCell.RowIndex;
            ID_Status = Convert.ToString(dataGridViewStatus[0, row].Value);
            CommandText = "UPDATE [Техника] SET [ID_status] = " + ID_Status + " WHERE [ID_tehnika] = " + ID + "";
            MForm.My_Query(CommandText);
            MForm.button1_Click(sender, e);
            Get_table("Техника", 1);
            MessageBox.Show("Данные успешно изменены!");
        }

        private void replace_kabinet_button_Click(object sender, EventArgs e)
        {
            string CommandText;
            string ID;
            int row;
            string ID_Kabineta;
            row = dataGridViewTehnika.CurrentCell.RowIndex;
            ID = Convert.ToString(dataGridViewTehnika[0, row].Value);
            row = dataGridViewKabinet.CurrentCell.RowIndex;
            ID_Kabineta = Convert.ToString(dataGridViewKabinet[0, row].Value);
            CommandText = "UPDATE [Техника] SET [ID_kabineta] = " + ID_Kabineta + " WHERE [ID_tehnika] = " + ID + "";
            MForm.My_Query(CommandText);
            MForm.button1_Click(sender, e);
            Get_table("Техника", 1);
            MessageBox.Show("Данные успешно изменены!");
        }

        private void replace_model_button_Click(object sender, EventArgs e)
        {
            string CommandText;
            string ID;
            int row;
            string ID_model;
            row = dataGridViewTehnika.CurrentCell.RowIndex;
            ID = Convert.ToString(dataGridViewTehnika[0, row].Value);
            row = dataGridViewModel.CurrentCell.RowIndex;
            ID_model = Convert.ToString(dataGridViewModel[0, row].Value);
            CommandText = "UPDATE [Техника] SET [ID_model] = " + ID_model + " WHERE [ID_tehnika] = " + ID + "";
            MForm.My_Query(CommandText);
            MForm.button1_Click(sender, e);
            Get_table("Техника", 1);
            MessageBox.Show("Данные успешно изменены!");

        }

        private void replace_type_button_Click(object sender, EventArgs e)
        {
            string CommandText;
            string ID;
            int row;
            string ID_type;
            row = dataGridViewTehnika.CurrentCell.RowIndex;
            ID = Convert.ToString(dataGridViewTehnika[0, row].Value);
            row = dataGridViewType_tehnika.CurrentCell.RowIndex;
            ID_type = Convert.ToString(dataGridViewType_tehnika[0, row].Value);
            CommandText = "UPDATE [Техника] SET [ID_type] = " + ID_type + " WHERE [ID_tehnika] = " + ID + "";
            MForm.My_Query(CommandText);
            MForm.button1_Click(sender, e);
            Get_table("Техника", 1);
            MessageBox.Show("Данные успешно изменены!");
        }

        private void replace_invent_button_Click(object sender, EventArgs e)
        {
            string CommandText;
            string ID;
            int row;
            string ID_invent;
            row = dataGridViewTehnika.CurrentCell.RowIndex;
            ID = Convert.ToString(dataGridViewTehnika[0, row].Value);
            ID_invent = textBox1.Text;
            CommandText = "UPDATE [Техника] SET [Инвентарный номер] = " + ID_invent + " WHERE [ID_tehnika] = " + ID + "";
            MForm.My_Query(CommandText);
            MForm.button1_Click(sender, e);
            Get_table("Техника", 1);
            MessageBox.Show("Данные успешно изменены!");
        }
    }
}
