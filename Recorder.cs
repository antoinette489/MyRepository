using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using System.Media;
using System.Windows.Forms;

namespace Dictofon
{
    class Recorder
    {
        public WaveIn waveIn { get; set; }
        //clas dlya zapisi v fail
        public WaveFileWriter writer { get; set; }
        public string outputFile { get; set; }
        public Recorder()
        {
            
        }
        public void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.WriteData(e.Buffer, 0, e.BytesRecorded);
        }
        private void StopRecording()
        {
            waveIn.StopRecording();
        }
        public void waveIn_RecordingStopped(object sender, EventArgs e)
        {
            waveIn.Dispose();
            waveIn = null;
            writer.Close();
            writer = null;
        }
        public bool StartRecord()
        {
            RenameAudioForm renameAudio = new RenameAudioForm();            
            
            string name = DateTime.Now.ToString("HH_mm_ss");
            renameAudio.NameOfAudio.Text = name;
            string ext = ".wav";
            if (renameAudio.ShowDialog() == DialogResult.OK)
            {
                name = renameAudio.FileName;
            }
            else return false;
            outputFile = name + ext;
            waveIn = new WaveIn();
            //Дефолтное устройство для записи (если оно имеется)
            waveIn.DeviceNumber = 0;
            //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
            waveIn.DataAvailable += waveIn_DataAvailable;
            //Прикрепляем обработчик завершения записи
            waveIn.RecordingStopped += waveIn_RecordingStopped;
            //Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
            waveIn.WaveFormat = new WaveFormat(8000, 1);
            //Инициализируем объект WaveFileWriter
            writer = new WaveFileWriter(outputFile, waveIn.WaveFormat);
            //Начало записи
            waveIn.StartRecording();
            return true;
        }
        public void StopRecord()
        {
            if (waveIn != null)
            {
                StopRecording();
            }
        }
    }
}
