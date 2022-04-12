using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuckTiktok
{
    public partial class MainForm : Form
    {
        public string[] users = null;
        public bool random_check = true;
        readonly Tiktok tik = new Tiktok();
        public static bool is_busy = false;
        bool is_busy_temp = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                bool Messageable = false;
                string[] Message = new string[1];
                if (File.Exists("cookie.txt"))
                {
                    string Cookie = File.ReadAllText("cookie.txt");
                    if (Cookie.Trim() != "")
                    {
                        tik.Cookies = Cookie;
                    }
                    else
                    {
                        Message = new string[] { "Empty Cookie", "Please Update cookie.txt File before you using the checker :(" };
                        Messageable = true;
                    }
                }
                else
                {
                    File.Create("cookie.txt");
                    Message = new string[] { "Not found", "cookie.txt file not found , anyway i created it please update it with cookie from your session" };
                    Messageable = true;
                }

                if (Messageable)
                {
                    MessageBox.Show(Message[1], Message[0], MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                if (File.Exists(".env"))
                {
                    string[] Settings = File.ReadAllText(".env").Split('|');
                    if (Settings.Length == 2)
                    {
                        Tiktok.token = Settings[0];
                        Tiktok.id = Settings[1];
                    }
                }
                tik.CountThreading = 5;
                Worker.RunWorkerAsync();

            }
            catch
            {
                MessageBox.Show("Error", "Something is went wrong while the main form is loading, Please contact the owner @yu5uy for solving this problem");
                Application.Exit();
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (char x in "Starting Main Thread ...")
            {
                StatusLabel.Invoke(new Action(() => StatusLabel.Text += x.ToString()));
                System.Threading.Thread.Sleep(100);
            }
            System.Threading.Thread.Sleep(1000);
            MainPanel.Invoke(new Action(() => MainPanel.Visible = true));
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (is_busy_temp)
            {
                is_busy_temp = false;
                return;
            }
            if (is_busy)
            {
                MessageBox.Show("Program is busy right now, Please stop it !","Busy",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                is_busy_temp = true;
                if (radioButton1.Checked) radioButton2.Checked = true; else radioButton1.Checked = true; ;
                return;
            }
            if (radioButton1.Checked)
            {
                RandomLength.Enabled = false;
                LabelRandomLength.Text = "-";
                using (OpenFileDialog file = new OpenFileDialog())
                {
                    file.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    file.Title = "Choose Users file";
                    file.AddExtension = true;
                    file.Filter = "Users file (*.txt)|*.txt";
                    file.Multiselect = false;
                    file.ShowDialog();
                    if (string.IsNullOrEmpty(file.FileName))
                    {
                        radioButton2.Checked = true;
                        MessageBox.Show("You have not select any file !","Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LengthUsers.Text = "Unlimited";

                    }
                    else
                    {
                        this.users = File.ReadAllLines(file.FileName);
                        LengthUsers.Text = this.users.Length.ToString();
                        this.random_check = false;
                    }
                }
            }
            else
            {
                LabelRandomLength.Text = tik.RandomLength.ToString();
                RandomLength.Enabled = true;
                LengthUsers.Text = "Unlimited";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!is_busy)
            {
                tik.setup();
                button1.Text = "Stop";
                StateLabel.Text = "Started";
                tik.requestCanellation = false;
                MainWorker.RunWorkerAsync();
                is_busy = true;
            }
            else
            {
                button1.Text = "Start check";
                StateLabel.Text = "Stopped";
                tik.requestCanellation = true;
                MainWorker.CancelAsync();
                is_busy = false;
            }
        }

        private async void MainWorker_DoWork(object sender, DoWorkEventArgs e)
        { 
            await tik.StartTasks(Checked, StateLabel,Valid,Bad,Unknown,button1,ResultArea, random_check, this.users);
        }

        private void customTrackBar1_Scroll(object sender, EventArgs e)
        {
            tik.CountThreading = ThreadCounts.Value;
            LabelThreadCounts.Text = ThreadCounts.Value.ToString();
        }

        private void RandomLength_Scroll(object sender, EventArgs e)
        {
            tik.RandomLength = RandomLength.Value;
            LabelRandomLength.Text = RandomLength.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Lime,0,8,0,Height - 2);
        }
    }
}
