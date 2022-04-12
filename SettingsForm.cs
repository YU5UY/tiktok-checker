using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuckTiktok
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Lime, 0, 0, Width - 1, Height - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Either id , token are Required to save changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Tiktok.token = textBox1.Text;
            Tiktok.id = textBox2.Text;
            System.IO.File.WriteAllText(".env", $"{textBox1.Text.Trim()}|{textBox2.Text.Trim()}");
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(".env"))
            {
                string[] Settings = System.IO.File.ReadAllText(".env").Split('|');
                if (Settings.Length == 2)
                {
                    textBox1.Text = Settings[0];
                    textBox2.Text = Settings[1];
                }
            }
        }
    }
}
