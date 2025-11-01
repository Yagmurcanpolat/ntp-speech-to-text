using System.Speech.Recognition;

namespace speech_to_text
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine? recognitionEngine;
        private bool isRecording = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStartStop_Click(object? sender, EventArgs e)
        {
            if (!isRecording)
            {
                StartRecording();
            }
            else
            {
                StopRecording();
            }
        }

        private void StartRecording()
        {
            try
            {
                // Dil kodunu al
                string selectedLanguage = cmbLanguage.SelectedItem?.ToString() ?? "Türkçe (tr-TR)";
                string cultureCode = selectedLanguage.Contains("tr-TR") ? "tr-TR" : "en-US";

                // Speech Recognition Engine oluştur
                recognitionEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo(cultureCode));

                // Varsayılan dil modelini yükle
                recognitionEngine.LoadGrammar(new DictationGrammar());

                // Event handler'ları ayarla
                recognitionEngine.SpeechRecognized += RecognitionEngine_SpeechRecognized;
                recognitionEngine.SpeechHypothesized += RecognitionEngine_SpeechHypothesized;
                recognitionEngine.RecognizeCompleted += RecognitionEngine_RecognizeCompleted;

                // Kayda başla
                recognitionEngine.SetInputToDefaultAudioDevice();
                recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);

                // UI güncellemeleri
                isRecording = true;
                btnStartStop.BackColor = Color.FromArgb(220, 53, 69);
                btnStartStop.Text = "⏹ Kaydı Durdur";
                lblStatus.ForeColor = Color.FromArgb(40, 167, 69);
                lblStatus.Text = "🔴 Kayıt yapılıyor...";
                cmbLanguage.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}\n\nMikrofonun çalıştığından ve seçili dilin sistemde yüklü olduğundan emin olun.", 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopRecording()
        {
            try
            {
                if (recognitionEngine != null)
                {
                    recognitionEngine.RecognizeAsyncStop();
                    recognitionEngine.Dispose();
                    recognitionEngine = null;
                }

                // UI güncellemeleri
                isRecording = false;
                btnStartStop.BackColor = Color.FromArgb(79, 148, 205);
                btnStartStop.Text = "▶ Kayda Başla";
                lblStatus.ForeColor = Color.Gray;
                lblStatus.Text = "⏸ Kayıt durduruldu";
                cmbLanguage.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecognitionEngine_SpeechRecognized(object? sender, SpeechRecognizedEventArgs e)
        {
            // Tanınan konuşmayı textbox'a ekle
            if (!string.IsNullOrWhiteSpace(e.Result.Text))
            {
                // Ana thread'e güvenli erişim
                if (rtbText.InvokeRequired)
                {
                    rtbText.Invoke(new Action(() =>
                    {
                        rtbText.AppendText(e.Result.Text + " ");
                        rtbText.ScrollToCaret();
                    }));
                }
                else
                {
                    rtbText.AppendText(e.Result.Text + " ");
                    rtbText.ScrollToCaret();
                }
            }
        }

        private void RecognitionEngine_SpeechHypothesized(object? sender, SpeechHypothesizedEventArgs e)
        {
            // Geçici tanıma gösterimi (isteğe bağlı)
            if (!string.IsNullOrWhiteSpace(e.Result.Text) && lblStatus.InvokeRequired)
            {
                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.Text = $"🎤 Dinleniyor: {e.Result.Text}...";
                }));
            }
        }

        private void RecognitionEngine_RecognizeCompleted(object? sender, RecognizeCompletedEventArgs e)
        {
            // Kayıt tamamlandığında otomatik olarak devam eder
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopRecording();
            base.OnFormClosing(e);
        }
    }
}

