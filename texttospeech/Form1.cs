using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace texttospeech
{
    public partial class Form1 : Form
    {

        SpeechSynthesizer ss = new SpeechSynthesizer();
        SpeechRecognitionEngine listen;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ss.SpeakAsync(richTextBox1.Text);
            ss.Speak(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text!=" ")
            {
                if(ss.State==SynthesizerState.Speaking)
                {
                    ss.Pause();
                }
                
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ss.Dispose();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != " ")
            {
                if (ss.State == SynthesizerState.Paused)
                {
                    ss.Resume();
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
           listen = new SpeechRecognitionEngine();
            Choices list = new Choices(File.ReadAllLines(@"listofwords.txt"));
            Grammar words = new Grammar(new GrammarBuilder(list));
            DictationGrammar dg = new DictationGrammar();
            try
            {
                richTextBox2.Text = "Listening**";
                listen.SetInputToDefaultAudioDevice();
                listen.LoadGrammar(words);
                listen.SpeechRecognized += speechrecognizedevent;
                listen.RecognizeAsync(RecognizeMode.Multiple);
                richTextBox2.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception : \n\n" + ex);
            }
        }

        private void speechrecognizedevent(object sender, SpeechRecognizedEventArgs e)
        {
            richTextBox2.Text = e.Result.Text;
        }

        private void stopstt_Click(object sender, EventArgs e)
        {
            listen.Dispose();
            this.Close();
        }
    }
}
