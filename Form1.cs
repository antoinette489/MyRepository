using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using System.Media;
namespace Dictofon
{
    // = new SoundPlayer(@"Song3.wav")
    public partial class Form1 : Form
    {
        Dicto dict;
        int min_end, sec_end;
        public Form1()
        {
            InitializeComponent();
            dict = new Dicto();
        }
        //Завершаем запись
        void StopRecording()
        {
            MessageBox.Show("StopRecording");
            dict.MedRec.waveIn.StopRecording();//?
        }
        //Окончание записи

        private void Start_Click(object sender, EventArgs e)
        {

            if (mode.Visible == true)
            {
                mode.Visible = false;
                timer3.Interval = 2000;
                timer4.Interval = 2000;
                label1.Focus();
                dict.timecount = 0;
                return;
            }
            nowplaysong.Text = "";
            try
            {

                if (!dict.MedRec.StartRecord()) return;
                dict.min = 0;
                dict.sec = 0;
                nowplay_time.Text = "00:00";
                timer2.Enabled = true;
                nowrecordsong.Text = dict.MedRec.outputFile;
                dict.timecount = 0;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
        //Прерываем запись
        private void Stop_Click(object sender, EventArgs e)
        {
            if (mode.Visible == true)
            {
                mode.Visible = false;
                timer3.Interval = 2000;
                timer4.Interval = 2000;
                label1.Select();
                dict.timecount = 0;
                return;
            }
            dict.MedRec.StopRecord();
            StreamWriter fout = new StreamWriter(nowrecordsong.Text + ".txt");
            fout.Write(dict.min + ":" + dict.sec);
            fout.Close();
            listBox1.Items.Clear();
            dict.mas_song = new List<string>();
            foreach (var fi in dict.di.GetFiles("*.wav"))
            {

                dict.mas_song.Add(fi.Name);

            }
            foreach (var tmp in dict.mas_song)
            {

                listBox1.Items.Add(tmp);

            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            nowrecordsong.Text = "";
            nowplay_time.Text = "";
            timer2.Enabled = false;
         
    
            dict.timecount = 0;
        }
        
        public void repeat_play_func()
        {
            dict.str = @Convert.ToString(dict.mas_song[listBox1.SelectedIndex]);
            nowplaysong.Clear();
            nowplaysong.Text += dict.str;
            dict.MedPlay.LoadFile(dict.str);
            dict.MedPlay.Play();
        }
        private void Play_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) return;
            if (mode.Visible == true)
            {
                mode.Visible = false;
                timer3.Interval = 2000;
                timer4.Interval = 2000;
                label1.Focus();
                dict.timecount = 0;
                return;
            }
            nowplay_time.Text = "";
            repeat_play_func();
            dict.min = 0;
            dict.sec = 0;
            nowplay_time.Text = "00:00";
            StreamReader fin = new StreamReader(nowplaysong.Text + ".txt");
            string[] data = fin.ReadLine().Split(':');
            fin.Close();
            min_end = int.Parse(data[0]);
            sec_end = int.Parse(data[1]);
            if (data[0].Length < 2) data[0] = "0" + data[0];
            if (data[1].Length < 2) data[1] = "0" + data[1];
            //now_play_end_time.Text = data[0] + ":" + data[1];
            timer2.Enabled = true;

            dict.timecount = 0;
        }

        private void Pause_song_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) return;
            if (mode.Visible == true)
            {
                mode.Visible = false;
                timer3.Interval = 2000;
                timer4.Interval = 2000;
                label1.Select();
                dict.timecount = 0;
                return;
            }
            dict.MedPlay.Stop();
            timer2.Stop();
            nowplaysong.Clear();
            nowplay_time.Clear();

            nowplay_time.Text = "";
            //now_play_end_time.Text = "";
            dict.timecount = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Timer timer1 = new Timer();
            // Timer timer3 = new Timer();
            //Timer timer44 = new Timer();
            timer3.Tick += new EventHandler(timer3_Tick);
            timer1.Tick += new EventHandler(timer1_Tick);

            timer3.Interval = 2000;
            timer1.Interval = 100;

            timer1.Start();
            timer3.Start();
            label1.Select();

            // now_time.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff");

            foreach (var fi in dict.di.GetFiles("*.wav"))
            {
                dict.mas_song.Add(fi.Name);
            }
            foreach (var tmp in dict.mas_song)
            {
                listBox1.Items.Add(tmp);
            }
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }

