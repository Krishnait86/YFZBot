using System.Drawing;
using System.Windows.Forms;

namespace YFBot.Capture {
    public partial class CaptureForm : Form {
        public CaptureForm() {
            InitializeComponent();

            // делаем рабочую областьо окна прозрачной
            AllowTransparency = true;
            BackColor = Color.Green;
            TransparencyKey = BackColor;
        }


        // при нажатии на кнопку закрыть окно, просто скрываем его
        private void CaptureForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            Hide();
        }
    }
}
