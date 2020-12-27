using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class fHome : Form
    {
        public static String text1;
        public static String text2;
        public fHome()
        {
            InitializeComponent();
            this.AcceptButton = btnPlay;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Hẹn gặp lại nha!", "Thông báo");
                    Application.Exit();
                    return true;
                }

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text1 = textBox1.Text;
            text2 = textBox2.Text;
            GameCaro game = new GameCaro();
            game.FormClosed += Game_FormClosed;
            game.Show();
            this.Hide();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn chắc chắn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                MessageBox.Show("Hẹn bạn gặp lại nha !", "Thông báo");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên đối thủ sẽ 'LUÔN LÀ TÊN BẠN NHẬP' dù đối thủ có nhập tên gì, tương tự với đối thủ của bạn :))", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
