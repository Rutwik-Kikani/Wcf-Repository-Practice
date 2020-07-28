using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialStyleDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("RollNumber", typeof(int));
            table.Columns.Add("Student Name", typeof(string));
            table.Columns.Add("FatherName", typeof(string));
            table.Columns.Add("MobileNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Course", typeof(string));
            table.Columns.Add("Location", typeof(string));

            table.Rows.Add(1, "Rutwik", "RameshBhai", "8160802770", "kikanirutwik001@gmail.com", "CE", "Bhanagar");
            table.Rows.Add(2, "Rajvir", "RakeshBhai", "8160802771", "Dummay@Dummay.com", "CE", "Rajkot");
            table.Rows.Add(3, "Abhinav", "RonakBhai", "8160802773", "Dummay@Dummay.com", "IT", "Jamnagar");
            table.Rows.Add(4, "Vedika", "VivekBhai", "8160802775", "Dummay@Dummay.com", "CE", "Delhi");
            table.Rows.Add(5, "Maush", "RakeshBhai", "8160802751", "Dummay@Dummay.com", "EC", "Merath");
            table.Rows.Add(6, "Shradhha", "SharmaBhai", "8860802771", "Dummay@Dummay.com", "EC", "Bhavnagar");
            table.Rows.Add(7, "Khushi", "BakaBhai", "8160872771", "Dummay@Dummay.com", "CE", "Bhavnagar");
            table.Rows.Add(8, "Tapshiya", "BakulBhai", "8160872771", "Dummay@Dummay.com", "IT", "Bhavnagar");
            table.Rows.Add(9, "Rutvik", "ChandhuBhai", "8160875771", "Dummay@Dummay.com", "IT", "Pallitana");
            table.Rows.Add(10, "Laddu", "DonBhai", "8160572771", "Dummay@Dummay.com", "CE", "Pune");


            dataGridView1.DataSource = table;

            //style DataGridView 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }
    }
}
