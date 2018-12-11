namespace SatelliteAssemblyExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMultiLangResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblMultiLangResultImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblMultiLangResultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(257, 350);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(178, 39);
            this.cmbLanguage.TabIndex = 0;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.CmbLanguage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Language";
            // 
            // lblMultiLangResult
            // 
            this.lblMultiLangResult.AutoSize = true;
            this.lblMultiLangResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMultiLangResult.Location = new System.Drawing.Point(88, 419);
            this.lblMultiLangResult.Name = "lblMultiLangResult";
            this.lblMultiLangResult.Size = new System.Drawing.Size(236, 31);
            this.lblMultiLangResult.TabIndex = 2;
            this.lblMultiLangResult.Text = "lblMultiLangResult";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(169, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Do some hard work, go, now !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateFibonacciButton);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(579, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 42);
            this.progressBar1.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblMultiLangResultImage
            // 
            this.lblMultiLangResultImage.Location = new System.Drawing.Point(257, 410);
            this.lblMultiLangResultImage.Name = "lblMultiLangResultImage";
            this.lblMultiLangResultImage.Size = new System.Drawing.Size(100, 50);
            this.lblMultiLangResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblMultiLangResultImage.TabIndex = 5;
            this.lblMultiLangResultImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 529);
            this.Controls.Add(this.lblMultiLangResultImage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMultiLangResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLanguage);
            this.Name = "Form1";
            this.Text = "Satellite assembly example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblMultiLangResultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMultiLangResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox lblMultiLangResultImage;
    }
}

