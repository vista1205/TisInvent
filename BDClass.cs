using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InvetPerspectiva
{
    class BDClass
    {
        readonly Form1 f1 = new Form1();
        public string DBConnect()
        {
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.Combine(Application.StartupPath, "InvetPerspectiva.accdb");
            return ConnectionString;
        }
        public void My_Query(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(DBConnect());
            conn.Open();
            OleDbCommand MyCommand = conn.CreateCommand();
            MyCommand.CommandText = CommandText;
            MyCommand.ExecuteNonQuery();
            conn.Close();
        }
        public void Get_status()
        {            
            string CommandText = "SELECT * FROM [Состяние]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, DBConnect());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Состяние]");
            f1.dataGridView2.DataSource = ds.Tables["[Состяние]"].DefaultView;
            f1.dataGridView2.Columns[0].Visible = false;
        }
        public void Get_kabinet()
        {
            string CommandText = "SELECT * FROM [Кабинет]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, DBConnect());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Кабинет]");
            f1.dataGridView2.DataSource = ds.Tables["[Кабинет]"].DefaultView;
            f1.dataGridView2.Columns[0].Visible = false;
        }
        public void Get_Sotrudnik()
        {
            string CommandText = "SELECT * FROM [Сотрудники]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, DBConnect());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Сотрудники]");
            f1.dataGridView2.DataSource = ds.Tables["[Сотрудники]"].DefaultView;
            f1.dataGridView2.Columns[0].Visible = false;
        }
        public void Get_type()
        {
            string CommandText = "SELECT * FROM [тип_техники]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, DBConnect());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Тип_техники]");
            f1.dataGridView2.DataSource = ds.Tables["[Тип_техники]"].DefaultView;
            f1.dataGridView2.Columns[0].Visible = false;
        }
        public void Get_Model()
        {
            string CommandText = "SELECT * FROM [Модель]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, DBConnect());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Модель]");
            f1.dataGridView2.DataSource = ds.Tables["[Модель]"].DefaultView;
            f1.dataGridView2.Columns[0].Visible = false;
        }
        public void Get_Remont(int id)
        {
            string CommandText = "SELECT [Работы].[Номер оборудования], " +
                "[Работы].[Название работы], " +
                "[Работы].[Дата работы], " +
                "[Сотрудники].[ФИО] " +
                "FROM [Работы], " +
                "[Сотрудники] " +
                "WHERE ([Работы].[Номер оборудования] = " + id + ") AND ([Работы].[Сотрудник] = [Сотрудники].[ID_sotrudnika])";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, DBConnect());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Работы]");
            f1.dataGridView2.DataSource = ds.Tables[0].DefaultView;
            f1.dataGridView2.Columns[0].Visible = false;
        }
    }
}
