namespace NguyenDuyManh_Tuan03
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.digitalClocks1 = new Control.DigitalClocks();
            this.SuspendLayout();
            // 
            // digitalClocks1
            // 
            this.digitalClocks1.Location = new System.Drawing.Point(61, 68);
            this.digitalClocks1.Name = "digitalClocks1";
            this.digitalClocks1.Size = new System.Drawing.Size(150, 150);
            this.digitalClocks1.TabIndex = 0;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.digitalClocks1);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Control.DigitalClocks digitalClocks1;

       
    }
}