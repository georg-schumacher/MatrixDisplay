namespace MatrixDisplay
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
            components = new System.ComponentModel.Container();
            matrixDisplay = new DoubleBufferedPanel();
            btnSendeDaten = new Button();
            btnScroll = new Button();
            grpColor = new GroupBox();
            btnColorDialog = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numBlau = new NumericUpDown();
            numGruen = new NumericUpDown();
            numRot = new NumericUpDown();
            grpSpeichern = new GroupBox();
            labelDateiMitPfad = new Label();
            btnSpeichern = new Button();
            btnLaden = new Button();
            grpText = new GroupBox();
            btnAufModulBringen = new Button();
            textBox = new TextBox();
            colorDialog = new ColorDialog();
            timer = new System.Windows.Forms.Timer(components);
            grpColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBlau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGruen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRot).BeginInit();
            grpSpeichern.SuspendLayout();
            grpText.SuspendLayout();
            SuspendLayout();
            // 
            // matrixDisplay
            // 
            matrixDisplay.BackColor = Color.Black;
            matrixDisplay.Location = new Point(14, 15);
            matrixDisplay.Margin = new Padding(5, 6, 5, 6);
            matrixDisplay.Name = "matrixDisplay";
            matrixDisplay.Size = new Size(2000, 200);
            matrixDisplay.TabIndex = 0;
            matrixDisplay.Paint += matrixDisplay_Paint;
            matrixDisplay.MouseDown += matrixDisplay_MouseDown;
            // 
            // btnSendeDaten
            // 
            btnSendeDaten.BackColor = Color.LightCoral;
            btnSendeDaten.Font = new Font("Segoe UI Emoji", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendeDaten.Location = new Point(14, 227);
            btnSendeDaten.Margin = new Padding(5, 6, 5, 6);
            btnSendeDaten.Name = "btnSendeDaten";
            btnSendeDaten.Size = new Size(279, 204);
            btnSendeDaten.TabIndex = 1;
            btnSendeDaten.Text = "📯\nSende Daten\nan STM32\n(Hardware)";
            btnSendeDaten.UseVisualStyleBackColor = false;
            btnSendeDaten.Click += btnSendeDaten_Click;
            // 
            // btnScroll
            // 
            btnScroll.Font = new Font("Segoe UI Emoji", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScroll.Location = new Point(303, 227);
            btnScroll.Margin = new Padding(5, 6, 5, 6);
            btnScroll.Name = "btnScroll";
            btnScroll.Size = new Size(279, 204);
            btnScroll.TabIndex = 2;
            btnScroll.Text = "📜\nScrollen\n[Rotieren]\n(Software Emulation)";
            btnScroll.UseVisualStyleBackColor = true;
            // 
            // grpColor
            // 
            grpColor.Controls.Add(btnColorDialog);
            grpColor.Controls.Add(label3);
            grpColor.Controls.Add(label2);
            grpColor.Controls.Add(label1);
            grpColor.Controls.Add(numBlau);
            grpColor.Controls.Add(numGruen);
            grpColor.Controls.Add(numRot);
            grpColor.Font = new Font("Segoe UI Emoji", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpColor.Location = new Point(634, 227);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(327, 204);
            grpColor.TabIndex = 3;
            grpColor.TabStop = false;
            grpColor.Text = "Farbe Vorgeben";
            // 
            // btnColorDialog
            // 
            btnColorDialog.Location = new Point(249, 47);
            btnColorDialog.Name = "btnColorDialog";
            btnColorDialog.Size = new Size(54, 136);
            btnColorDialog.TabIndex = 7;
            btnColorDialog.Text = "🎨";
            btnColorDialog.UseVisualStyleBackColor = true;
            btnColorDialog.Click += btnColorDialog_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(33, 143);
            label3.Name = "label3";
            label3.Size = new Size(79, 36);
            label3.TabIndex = 6;
            label3.Text = "BLAU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(33, 95);
            label2.Name = "label2";
            label2.Size = new Size(89, 36);
            label2.TabIndex = 6;
            label2.Text = "GRÜN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(33, 47);
            label1.Name = "label1";
            label1.Size = new Size(65, 36);
            label1.TabIndex = 6;
            label1.Text = "ROT";
            // 
            // numBlau
            // 
            numBlau.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numBlau.Location = new Point(147, 141);
            numBlau.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numBlau.Name = "numBlau";
            numBlau.Size = new Size(78, 42);
            numBlau.TabIndex = 0;
            numBlau.TextAlign = HorizontalAlignment.Right;
            numBlau.Value = new decimal(new int[] { 127, 0, 0, 0 });
            // 
            // numGruen
            // 
            numGruen.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numGruen.Location = new Point(147, 93);
            numGruen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numGruen.Name = "numGruen";
            numGruen.Size = new Size(78, 42);
            numGruen.TabIndex = 0;
            numGruen.TextAlign = HorizontalAlignment.Right;
            numGruen.Value = new decimal(new int[] { 127, 0, 0, 0 });
            // 
            // numRot
            // 
            numRot.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numRot.Location = new Point(147, 45);
            numRot.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numRot.Name = "numRot";
            numRot.Size = new Size(78, 42);
            numRot.TabIndex = 0;
            numRot.TextAlign = HorizontalAlignment.Right;
            numRot.Value = new decimal(new int[] { 127, 0, 0, 0 });
            // 
            // grpSpeichern
            // 
            grpSpeichern.Controls.Add(labelDateiMitPfad);
            grpSpeichern.Controls.Add(btnSpeichern);
            grpSpeichern.Controls.Add(btnLaden);
            grpSpeichern.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpSpeichern.Location = new Point(1031, 227);
            grpSpeichern.Name = "grpSpeichern";
            grpSpeichern.Size = new Size(436, 204);
            grpSpeichern.TabIndex = 4;
            grpSpeichern.TabStop = false;
            grpSpeichern.Text = "Laden 💾 Speichern";
            // 
            // labelDateiMitPfad
            // 
            labelDateiMitPfad.AutoSize = true;
            labelDateiMitPfad.Enabled = false;
            labelDateiMitPfad.Location = new Point(13, 143);
            labelDateiMitPfad.Name = "labelDateiMitPfad";
            labelDateiMitPfad.Size = new Size(406, 38);
            labelDateiMitPfad.TabIndex = 1;
            labelDateiMitPfad.Text = "U:\\Dokumente\\Persistierung.txt";
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(238, 60);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(154, 52);
            btnSpeichern.TabIndex = 0;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // btnLaden
            // 
            btnLaden.Location = new Point(45, 60);
            btnLaden.Name = "btnLaden";
            btnLaden.Size = new Size(154, 52);
            btnLaden.TabIndex = 0;
            btnLaden.Text = "Laden";
            btnLaden.UseVisualStyleBackColor = true;
            // 
            // grpText
            // 
            grpText.Controls.Add(btnAufModulBringen);
            grpText.Controls.Add(textBox);
            grpText.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpText.Location = new Point(1631, 227);
            grpText.Name = "grpText";
            grpText.Size = new Size(383, 204);
            grpText.TabIndex = 5;
            grpText.TabStop = false;
            grpText.Text = "Text-Eingabe";
            // 
            // btnAufModulBringen
            // 
            btnAufModulBringen.Location = new Point(19, 131);
            btnAufModulBringen.Name = "btnAufModulBringen";
            btnAufModulBringen.Size = new Size(339, 48);
            btnAufModulBringen.TabIndex = 1;
            btnAufModulBringen.Text = "auf Modul bringen";
            btnAufModulBringen.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            textBox.Location = new Point(19, 65);
            textBox.Name = "textBox";
            textBox.Size = new Size(339, 42);
            textBox.TabIndex = 0;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2029, 443);
            Controls.Add(grpText);
            Controls.Add(grpSpeichern);
            Controls.Add(grpColor);
            Controls.Add(btnScroll);
            Controls.Add(btnSendeDaten);
            Controls.Add(matrixDisplay);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBlau).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGruen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRot).EndInit();
            grpSpeichern.ResumeLayout(false);
            grpSpeichern.PerformLayout();
            grpText.ResumeLayout(false);
            grpText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DoubleBufferedPanel matrixDisplay;
        private Button btnSendeDaten;
        private Button btnScroll;
        private GroupBox grpColor;
        private GroupBox grpSpeichern;
        private GroupBox grpText;
        private ColorDialog colorDialog;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numRot;
        private NumericUpDown numBlau;
        private NumericUpDown numGruen;
        private Button btnSpeichern;
        private Button btnLaden;
        private Label labelDateiMitPfad;
        private Button btnAufModulBringen;
        private TextBox textBox;
        private Button btnColorDialog;
        private System.Windows.Forms.Timer timer;
    }
}
