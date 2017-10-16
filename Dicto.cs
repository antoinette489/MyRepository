using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Dictofon
{
    class Dicto
    {
        public Recorder MedRec { get; set; }
        public Player MedPlay { get; set; }
        public List<string> mas_song { get; set; }
        public DirectoryInfo di { get; set; }
        public Battery bat { get; set; }
        public int timecount { get; set; }
        public string str { get; set; }
        public int min { get; set; }
        public int sec { get; set; }
        public Dicto()
        {
            MedRec = new Recorder();
            MedPlay = new Player();
            bat = new Battery();
            mas_song = new List<string>();
            di = new DirectoryInfo(Directory.GetCurrentDirectory());
            timecount = 0;
            min = 0;
            sec = 0;
        }
        public string FormatDate()
        {
            DateTime ThToday = DateTime.Now;
            string ThData = ThToday.ToString();
            return ThData;
        }
        public bool IsFullCharge()
        {
            if (bat.charge == 100)
                return true;
            else
                return false;
        }
        public bool ZeroCharge()
        {
            if (bat.charge <= 0)
                return true;
            else 
                return false;
        }
        public bool LowCharge()
        {
            if (bat.charge <= 5)
                return true;
            else
                return false;
        }
        public string ChargeInfo()
        {
            return bat.charge.ToString() + "%";
        }
        

    }
}
