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
            matrixDisplay = new Panel();
            SuspendLayout();
            // 
            // matrixDisplay
            // 
            matrixDisplay.BackColor = Color.Black;
            matrixDisplay.Location = new Point(12, 50);
            matrixDisplay.Name = "matrixDisplay";
            matrixDisplay.Size = new Size(320, 320);
            matrixDisplay.TabIndex = 0;
            matrixDisplay.Paint += matrixDisplay_Paint;
            matrixDisplay.MouseDown += matrixDisplay_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(matrixDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel matrixDisplay;
    }
}
