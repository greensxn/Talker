using NAudio.Lame;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace FormSayNumber {
    public partial class Form1 : Form {
        Color colorTheme = Color.MediumBlue;

        public Form1() {
            InitializeComponent();
        }

        private async void btnSay_Click(object sender, EventArgs e) {
            lbSubtext.Text = Talk.getNum(Area.Text);

            Talk.Voice Gender = getVoice(radioMan, radioWoman);
            await Talk.Say(Area.Text, Gender);
        }

        private async void btnSayBtwn_Click(object sender, EventArgs e) {
            if (btnSayBtwn.Text == "Stop") {
                Talk.StopSay();
                btnSayBtwn.Text = "Say";
                return;
            }

            Talk.Voice Gender = getVoice(radioMan, radioWoman);
            btnSayBtwn.Text = "Stop";
            await Talk.SayBetween(tb1b.Text, tb2b.Text, Convert.ToInt32(tbDelay.Text), Gender);
            btnSayBtwn.Text = "Say";
        }

        private Talk.Voice getVoice(RadioButton radioMan, RadioButton radioWoman) {
            if (radioMan.Checked)
                return Talk.Voice.Man;
            else
                return Talk.Voice.Woman;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e) {
            var btn = sender as RadioButton;
            btn.ForeColor = colorTheme;

            if (btn.Text == "Man") {
                radioWoman.Checked = false;
                radioMan.Checked = true;
                radioWoman.ForeColor = Color.Black;
            }
            else {
                radioMan.Checked = false;
                radioWoman.Checked = true;
                radioMan.ForeColor = Color.Black;
            }
        }

        private RadioButton getActiveRadBtn(RadioButton M, RadioButton W) {
            if (M.Checked)
                return M;
            else
                return W;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                colorTheme = colorDialog1.Color;

                Area.ForeColor = colorTheme;
                getActiveRadBtn(radioMan, radioWoman).ForeColor = colorTheme;
                lineNum.BackColor = colorTheme;
                btnSay.ForeColor = colorTheme;
                lbSubtext.ForeColor = colorTheme;

                tb1b.ForeColor = colorTheme;
                tb2b.ForeColor = colorTheme;
                lineB1.BackColor = colorTheme;
                lineB2.BackColor = colorTheme;
                btnSayBtwn.ForeColor = colorTheme;
                tbDelay.ForeColor = colorTheme;
                lineDelay.BackColor = colorTheme;
            }
        }

        private void tbDelay_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b')) {
                e.Handled = true;
            }
        }

        private void tbDelay_TextChanged(object sender, EventArgs e) {
            if (tbDelay.Text.Length < 1) tbDelay.Text = "0";
        }
    }
}
