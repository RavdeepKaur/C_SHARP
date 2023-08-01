using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day7
{
    public partial class Form2 : Form
    {
        String name, password;
        public Form2(String t1, String t2)
        {
            InitializeComponent();
            name = t1;
            password = t2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !=null && textBox2.Text !=null)
            {
                try
                {
                    DbConnection obj=new DbConnection();
                    obj.conn.ConnectionString = obj.location;
                    obj.conn.Open();
                    String insertUser = "insert into userTable values('"+textBox1.Text+"','"+textBox2.Text+"')" ;
                    obj.cmd.Connection = obj.conn;
                    obj.cmd.CommandText = insertUser;
                    obj.cmd.ExecuteNonQuery();
                    obj.conn.Close();
                    MessageBox.Show("User Signed Up Successfully");
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error: "+ex);
                }
            }
            else
            {
                MessageBox.Show("Username and password cannot be empty");
            }
        }
    }
}
