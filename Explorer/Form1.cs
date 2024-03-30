using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Explorer
{
    public partial class explover : Form
    {
        public explover()
        {
            InitializeComponent();
        }
        //Для ресет кнопки back_list_1 и back_list_2, а для
        private DirectoryInfo DirectoryInfo { get; set; } = new DirectoryInfo(Directory.GetCurrentDirectory());
        private void explover_Load(object sender, EventArgs e)
        {
            restoke_1.Text = Convert.ToString('\u21BB');
            restoke_2.Text = Convert.ToString('\u21BB');
            ShowDisks(panel1);
            ShowDisks(panel2);

        }
        void key_to_open_to_1(object sender, EventArgs e)
        {
            Panel panel =sender as Panel;
            if(panel != null)
            {
                Back_List_Add(panel1);
                Open_To_File(panel1, Convert.ToString(panel.Tag));
            }
            forvard_list_1.Items.Clear();
            forvard_to_1.Enabled = false;
        }
        void key_to_open_to_2(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                Back_List_Add(panel2);
                Open_To_File(panel2, Convert.ToString(panel.Tag));
            }
            forvard_list_2.Items.Clear();
            forvard_to_2.Enabled = false;
        }

        private void back_to_1_Click(object sender, EventArgs e)
        {
            try
            {
                forvard_list_1.Items.Add(panel1.Tag);
                forvard_to_1.Enabled = true;
                if (back_list_1.Items[back_list_1.Items.Count - 1] == "")
                {
                    ShowDisks(panel1);
                }
                else
                {
                    Open_To_File(panel1, Convert.ToString(back_list_1.Items[back_list_1.Items.Count - 1]));
                }
            }
            catch
            {
                MessageBox.Show("Каталог, который вы пытаетесь открыть не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                back_list_1.Items.RemoveAt(back_list_1.Items.Count - 1);
                if (back_list_1.Items.Count == 0)
                {
                    back_to_1.Enabled = false;
                }
            }
        }
        private void back_to_2_Click(object sender, EventArgs e)
        {
            try
            {
                forvard_list_2.Items.Add(panel2.Tag);
                forvard_to_2.Enabled = true;
                if (back_list_2.Items[back_list_2.Items.Count - 1] == "")
                {
                    ShowDisks(panel2);
                }
                else
                {
                    Open_To_File(panel2, Convert.ToString(back_list_2.Items[back_list_2.Items.Count - 1]));
                }
            }
            catch
            {
                MessageBox.Show("Каталог, который вы пытаетесь открыть не существует","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                back_list_2.Items.RemoveAt(back_list_2.Items.Count - 1);
                if (back_list_2.Items.Count == 0)
                {
                    back_to_2.Enabled = false;
                }
            }
        }


        private void forvard_to_1_Click(object sender, EventArgs e)
        {
            try
            {
                Back_List_Add(panel1);
                if (forvard_list_1.Items[forvard_list_1.Items.Count-1] == "")
                {
                    ShowDisks(panel1);
                }
                else
                {
                    Open_To_File(panel1, Convert.ToString(forvard_list_1.Items[forvard_list_1.Items.Count - 1]));
                }
            }
            catch
            {
                MessageBox.Show("Каталог, который вы пытаетесь открыть не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                forvard_list_1.Items.RemoveAt(forvard_list_1.Items.Count - 1);
                if(forvard_list_1.Items.Count == 0)
                {
                    forvard_to_1.Enabled = false;
                }
            }
        }
        private void forvard_to_2_Click(object sender, EventArgs e)
        {
            try
            {
                Back_List_Add(panel2);
                if (forvard_list_2.Items[forvard_list_2.Items.Count - 1] == "")
                {
                    ShowDisks(panel2);
                }
                else
                {
                    Open_To_File(panel2, Convert.ToString(forvard_list_2.Items[forvard_list_2.Items.Count - 1]));
                }
            }
            catch
            {
                MessageBox.Show("Каталог, который вы пытаетесь открыть не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                forvard_list_2.Items.RemoveAt(forvard_list_2.Items.Count - 1);
                if (forvard_list_2.Items.Count == 0)
                {
                    forvard_to_2.Enabled = false;
                }
            }

        }


        private void restoke_1_Click(object sender, EventArgs e)
        {
            if(panel1.Tag == "")
            {
                ShowDisks(panel1);
            }
            else
            {
                Open_To_File(panel1, Convert.ToString(panel1.Tag));
            }
        }
        private void restoke_2_Click(object sender, EventArgs e)
        {
            if (panel2.Tag == "")
            {
                ShowDisks(panel2);
            }
            else
            {
                Open_To_File(panel2, Convert.ToString(panel2.Tag));
            }

        }

        private void path_box_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Back_List_Add(panel1);
                if (path_box_1.Text=="")
                {
                    ShowDisks(panel1);
                }
                else
                {
                    Open_To_File(panel1, path_box_1.Text);
                }
            }
        }
        private void path_box_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Back_List_Add(panel2);
                if (path_box_2.Text == "")
                {
                    ShowDisks(panel2);
                }
                else
                {
                    Open_To_File(panel2, path_box_2.Text);
                }
            }
        }


        private void search_bar_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && !string.IsNullOrEmpty(search_bar_1.Text))
            {
                Search(panel1, Convert.ToString(panel1.Tag), search_bar_1.Text);
            }
        }
        private void search_bar_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && !string.IsNullOrEmpty(search_bar_2.Text))
            {
                Search(panel2, Convert.ToString(panel2.Tag), search_bar_2.Text);
            }
        }
        private void search_button_1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(search_bar_1.Text))
            {
                Back_List_Add(panel1);
                Search(panel1, Convert.ToString(panel1.Tag), search_bar_1.Text);
            }
        }
        private void search_button_2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(search_bar_2.Text))
            {
                Back_List_Add(panel2);
                Search(panel2, Convert.ToString(panel2.Tag), search_bar_2.Text);
            }
        }

        private void Open_To_exe(object sender, EventArgs e)
        {
            try
            {
                Panel panel = sender as Panel;
                var process = new Process();
                process.StartInfo.FileName = Convert.ToString(panel.Tag);
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
            catch
            {
                MessageBox.Show("Не получилось запустить приложение", "Ошибка запуска", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
            }
        }

        private void Folder_Hover(object sender, MouseEventArgs e)
        {
            try
            {
                Panel panel = sender as Panel;
                drag_path = Convert.ToString(panel.Tag);
                panel.BackColor = Color.AliceBlue;
            }
            catch
            {

            }
        }
        private void Folder_no_Hover(object sender, EventArgs e)
        {
            try
            {
                Panel panel = sender as Panel;
                drag_path = "";
                panel.BackColor = Color.White;
            }
            catch
            {

            }
        }
        private void no_Folder_Hover(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.AliceBlue;
        }
        private void no_Folder_no_Hover(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.White;
        }
        #region Методы основные не тригеры 
        private void ShowDisks(Control panel)
        {
            drives = DriveInfo.GetDrives();
            if(drives.Length <= 0)
            {
                if(MessageBox.Show("Не было найдено дисков", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    ShowDisks(panel);
                }
                return;
            }
            if(panel == panel1)
            {
                path_box_1.Text = "";
            }
            else
            {
                path_box_2.Text = "";
            }
            panel.Tag = "";
            panel.Controls.Clear();
            for (int i = 0; i < drives.Length; i++)
            {
                Panel drive = new Panel();
                drive.Top = i * 60;
                drive.Left = 0;
                drive.Width = 570;
                drive.Height = 60;
                drive.BackColor = Color.White;
                //Когда сделаю выделение выпилить\/
                drive.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(drive);
                PictureBox drivepicter = new PictureBox();
                drivepicter.Height = 30;
                drivepicter.Width = 30;
                drivepicter.Top = 10;
                drivepicter.Left = 20;
                drivepicter.Image = Properties.Resources.drive_icon;
                drivepicter.SizeMode =PictureBoxSizeMode.StretchImage;
                drive.Controls.Add(drivepicter);
                Label drivename = new Label();
                if (drives[i].IsReady)
                {
                    drivename.Text = drives[i].VolumeLabel + " " + drives[i].Name;
                    ProgressBar drivesize = new ProgressBar();
                    drivesize.Top = 30;
                    drivesize.Maximum = Convert.ToInt32(drives[i].TotalSize / Math.Pow(2, 33));
                    drivesize.Value = Convert.ToInt32(drives[i].TotalSize / Math.Pow(2, 33)) - Convert.ToInt32(drives[i].AvailableFreeSpace / Math.Pow(2, 33));
                    drivesize.Width = 300;
                    drivesize.Left = 100;
                    drive.Controls.Add(drivesize);
                    Label drivesizes = new Label();
                    drivesizes.Width = 170;
                    drivesizes.Height = 50;
                    if (drives[i].TotalSize / Math.Pow(2, 40)>1)
                    {
                        drivesizes.Text = $"Всего места: {Math.Round(drives[i].TotalSize / Math.Pow(2, 40),2)} Тб\nСвободно из него: {Math.Round(drives[i].AvailableFreeSpace / Math.Pow(2, 40),2)} Тб";
                        
                    }
                    else
                    {
                        drivesizes.Text = $"Всего места: {Math.Round(drives[i].TotalSize / Math.Pow(2, 30), 2)} Гб\nСвободно из него: {Math.Round(drives[i].AvailableFreeSpace / Math.Pow(2, 30),2)} Гб";
                    }
                    drivesizes.Top = 10;
                    drivesizes.Left = 405;
                    drivesizes.Font = new Font("Arial", 9, FontStyle.Regular);
                    drive.Controls.Add(drivesizes);
                }
                else
                {
                    drivename.Text = drives[i].Name;
                }
                drivename.Font = new Font("Arial",9,FontStyle.Regular);
                drivename.Top = 10;
                drivename.Left = 100;
                drive.Controls.Add(drivename);
                //добавить тригерочки
                drive.Tag = drives[i].Name;
                drive.MouseMove += new MouseEventHandler(no_Folder_Hover);
                drive.MouseLeave += new EventHandler(no_Folder_no_Hover);
                if (panel==panel1)
                {
                    drive.DoubleClick += new EventHandler(key_to_open_to_1);
                }
                else
                {
                    drive.DoubleClick += new EventHandler(key_to_open_to_2);
                }
            }
        }
        private void Open_To_File(Control panel, string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    MessageBox.Show($"Не найдено каталога по пути {path}");
                    return;
                }
                int i = 0;
                DirectoryInfo = new DirectoryInfo(path);
                DirectoryInfo[] catalogs = DirectoryInfo.GetDirectories();
                panel.Tag = path;
                panel.Controls.Clear();
                for (; i < catalogs.Length; i++)
                {
                    Panel folder = new Panel();
                    folder.Top = i * 60;
                    folder.Left = 0;
                    folder.Width = 567;
                    folder.Height = 60;
                    folder.BackColor = Color.White;
                    folder.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(folder);
                    PictureBox icon = new PictureBox();
                    icon.Left = 20;
                    icon.Top = 10;
                    icon.Height = 30;
                    icon.Width = 30;
                    icon.Image = Properties.Resources.folder_icon;
                    icon.SizeMode = PictureBoxSizeMode.StretchImage;
                    //icon.Image = catalogs[i].Шс
                    folder.Controls.Add(icon);
                    Label folder_name = new Label();
                    folder_name.Text = catalogs[i].Name;
                    folder_name.Font = new Font("Arial", 9, FontStyle.Regular);
                    folder_name.Left = 100;
                    folder_name.Top = 10;
                    folder.Controls.Add(folder_name);
                    folder.Tag = catalogs[i].FullName;
                    if (panel == panel1)
                    {
                        folder.DoubleClick += new EventHandler(key_to_open_to_1);
                    }
                    else
                    {
                        folder.DoubleClick += new EventHandler(key_to_open_to_2);
                    }
                    folder.MouseMove += new MouseEventHandler(Folder_Hover);
                    folder.MouseLeave += new EventHandler(Folder_no_Hover);
                }
                FileInfo[] files = DirectoryInfo.GetFiles();
                for (int j = 0; i < files.Length + catalogs.Length; i++, j++)
                {
                    Panel file = new Panel();
                    file.Top = i * 60;
                    file.Left = 0;
                    file.Width = 567;
                    file.Height = 60;
                    file.BackColor = Color.White;
                    //Когда сделаю выделение выпилить\/
                    file.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(file);
                    PictureBox file_icon = new PictureBox();
                    file_icon.Width = 30;
                    file_icon.Height = 30;
                    file_icon.Top = 10;
                    file_icon.Left = 10;
                    file_icon.Image = Properties.Resources.no_folder_icon;
                    file_icon.SizeMode = PictureBoxSizeMode.StretchImage;
                    file.Controls.Add(file_icon);
                    Label file_name = new Label();
                    file_name.Text = files[j].Name;
                    file_name.Top = 10;
                    file_name.Font = new Font("Arial", 9, FontStyle.Regular);
                    file_name.Left = 100;
                    file.Controls.Add(file_name);
                    file.Tag = files[j].FullName;
                    file.DoubleClick += new EventHandler(Open_To_exe);
                    file.MouseMove += new MouseEventHandler(no_Folder_Hover);
                    file.MouseLeave += new EventHandler(no_Folder_no_Hover);
                }
                if (panel == panel1)
                {
                    path_box_1.Text = path;
                    count_1.Text = $"Количество элементов:{files.Length + catalogs.Length}";
                    count_1.Visible = true;
                }
                else
                {
                    path_box_2.Text = path;
                    count_2.Text = $"Количество элементов:{files.Length + catalogs.Length}";
                    count_2.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show($"Не получилось открыть каталог\nпо пути {path}","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void Back_List_Add(Control panel)
        {
            if(panel == panel1)
            {
                back_list_1.Items.Add(panel.Tag);
                back_to_1.Enabled = true;
                if(back_list_1.Items.Count > 15)
                {
                    back_list_1.Items.RemoveAt(0);
                }
            }
            else
            {
                back_list_2.Items.Add(panel.Tag);
                back_to_2.Enabled = true;
                if (back_list_2.Items.Count > 15)
                {
                    back_list_2.Items.RemoveAt(0);
                }
            }
        }
        private void Search(Control panel,string path, string path_key)
        {
            try
            {
                int i = 0;
                DirectoryInfo = new DirectoryInfo(path);
                DirectoryInfo[] catalogs = DirectoryInfo.GetDirectories(path_key, SearchOption.AllDirectories);
            }
            catch
            {
                MessageBox.Show($"Не получилось поискать {path_key} по пути {path}");
            }
        }
        #endregion
        #region Общии переменые
        private DriveInfo[] drives = new DriveInfo[0];
        private string drag_path = "";
        private string right_path = "";

        #endregion

    }
}
