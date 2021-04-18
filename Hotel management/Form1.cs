using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_management
{
    public partial class LogInForm : Form
    {
        string logStr = "Логін";
        string passStr = " Пароль";
        private Color farbe;

        public LogInForm()
        {
            InitializeComponent();
            PassField.Size = new System.Drawing.Size(161, 50);
            txtLogFields();
        }

        public void txtLogFields()
        {
            this.PassField.Size = new Size(this.PassField.Size.Width, 30);//size of textBox password
            //invible info aboute textBox (login)
            farbe = LoginField.ForeColor;
            LoginField.ForeColor = Color.Gray;//color of txt
            LoginField.GotFocus += RemoveTextLog; //remove txt
            LoginField.LostFocus += AddTextLog;
            LoginField.Text = logStr;

            //invible info aboute textBox (password)
            PassField.UseSystemPasswordChar = false;
            farbe = PassField.ForeColor;
            PassField.ForeColor = Color.Gray;
            PassField.GotFocus += RemoveTextPass;
            PassField.LostFocus += AddTextPass;
            PassField.Text = passStr;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && LoginField.Text != "" && PassField.Text != "")
            {
                LoginBtn_Click(sender, e);
            }
        }

        public void RemoveTextLog(object sender, EventArgs e)
        {
            //  LoginField.ForeColor = Color.Gray;
            if (LoginField.Text == logStr)
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }
        public void AddTextLog(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(LoginField.Text))
            {
                LoginField.ForeColor = Color.Gray;
                LoginField.Text = logStr;
            }
        }

        public void RemoveTextPass(object sender, EventArgs e)
        {
            if (PassField.Text == passStr)
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
                PassField.UseSystemPasswordChar = true;
            }
        }
        public void AddTextPass(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(PassField.Text))
            {
                PassField.ForeColor = Color.Gray;
                PassField.Text = passStr;
            }
        }
        private Authorization UserAuthorization = new Authorization();

        //public IEnumerable<object> mainWindow { get; private set; }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String log = LoginField.Text;
            String pas = PassField.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            MySqlCommand comm = new MySqlCommand("SELECT * FROM `users` WHERE login = '" + log + "' AND password = '" + pas + "'", db.getConnection());           
            adapt.SelectCommand = comm;
            adapt.Fill(table);
            if (table.Rows.Count > 0) { (new MainForm()).Show(); this.Close(); }
            else MessageBox.Show("Користувач не знайден");
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
