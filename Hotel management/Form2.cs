using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddRoom.Enabled = false;
            DropRoom.Enabled = false;
            ColorButton();
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            AddR.Visible = false;
        }
        public int _activeButton;

        public void ActiveButton()
        {
            foreach (var i in panel1.Controls.OfType<Button>())
            {
                i.FlatAppearance.BorderSize = 1;
            }
        }

        public void ColorButton()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            MySqlCommand comm = new MySqlCommand("SELECT Status FROM `rooms`", db.getConnection());
            adapt.SelectCommand = comm;
            adapt.Fill(table);
            foreach (var i in panel1.Controls.OfType<Button>())
            {
                if (table.Rows[Convert.ToInt32(i.Text) - 1][0].ToString() == "No")
                    i.BackColor = Color.Gray;
                else
                    i.BackColor = Color.White;
            }
        }

        private void RoomStatus(int i)
        {
            AddRoom.Enabled = false;
            DropRoom.Enabled = false;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            MySqlCommand comm = new MySqlCommand("SELECT Status FROM `rooms` WHERE Number = '" + i + "'", db.getConnection());
            adapt.SelectCommand = comm;
            adapt.Fill(table);
            string s = table.Rows[0][0].ToString();
            if (s == "Yes") { AddRoom.Enabled = true; }
            else if (s == "No") { DropRoom.Enabled = true; }
            else MessageBox.Show("Помилка");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new LogInForm()).Show(); this.Close();
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void room1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(1);
            ActiveButton();
            room1.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room1.Text);
        }

        private void room2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(2);
            ActiveButton();
            room2.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room2.Text);
        }

        private void room3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(3);
            ActiveButton();
            room3.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room3.Text);
        }

        private void room4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(4);
            ActiveButton();
            room4.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room4.Text);
        }

        private void room5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(5);
            ActiveButton();
            room5.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room5.Text);
        }

        private void room6_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(6);
            ActiveButton();
            room6.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room6.Text);
        }

        private void room7_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(7);
            ActiveButton();
            room7.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room7.Text);
        }

        private void room8_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(8);
            ActiveButton();
            room8.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room8.Text);
        }

        private void room9_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(9);
            ActiveButton();
            room9.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room9.Text);
        }

        private void room10_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(10);
            ActiveButton();
            room10.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room10.Text);
        }

        private void room11_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(11);
            ActiveButton();
            room11.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room11.Text);
        }

        private void room12_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(12);
            ActiveButton();
            room12.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room12.Text);
        }

        private void room13_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(13);
            ActiveButton();
            room13.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room13.Text);
        }

        private void room14_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(14);
            ActiveButton();
            room14.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room14.Text);
        }

        private void room15_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(15);
            ActiveButton();
            room15.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room15.Text);
        }

        private void room16_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(16);
            ActiveButton();
            room16.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room16.Text);
        }

        private void room17_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(17);
            ActiveButton();
            room17.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room17.Text);
        }

        private void room18_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(18);
            ActiveButton();
            room18.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room18.Text);
        }

        private void room19_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(19);
            ActiveButton();
            room19.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room19.Text);
        }

        private void room20_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(20);
            ActiveButton();
            room20.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room20.Text);
        }

        private void room21_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(21);
            ActiveButton();
            room21.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room21.Text);
        }

        private void room22_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(22);
            ActiveButton();
            room22.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room22.Text);
        }

        private void room23_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(23);
            ActiveButton();
            room23.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room23.Text);
        }

        private void room24_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false; textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false; textBox2.Clear();
            AddR.Visible = false;
            RoomStatus(24);
            ActiveButton();
            room24.FlatAppearance.BorderSize = 3;
            _activeButton = Convert.ToInt32(room24.Text);
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            AddR.Visible = true;
        }

        private void DropRoom_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Бажаєте видалити користувача?", "Підтвердження дії", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String connectionString = "server=localhost;port=3306;username=root;password=root;database=hotelmanagment";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                String query = "UPDATE `rooms` SET Status = 'Yes', FullName='',Phone='' WHERE Number = '" + _activeButton + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQueryAsync();
                connection.Close();
                ColorButton(); MessageBox.Show("Клієнта видалено", "", MessageBoxButtons.OK);
            }
        }

        private void AddR_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") { MessageBox.Show("Некоректні дані", "", MessageBoxButtons.OK); }
            else
            {
                String fio = textBox1.Text;
                String phon = textBox2.Text;

                String connectionString = "server=localhost;port=3306;username=root;password=root;database=hotelmanagment";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                String query = "UPDATE `rooms` SET Status = 'No', FullName = '"+ fio +"', Phone = '"+ phon +"' WHERE Number = '" + _activeButton + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQueryAsync();
                connection.Close();
                ColorButton(); MessageBox.Show("Клієнта збережено", "", MessageBoxButtons.OK);
                label1.Visible = false;
                textBox1.Visible = false; textBox1.Clear();
                label2.Visible = false;
                textBox2.Visible = false; textBox2.Clear();
                AddR.Visible = false;
            }
        }
    }
}