        private void arrow_down_Click(object sender, EventArgs e)
        {
            if (mode.Visible == true)
            {
                mode.Visible = false;
                timer3.Interval = 2000;
                timer4.Interval = 2000;
                label1.Select();
                dict.timecount = 0;
                return;
            }
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedIndex != listBox1.Items.Count - 1)
                listBox1.SelectedIndex++;
            dict.timecount = 0;
        }

        private void arrow_up_Click(object sender, EventArgs e)
        {
            if (mode.Visible == true)
            {
                mode.Visible = false;
                timer3.Interval = 2000;
                timer4.Interval = 2000;
                label1.Select();
                dict.timecount = 0;
                return;
            }
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedIndex != 0)
                listBox1.SelectedIndex--;
            dict.timecount = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.now_time.Text = dict.FormatDate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
       
            dict.sec++;
            if (dict.sec == 60)
            {
                dict.sec = 0;
                dict.min++;
            }
            string mins = dict.min.ToString();
            if (dict.min < 10)
                mins = "0" + mins;
            string secs = dict.sec.ToString();
            if (dict.sec < 10)
                secs = "0" + secs;
            nowplay_time.Text = mins + ":" + secs;
            if (dict.min == min_end && dict.sec == sec_end)
            {
                if (listBox1.Items.Count == 0) return;
                if (mode.Visible == true)
                {
                    mode.Visible = false;
                    label1.Select();
                    dict.timecount = 0;
                    return;
                }
                dict.MedPlay.Stop();
                timer2.Stop();
                //nowplaysong.Clear();
                //nowplay_time.Clear();

                //nowplay_time.Text = "";
                //now_play_end_time.Text = "";
                dict.timecount = 0;
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) return;
            if (mode.Visible == true)
            {
                mode.Visible = false;
                label1.Select();
                dict.timecount = 0;
                return;
            }
            DialogResult dialogres = MessageBox.Show(this, "Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dialogres == DialogResult.Yes)
            {
                nowplaysong.Text = "";
                nowrecordsong.Text = "";
                nowplay_time.Text = "";
                timer2.Enabled = false;
                File.Delete(listBox1.SelectedItem.ToString());
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                if (listBox1.Items.Count > 0)
                {
                    if (index == 0) listBox1.SelectedIndex = index;
                    else listBox1.SelectedIndex = index - 1;
                }

            }
            dict.timecount = 0;
        }

        
        private void timer3_Tick(object sender, EventArgs e)
        {

            dict.bat.charge--;
            if (dict.ZeroCharge())
            {
                dict.bat.charge = 0;
                timer3.Stop();
            }
            label2.Text = dict.ChargeInfo();
            dict.bat.charge.ToString();
            if (dict.LowCharge())
            {
                mode.Visible = true;
                timer3.Interval = 4000;
                charging.Visible = true;
                Start.Enabled = false;
                Stop.Enabled = false;
                Play.Enabled = false;
                Pause_song.Enabled = false;
                arrow_down.Enabled = false;
                arrow_up.Enabled = false;
                DELETE.Enabled = false;
            }
            //else
            //{
            //    mode.Visible = false;
            //    charging.Visible = false;
            //}

        }


        private void timer4_Tick(object sender, EventArgs e)
        {

            if (dict.IsFullCharge())
            {
                timer4.Stop();
                lightn.Visible = false;
                timer3.Interval = 2000;
                timer3.Start();
            }
            else
            {
                dict.bat.charge++;
                label2.Text = dict.ChargeInfo();
                dict.bat.charge.ToString();

            }
        }

        private void charging_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer4.Tick += new EventHandler(timer4_Tick);
            timer4.Interval = 3000;
            mode.Visible = false;
            timer4.Start();
            charging.Visible = false;
            lightn.Visible = true;
            timer5.Enabled = true;
            Start.Enabled = true;
            Stop.Enabled = true;
            Play.Enabled = true;
            Pause_song.Enabled = true;
            arrow_down.Enabled = true;
            arrow_up.Enabled = true;
            DELETE.Enabled = true;
        }
 
        private void timer5_Tick(object sender, EventArgs e)
        {

            dict.timecount++;
            if (dict.timecount == 30)
            {
                dict.timecount = 0;
                mode.Visible = true;
                timer3.Interval = 4000;
                timer4.Interval = 4000;

            }
        }

        
    }
}
