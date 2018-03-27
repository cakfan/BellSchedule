using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBellSchedule
{
    public partial class alert : Form
    {
        public alert(string pesannya, AlertType type)
        {
            InitializeComponent();

            pesan.Text = pesannya;
            switch (type) {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = imageList1.Images[0];
                    break;
                case AlertType.info:
                    this.BackColor = Color.Gray;
                    icon.Image = imageList1.Images[0];
                    break;
                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    icon.Image = imageList1.Images[0];
                    break;
                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    icon.Image = imageList1.Images[1];
                    break;
            }
        }

        public static void Show(string pesan, AlertType type)
        {
            new NewBellSchedule.alert(pesan,type).Show();
        }

        public enum AlertType
        {
            success, info, warning, error
        }

        private void alert_Load(object sender, EventArgs e)
        {
            this.Top = 60;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            tampil.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tutup.Start();
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            tutup.Start();
        }

        int interval = 0;

        private void tampil_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                tampil.Stop();
            }
        }

        private void tutup_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity-=0.1;
            }
            else
            {
                this.Close();
            }
        }

    }
}
