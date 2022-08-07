using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace manager_player
{
    public partial class Main_body : Form
    {
        // chuoi ket noi
        string Strcon = @"Data Source = DORAYAKI-EMON\SQLEXPRESS ; Initial Catalog = teamManagement; Integrated Security=True";
        // doi tuong ket noi
        SqlConnection Sqlcon = null;

        string path_img = @"";

        public Main_body()
        {
            InitializeComponent();
        }

        #region các hàm thêm 

        // load cau thu vao danh sach
        private void LoadItem(Player player)
        {
            ListViewItem item = new ListViewItem();
            item.Text = player.Id;
            item.SubItems.Add(new ListViewItem.ListViewSubItem() {Text = player.Name });
            Lv_listPlayer.Items.Add(item);
        }

        // load du lieu vao listview
        private void LoadData(string command = "select ID, Name from player")
        {
            try
            {
                Lv_listPlayer.Items.Clear();

                SqlDataReader Reader = access(command);

                while (Reader.Read())
                {
                    Player player = new Player() 
                    { 
                        Id = Reader.GetString(0),
                        Name = Reader.GetString(1)
                    };
                    LoadItem(player);
                }
                Reader.Close();
                Sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // truy van du lieu (xuat du lieu)
        private SqlDataReader access(string command)
        {

                Sqlcon = new SqlConnection(Strcon);
                Sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand(command, Sqlcon);
                SqlDataReader Reader = sqlCmd.ExecuteReader();

                return Reader;
            
        }
        // thuc hien truy van them sua xoa
        private void Command(string command)
        {
            try
            {
                Sqlcon = new SqlConnection(Strcon);
                Sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand(command,Sqlcon);
 
                int success = sqlCmd.ExecuteNonQuery();
                if (success == -1)
                {
                    MessageBox.Show("Fail!");
                }
                else
                {
                    MessageBox.Show("Success!");
                }
                Sqlcon.Close();

            }
            catch (SqlException )
            {
                MessageBox.Show("ID already exists");
            }
            catch (Exception)
            {
                MessageBox.Show("error !");
            }
            

        }
        

        // hien thi thong tin ca nhan cau thu
        private void Set_Infor(Player player)
        {
            Tb_ID.ReadOnly = true;
            Tb_ID.Text = player.Id.Trim() ;
            Tb_name.Text = player.Name.Trim() ;

            if (player.Gender.Trim() == "Male" || player.Gender == "")
            {
                rb_Male.Checked = true;
            }
            else
            {
                rb_Female.Checked = true;
            }

            dateTime_date.Value = player.Date ;
            Tb_address.Text = player.Nationality.Trim() ;
            cb_positions.Text = player.Position.Trim();
            Tb_contract.Text = player.Contract.Trim() ;
            Tb_salary.Text = player.Salary.ToString().Trim() ;
            try
            {
                pic_player.Image = Image.FromFile(player.Img_path);

            }
            catch (Exception)
            {
                pic_player.Image = global::manager_player.Properties.Resources.Logo_Bar;
            }
}

        private Player Get_infor()
        {
            
            string gender = rb_Male.Checked ? rb_Male.Text : rb_Female.Text;
            int salary;
            try
            {
                salary = int.Parse(Tb_salary.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("data type error...!");
                return null;
            }
            Player player = new Player()
            {
                Id = Tb_ID.Text.Trim(),
                Name = Tb_name.Text.Trim(),
                Gender = gender,
                Date = dateTime_date.Value,
                Nationality = Tb_address.Text.Trim(),
                Position = cb_positions.Text,
                Contract = Tb_contract.Text.Trim(),
                Salary = salary,
                Img_path = path_img
            };
            return player;

        }

        #endregion


        #region event

        // dang suat
        private void btn_signout_Click(object sender, EventArgs e)
        {
            
            DialogResult check_out = MessageBox.Show("Do you really want to sign out?", "Notification", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (check_out == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        // img click
        private void pic_player_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFile.ShowDialog();
                path_img = OpenFile.FileName;
                pic_player.Image = Image.FromFile(path_img);
            }
            catch (Exception)
            {
                MessageBox.Show("The selected file is not an image !");
                return;
            }    
        }
        // chon cau thu
        private void Lv_listPlayer_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
            Tb_ID.ReadOnly = true;

            if (Lv_listPlayer.SelectedItems.Count > 0)
            {
                ListViewItem item = Lv_listPlayer.SelectedItems[0];
                string command = "select * from player where ID = '" + item.Text + "'";

                SqlDataReader Reader = access(command);
                while (Reader.Read())
                {
                    Player player = new Player()
                    {
                        Id = Reader.GetString(0),
                        Name = Reader.GetString(1),
                        Gender = Reader.GetString(2),
                        Date = Reader.GetDateTime(3),
                        Nationality = Reader.GetString(4),
                        Position = Reader.GetString(5),
                        Contract = Reader.GetString(6),
                        Salary = Reader.GetInt32(7),
                        Img_path = Reader.GetString(8)
                    };
                    Set_Infor(player);

                    path_img = player.Img_path;
                }

                Reader.Close();
                Sqlcon.Close();

            }
        }
        //add click
        private void btn_add_Click(object sender, EventArgs e)
        {
            Set_Infor(new Player());
            Tb_ID.ReadOnly = false;

            btn_Save.Visible = true;
            btn_Cancel.Visible = true;

            btn_delete.Enabled = false;
            btn_update.Enabled = false;


        }

       // form load
        private void Main_body_Load(object sender, EventArgs e)
        {
            cb_positions.DataSource = Player.List_positions;
            cb_seachPosition.DataSource = Player.filter;
            //LoadData();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
        }


        // Update click
        private void btn_update_Click(object sender, EventArgs e)
        {
            Player player = Get_infor();
            
                string command = "update player set " +
                " Name = '" + player.Name + "'" +
                ",Gender = '" + player.Gender + "'" +
                ",Date = '" + player.Date + "'" +
                ",Nationality = '" + player.Nationality + "'" +
                ",Position = '" + player.Position + "'" +
                ",Contract = '" + player.Contract + "'" +
                ",Salary = " + player.Salary +
                ",Img = '" + player.Img_path + "'" +
                " Where ID = '" + player.Id + "'";

                Command(command);
                LoadData();
          
        }

        // xoa cau thu
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string command = "delete from player where ID = '"+Tb_ID.Text+"'";
            Command(command);
            Set_Infor(new Player());
            LoadData();

        }

        // su ly su kien seach
        private void cb_seachPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_seachPosition.Text == "All")
            {
                LoadData();
            }
            else
            {
                string command = "select ID,Name from player where Position like '%"+cb_seachPosition.Text+"%'";

                LoadData(command);
            }
            
        }

        // luu cau thu vao database
        private void btn_Save_Click(object sender, EventArgs e)
        {
           
            Player player = Get_infor();
            if (player == null)
            {
                return;
            }
            else
            {
                if (player.Id != "")
                {
                    string command = "INSERT INTO player (ID, Name, Gender,Date,Nationality,Position,Contract,Salary,Img)" +
                                        "VALUES(" +
                                        "'" + player.Id + "'," +
                                        "'" + player.Name + "'," +
                                        "'" + player.Gender + "'," +
                                        "'" + player.Date + "'," +
                                        "'" + player.Nationality + "'," +
                                        "'" + player.Position + "'," +
                                        "'" + player.Contract + "'," +
                                        "" + player.Salary + "," +
                                        "'" + player.Img_path + "')";

                    Command(command);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("ID not emty!");
                }
            }
        }
        // thoat viec them cau thu
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Tb_ID.ReadOnly = true;
            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
           
            Set_Infor(new Player());
        }

        
        #endregion

        
    }
}
