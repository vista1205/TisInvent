using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvetPerspectiva
{
    public partial class Form1 : Form
    {
        public string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.Combine(Application.StartupPath, "InvetPerspectiva.accdb");
        //public string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Family\\source\\repos\\InvetPerspectiva\\InvetPerspectiva.accdb";
        private int table_act = 1;
        public Form1()
        {
            InitializeComponent();
        }
        public void My_Query(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            OleDbCommand MyCommand = conn.CreateCommand();
            MyCommand.CommandText = CommandText;
            MyCommand.ExecuteNonQuery();
            conn.Close();
        }
        private void Get_status( )
        {
            string CommandText = "SELECT * FROM [Состяние]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Состяние]");
            dataGridView2.DataSource = ds.Tables["[Состяние]"].DefaultView;
            dataGridView2.Columns[0].Visible = false;
        }
        private void Get_kabinet()
        {
            string CommandText = "SELECT * FROM [Кабинет]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Кабинет]");
            dataGridView2.DataSource = ds.Tables["[Кабинет]"].DefaultView;
            dataGridView2.Columns[0].Visible = false;
        }
        private void Get_Sotrudnik()
        {
            string CommandText = "SELECT * FROM [Сотрудники]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Сотрудники]");
            dataGridView2.DataSource = ds.Tables["[Сотрудники]"].DefaultView;
            dataGridView2.Columns[0].Visible = false;
        }
        private void Get_type()
        {
            string CommandText = "SELECT * FROM [тип_техники]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Тип_техники]");
            dataGridView2.DataSource = ds.Tables["[Тип_техники]"].DefaultView;
            dataGridView2.Columns[0].Visible = false;
        }
        private void Get_Model()
        {
            string CommandText = "SELECT * FROM [Модель]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Модель]");
            dataGridView2.DataSource = ds.Tables["[Модель]"].DefaultView;
            dataGridView2.Columns[0].Visible = false;
        }
        private void Get_Remont(int id)
        {
            string CommandText = "SELECT [Работы].[Номер оборудования], " +
                "[Работы].[Название работы], " +
                "[Работы].[Дата работы], " +
                "[Сотрудники].[ФИО] " + 
                "FROM [Работы], " +
                "[Сотрудники] " +
                "WHERE ([Работы].[Номер оборудования] = " + id + ") AND ([Работы].[Сотрудник] = [Сотрудники].[ID_sotrudnika])";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Работы]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            dataGridView2.Columns[0].Visible = false;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT " +
                "[Техника].[ID_tehnika], " +
                "[Техника].[Инвентарный номер], " +
                "[Техника].[Серийный номер], " +
                "[Тип_техники].[Тип техники], " +
                "[Модель].[Название модели], " +
                "[Сотрудники].[ФИО], " +
                "[Состяние].[Название состояния], " +
                "[Кабинет].[Номер кабинета] " +
             "FROM " +
                "[Техника], " +
                "[Тип_техники], " +
                "[Модель], " +
                "[Сотрудники], " +
                "[Состяние], " +
                "[Кабинет] " +
            "WHERE " +
            "([Техника].[ID_sotrudnika]=[Сотрудники].[ID_sotrudnika]) AND " +
            "([Техника].[ID_type]=[Тип_техники].[ID_type]) AND " +
            "([Техника].[ID_model]=[Модель].[ID_model]) AND " +            
            "([Техника].[ID_kabineta]=[Кабинет].[ID_kabineta]) AND " +
            "([Техника].[ID_status]=[Состяние].[ID_status] )";
            if (SearchText.Text != "")
            {
                if (SearchBox.SelectedIndex == 0)
                {
                    CommandText = CommandText + " AND ([Техника].[Инвентарный номер] LIKE '" + SearchText.Text + "%')";
                }

                if (SearchBox.SelectedIndex == 1)
                {
                    CommandText = CommandText + " AND ([Тип_техники].[Тип техники] LIKE '" + SearchText.Text + "%')";
                }

                if (SearchBox.SelectedIndex == 2)
                {
                    CommandText = CommandText + " AND ([Модель].[Название модели] LIKE '" + SearchText.Text + "%')";
                }

                if (SearchBox.SelectedIndex == 3)
                {
                    CommandText = CommandText + " AND ([Сотрудники].[ФИО] LIKE '" + SearchText.Text + "%')";
                }

                if (SearchBox.SelectedIndex == 4)
                {
                    CommandText = CommandText + " AND ([Состяние].[Название состояния] LIKE '" + SearchText.Text + "%')";
                }

                if (SearchBox.SelectedIndex == 5)
                {
                    CommandText = CommandText + " AND ([Кабинет].[Номер кабинета] LIKE '" + SearchText.Text + "%')";
                }
            }            
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Техника]");
            dataGridView1.DataSource = ds.Tables["[Техника]"].DefaultView;
            dataGridView1.Columns[0].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SearchBox.SelectedIndex = 0;
            button1_Click(sender, e);
        }
        private void Add_Button_technika_Click(object sender, EventArgs e)
        {
            Add_Technika_Form add_Technika_Form = new Add_Technika_Form(this);
            string CommandText;
            string InventNumber, SN, ID_Model, ID_Type, ID_Kabinet, ID_Sotrudnika, ID_Status;
            int row;
            if (add_Technika_Form.ShowDialog() == DialogResult.OK)
            {
                if((add_Technika_Form.textBox1.Text=="") || (add_Technika_Form.textBox2.Text == ""))
                {
                    MessageBox.Show("Необходимо заполнить Инвениарный номер и Серийный номер!");
                }
                else
                {
                    InventNumber = Convert.ToString(add_Technika_Form.textBox1.Text);
                    SN = Convert.ToString(add_Technika_Form.textBox2.Text);
                    row = add_Technika_Form.dataGridViewModel.CurrentCell.RowIndex;
                    ID_Model = Convert.ToString(add_Technika_Form.dataGridViewModel[0, row].Value);
                    row = add_Technika_Form.dataGridViewType_tehnika.CurrentCell.RowIndex;
                    ID_Type = Convert.ToString(add_Technika_Form.dataGridViewType_tehnika[0, row].Value);
                    row = add_Technika_Form.dataGridViewKabinet.CurrentCell.RowIndex;
                    ID_Kabinet = Convert.ToString(add_Technika_Form.dataGridViewKabinet[0, row].Value);
                    row = add_Technika_Form.dataGridViewSotrudniki.CurrentCell.RowIndex;
                    ID_Sotrudnika = Convert.ToString(add_Technika_Form.dataGridViewSotrudniki[0, row].Value);
                    row = add_Technika_Form.dataGridViewStatus.CurrentCell.RowIndex;
                    ID_Status = Convert.ToString(add_Technika_Form.dataGridViewStatus[0, row].Value);
                    CommandText = "INSERT INTO [Техника] ([Инвентарный номер], [Серийный номер], [ID_type], [ID_model], [ID_status], [ID_kabineta], [ID_sotrudnika], [ID_job])" +
                        "VALUES ('" + InventNumber + "', '" + SN + "', " + ID_Type + ", " + ID_Model + ", " + ID_Status + ", " + ID_Kabinet + ", " + ID_Sotrudnika + ", " + 1 + ")";
                    My_Query(CommandText);
                    button1_Click(sender, e);
                }
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            int index;
            index = dataGridView1.CurrentCell.RowIndex;
            id = Convert.ToInt32(dataGridView1[0, index].Value);
            Get_Remont(id);
        }
        private void DelButton_Click(object sender, EventArgs e)
        {
            Del_Form Del = new Del_Form();
            int index, index_old;
            index = dataGridView1.CurrentRow.Index;
            Del.NameType.Text = Convert.ToString(dataGridView1[3,index].Value);
            Del.NameModel.Text = Convert.ToString(dataGridView1[4, index].Value);
            Del.Invent.Text = Convert.ToString(dataGridView1[1, index].Value);
            Del.Kabinet.Text = Convert.ToString(dataGridView1[7, index].Value);
            if (Del.ShowDialog() == DialogResult.OK)
            {
                string CommandText;
                string ID;
                index = dataGridView1.CurrentRow.Index;
                index_old = index;
                ID = Convert.ToString(dataGridView1[0, index].Value);
                CommandText = "DELETE FROM [Техника] WHERE [Техника].[ID_tehnika] = " + ID + "";
                My_Query(CommandText);
                button1_Click(sender, e);
            }
        }
        private void View_Button_Status_Click(object sender, EventArgs e)
        {
            Get_status();
            table_act = 6;
        }

       private void Del_Status_Proc(string ID_Status)
        {
            string Commandtext = "DELETE FROM [Состяние] WHERE [Состяние].[ID_status]=" + ID_Status + "";
            My_Query(Commandtext);

        }
        private void Add_status_Proc(string status)
        {
            string CommandText = "INSERT INTO [Состяние] ([Название состояния]) VALUES ('" + status + "')";
            My_Query(CommandText);

        }
        private void Del_Kabinet_Proc(string ID_Kabinet)
        {
            string CommandText = "DELETE FROM [Кабинет] WHERE [Кабинет].[ID_kabineta]=" + ID_Kabinet + "";
            My_Query(CommandText);
        }
        private void Add_Kabinet_Proc(string kabinet)
        {
            string CommandText = "INSERT INTO [Кабинет] ([Номер кабинета]) VALUES ('" + kabinet + "')";
            My_Query(CommandText);
        }
        private void Del_Sotrudnik_Proc(string ID_Sotrudnik)
        {
            string Commandtext = "DELETE FROM [Сотрудники] WHERE [Сотрудники].[ID_sotrudnika]=" + ID_Sotrudnik + "";
            My_Query(Commandtext);
        }
        private void Add_Sotrudnik_Proc(string sotrudnik)
        {
            string CommandText = "INSERT INTO [Сотрудники] ([ФИО]) VALUES ('" + sotrudnik + "')";
            My_Query(CommandText);
        }
        private void Del_type_Proc(string ID_type)
        {
            string CommandText = "DELETE FROM [Тип_техники] WHERE [Тип_техники].[ID_type]=" + ID_type + "";
            My_Query(CommandText);
        }
        private void Add_Type_Proc(string type)
        {
            string CommandText = "INSERT INTO [Тип_техники] ([Тип техники]) VALUES ('" + type + "')";
            My_Query(CommandText);
        }
        private void Del_Model_proc(string ID_Model)
        {
            string CommandText = "DELETE FROM [Модель] WHERE [Модель].[ID_model]=" + ID_Model + "";
            My_Query(CommandText);
        }
        private void Add_Model_Proc(string model)
        {
            string CommandText = "INSERT INTO [Модель] ([Название модели]) VALUES ('" + model + "')";
            My_Query(CommandText);
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (table_act == 2)
            {
                Add_Type Type = new Add_Type();
                if (Type.ShowDialog() == DialogResult.OK)
                {
                    if (Type.add_typeTextBox.Text == "")
                        MessageBox.Show("Вы не заполнили значение поля!");
                    else
                    {
                        Add_Type_Proc(Type.add_typeTextBox.Text);
                        Get_type();
                    }
                }
            }
            else
            if (table_act == 3)
            {
                Add_Model Model = new Add_Model();
                if (Model.ShowDialog() == DialogResult.OK)
                {
                    if (Model.ModelTextBox.Text == "")
                        MessageBox.Show("Вы не заполнили значение поля!");
                    else
                    {
                        Add_Model_Proc(Model.ModelTextBox.Text);
                        Get_Model();
                    }
                }
            }
            if (table_act == 4)
            {
                Add_Sotrudnik Sotrudnik = new Add_Sotrudnik();
                if (Sotrudnik.ShowDialog() == DialogResult.OK)
                {
                    if (Sotrudnik.sotrudnikTextBox.Text == "")
                        MessageBox.Show("Вы не заполнили значение поля!");
                    else
                    {
                        Add_Sotrudnik_Proc(Sotrudnik.sotrudnikTextBox.Text);
                        Get_Sotrudnik();
                    }
                }
            }
            else
            if (table_act == 6)
            {
                Add_Status Status_Form = new Add_Status();
                if (Status_Form.ShowDialog() == DialogResult.OK)
                {
                    if (Status_Form.statusTextBox.Text == "")
                        MessageBox.Show("Вы не заполнили значение поля!");
                    else
                    {
                        Add_status_Proc(Status_Form.statusTextBox.Text);
                        Get_status();
                    }
                }
            }
            else
                if (table_act == 7)
            {
                Add_Kabinet_Form Add_Kabinet = new Add_Kabinet_Form();
                if (Add_Kabinet.ShowDialog() == DialogResult.OK)
                {
                    if (Add_Kabinet.kabinetTextBox.Text == "")
                        MessageBox.Show("Вы не заполнили значение поля!");
                    else
                    {
                        Add_Kabinet_Proc(Add_Kabinet.kabinetTextBox.Text);
                        Get_kabinet();
                    }
                }
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            Get_kabinet();
            table_act = 7;
        }

        private void SotrudnikiButton_Click(object sender, EventArgs e)
        {
            Get_Sotrudnik();
            table_act = 4;
        }

        private void Type_Button_Click(object sender, EventArgs e)
        {
            Get_type();
            table_act = 2;
        }

        private void Model_Button_Click(object sender, EventArgs e)
        {
            Get_Model();
            table_act = 3;
        }

        private void Add_Job_Button_Click(object sender, EventArgs e)
        {
            Add_Job Job = new Add_Job();
            if (Job.ShowDialog() == DialogResult.OK)
            {
                int id;
                string index;
                int User_Id;
                User_Id = Job.sotrudnikComboBox.SelectedIndex + 1;
                id = dataGridView1.CurrentCell.RowIndex;
                index = Convert.ToString(dataGridView1[0, id].Value);
                if ((Job.reportTextBox.Text == "") || (Job.dataTextBox.Text == ""))
                    MessageBox.Show("Вы не заполнили значение всех полей!");
                else
                {
                    string CommandText = "INSERT INTO [Работы] ([Номер оборудования], [Название работы], [Дата работы], [Сотрудник]) VALUES ('" + index + "', '" + Job.reportTextBox.Text + "', '" + Job.dataTextBox.Text + "', " + User_Id + ")";
                    My_Query(CommandText);
                    button1_Click(sender, e);
                }
            }
        }

        private void del_otherButton_Click(object sender, EventArgs e)
        {
            if (table_act == 2)
            {
                Delete_Type del_type = new Delete_Type();
                int index;
                string ID;
                index = dataGridView2.CurrentRow.Index;
                ID = Convert.ToString(dataGridView2[0, index].Value);
                del_type.delLabel.Text = Convert.ToString(dataGridView2[1, index].Value);
                if (del_type.ShowDialog() == DialogResult.OK)
                {
                    Del_type_Proc(ID);
                    Get_type();
                }                
            }
            else
            if (table_act == 3)
            {
                Del_Model del_model = new Del_Model();
                int index;
                string ID;
                index = dataGridView2.CurrentRow.Index;
                ID = Convert.ToString(dataGridView2[0, index].Value);
                del_model.delLabel.Text = Convert.ToString(dataGridView2[1, index].Value);
                if (del_model.ShowDialog() == DialogResult.OK)
                {
                    Del_Model_proc(ID);
                    Get_Model();
                }
            }
            if (table_act == 4)
            {
                Del_Sotrudnik del_sotr = new Del_Sotrudnik();
                int index;
                string ID;
                index = dataGridView2.CurrentRow.Index;
                ID = Convert.ToString(dataGridView2[0, index].Value);
                del_sotr.delLabel.Text = Convert.ToString(dataGridView2[1, index].Value);
                if (del_sotr.ShowDialog() == DialogResult.OK)
                {
                    Del_Sotrudnik_Proc(ID);
                    Get_Sotrudnik();
                }
            }
            else
            if (table_act == 6)
            {
                Del_status del_status = new Del_status();
                int index;
                string ID;
                index = dataGridView2.CurrentRow.Index;
                ID = Convert.ToString(dataGridView2[0, index].Value);
                del_status.delLabel.Text = Convert.ToString(dataGridView2[1, index].Value);
                if (del_status.ShowDialog() == DialogResult.OK)
                {
                    Del_Status_Proc(ID);
                    Get_status();
                }
            }
            else
            if (table_act == 7)
            {
                Del_Kabinet del_kab = new Del_Kabinet();
                int index;
                string ID;
                index = dataGridView2.CurrentRow.Index;
                ID = Convert.ToString(dataGridView2[0, index].Value);
                del_kab.delLabel.Text = Convert.ToString(dataGridView2[1, index].Value);
                if (del_kab.ShowDialog() == DialogResult.OK)
                {
                    Del_Kabinet_Proc(ID);
                    Get_kabinet();
                }
            }
        }
    }
}
