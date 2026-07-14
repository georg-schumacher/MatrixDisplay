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
            matrixDisplay.Location = new Point(8, 8);
            matrixDisplay.Name = "matrixDisplay";
            matrixDisplay.Size = new Size(1167, 100);
            matrixDisplay.TabIndex = 0;
            matrixDisplay.Paint += matrixDisplay_Paint;
            matrixDisplay.MouseDown += matrixDisplay_MouseDown;
            // 
            // btnSendeDaten
            // 
            btnSendeDaten.BackColor = Color.LightCoral;
            btnSendeDaten.Font = new Font("Segoe UI Emoji", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendeDaten.Location = new Point(8, 114);
            btnSendeDaten.Name = "btnSendeDaten";
            btnSendeDaten.Size = new Size(163, 102);
            btnSendeDaten.TabIndex = 1;
            btnSendeDaten.Text = "📯\nSende Daten\nan STM32\n(Hardware)";
            btnSendeDaten.UseVisualStyleBackColor = false;
            btnSendeDaten.Click += btnSendeDaten_Click;
            // 
            // btnScroll
            // 
            btnScroll.Font = new Font("Segoe UI Emoji", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScroll.Location = new Point(177, 114);
            btnScroll.Name = "btnScroll";
            btnScroll.Size = new Size(163, 102);
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
            grpColor.Location = new Point(370, 114);
            grpColor.Margin = new Padding(2, 2, 2, 2);
            grpColor.Name = "grpColor";
            grpColor.Padding = new Padding(2, 2, 2, 2);
            grpColor.Size = new Size(191, 102);
            grpColor.TabIndex = 3;
            grpColor.TabStop = false;
            grpColor.Text = "Farbe Vorgeben";
            // 
            // btnColorDialog
            // 
            btnColorDialog.Location = new Point(145, 24);
            btnColorDialog.Margin = new Padding(2, 2, 2, 2);
            btnColorDialog.Name = "btnColorDialog";
            btnColorDialog.Size = new Size(31, 68);
            btnColorDialog.TabIndex = 7;
            btnColorDialog.Text = "🎨";
            btnColorDialog.UseVisualStyleBackColor = true;
            btnColorDialog.Click += btnColorDialog_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(19, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 6;
            label3.Text = "BLAU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(19, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "GRÜN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(19, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 6;
            label1.Text = "ROT";
            // 
            // numBlau
            // 
            numBlau.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numBlau.Location = new Point(86, 70);
            numBlau.Margin = new Padding(2, 2, 2, 2);
            numBlau.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numBlau.Name = "numBlau";
            numBlau.Size = new Size(46, 27);
            numBlau.TabIndex = 0;
            numBlau.TextAlign = HorizontalAlignment.Right;
            numBlau.Value = new decimal(new int[] { 127, 0, 0, 0 });
            // 
            // numGruen
            // 
            numGruen.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numGruen.Location = new Point(86, 46);
            numGruen.Margin = new Padding(2, 2, 2, 2);
            numGruen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numGruen.Name = "numGruen";
            numGruen.Size = new Size(46, 27);
            numGruen.TabIndex = 0;
            numGruen.TextAlign = HorizontalAlignment.Right;
            numGruen.Value = new decimal(new int[] { 127, 0, 0, 0 });
            // 
            // numRot
            // 
            numRot.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numRot.Location = new Point(86, 22);
            numRot.Margin = new Padding(2, 2, 2, 2);
            numRot.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numRot.Name = "numRot";
            numRot.Size = new Size(46, 27);
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
            grpSpeichern.Location = new Point(601, 114);
            grpSpeichern.Margin = new Padding(2, 2, 2, 2);
            grpSpeichern.Name = "grpSpeichern";
            grpSpeichern.Padding = new Padding(2, 2, 2, 2);
            grpSpeichern.Size = new Size(254, 102);
            grpSpeichern.TabIndex = 4;
            grpSpeichern.TabStop = false;
            grpSpeichern.Text = "Laden 💾 Speichern";
            // 
            // labelDateiMitPfad
            // 
            labelDateiMitPfad.AutoSize = true;
            labelDateiMitPfad.Enabled = false;
            labelDateiMitPfad.Location = new Point(8, 72);
            labelDateiMitPfad.Margin = new Padding(2, 0, 2, 0);
            labelDateiMitPfad.Name = "labelDateiMitPfad";
            labelDateiMitPfad.Size = new Size(227, 21);
            labelDateiMitPfad.TabIndex = 1;
            labelDateiMitPfad.Text = "U:\\Dokumente\\Persistierung.txt";
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(139, 30);
            btnSpeichern.Margin = new Padding(2, 2, 2, 2);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(90, 26);
            btnSpeichern.TabIndex = 0;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // btnLaden
            // 
            btnLaden.Location = new Point(26, 30);
            btnLaden.Margin = new Padding(2, 2, 2, 2);
            btnLaden.Name = "btnLaden";
            btnLaden.Size = new Size(90, 26);
            btnLaden.TabIndex = 0;
            btnLaden.Text = "Laden";
            btnLaden.UseVisualStyleBackColor = true;
            // 
            // grpText
            // 
            grpText.Controls.Add(btnAufModulBringen);
            grpText.Controls.Add(textBox);
            grpText.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpText.Location = new Point(951, 114);
            grpText.Margin = new Padding(2, 2, 2, 2);
            grpText.Name = "grpText";
            grpText.Padding = new Padding(2, 2, 2, 2);
            grpText.Size = new Size(223, 102);
            grpText.TabIndex = 5;
            grpText.TabStop = false;
            grpText.Text = "Text-Eingabe";
            grpText.Enter += grpText_Enter;
            // 
            // btnAufModulBringen
            // 
            btnAufModulBringen.Location = new Point(11, 66);
            btnAufModulBringen.Margin = new Padding(2, 2, 2, 2);
            btnAufModulBringen.Name = "btnAufModulBringen";
            btnAufModulBringen.Size = new Size(198, 24);
            btnAufModulBringen.TabIndex = 1;
            btnAufModulBringen.Text = "auf Modul bringen";
            btnAufModulBringen.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            textBox.Location = new Point(11, 32);
            textBox.Margin = new Padding(2, 2, 2, 2);
            textBox.Name = "textBox";
            textBox.Size = new Size(199, 27);
            textBox.TabIndex = 0;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 222);
            Controls.Add(grpText);
            Controls.Add(grpSpeichern);
            Controls.Add(grpColor);
            Controls.Add(btnScroll);
            Controls.Add(btnSendeDaten);
            Controls.Add(matrixDisplay);
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
