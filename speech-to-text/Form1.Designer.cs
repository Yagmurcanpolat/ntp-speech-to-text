using System.Drawing;
using System.Windows.Forms;

namespace speech_to_text
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblLanguage = new Label();
            this.cmbLanguage = new ComboBox();
            this.btnStartStop = new Button();
            this.rtbText = new RichTextBox();
            this.lblStatus = new Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.ForeColor = Color.FromArgb(22, 26, 74);
            this.lblTitle.Location = new Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(230, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎤 Speech to Text";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblLanguage.ForeColor = Color.FromArgb(22, 26, 74);
            this.lblLanguage.Location = new Point(30, 75);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new Size(90, 20);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Dil Seçimi:";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] { "Türkçe (tr-TR)", "İngilizce (en-US)" });
            this.cmbLanguage.Location = new Point(130, 72);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new Size(200, 25);
            this.cmbLanguage.TabIndex = 2;
            this.cmbLanguage.SelectedIndex = 0;
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = Color.FromArgb(79, 148, 205);
            this.btnStartStop.FlatAppearance.BorderSize = 0;
            this.btnStartStop.FlatStyle = FlatStyle.Flat;
            this.btnStartStop.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnStartStop.ForeColor = Color.White;
            this.btnStartStop.Location = new Point(350, 65);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new Size(200, 40);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "▶ Kayda Başla";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += BtnStartStop_Click;
            // 
            // rtbText
            // 
            this.rtbText.BackColor = Color.White;
            this.rtbText.BorderStyle = BorderStyle.FixedSingle;
            this.rtbText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.rtbText.ForeColor = Color.FromArgb(22, 26, 74);
            this.rtbText.Location = new Point(30, 130);
            this.rtbText.Name = "rtbText";
            this.rtbText.ReadOnly = true;
            this.rtbText.Size = new Size(740, 280);
            this.rtbText.TabIndex = 4;
            this.rtbText.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblStatus.ForeColor = Color.Gray;
            this.lblStatus.Location = new Point(30, 425);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(136, 19);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "⏸ Kayıt bekleniyor...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(248, 249, 251);
            this.ClientSize = new Size(800, 470);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Speech to Text";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblLanguage;
        private ComboBox cmbLanguage;
        private Button btnStartStop;
        private RichTextBox rtbText;
        private Label lblStatus;
    }
}
