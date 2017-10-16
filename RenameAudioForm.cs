using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictofon
{
    public partial class RenameAudioForm : Form
    {
        public string FileName { get; set; }
        public RenameAudioForm()
        {
            InitializeComponent();
            FileName = NameOfAudio.Text;
        }

        private void NameOfAudio_TextChanged(object sender, EventArgs e)
        {
            FileName = NameOfAudio.Text;
        }
    }
}
