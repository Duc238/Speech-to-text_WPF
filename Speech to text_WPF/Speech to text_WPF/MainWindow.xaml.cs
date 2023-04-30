using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Speech_to_text_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SpeechSynthesizer speechSynthesizer=new SpeechSynthesizer();
        PromptBuilder promptBuilder=new PromptBuilder();
        SpeechRecognitionEngine speechRecognitionEngine=new SpeechRecognitionEngine();
        Choices choices = new Choices();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;
            Grammar grammar=new DictationGrammar();
            try
            {
                speechRecognitionEngine.RequestRecognizerUpdate();
                speechRecognitionEngine.LoadGrammar(grammar);
                speechRecognitionEngine.SpeechRecognized += SpeechRecognitionEngine_SpeechRecognized;
                speechRecognitionEngine.SetInputToDefaultAudioDevice();
                speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void SpeechRecognitionEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            txtText.Text=txtText.Text+e.Result.Text.ToString()+Environment.NewLine;
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            speechRecognitionEngine.RecognizeAsyncStop();
            btnStart.IsEnabled=true;
            btnStop.IsEnabled=false;
        }
    }
}
