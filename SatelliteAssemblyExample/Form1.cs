using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SatelliteAssemblyExample
{
    //https://www.codeproject.com/Articles/352105/Satellite-Assembly-Example-in-Csharp-Step-by-Step
    public partial class Form1 : Form
    {
        readonly System.Resources.ResourceManager _resourceManager = new System.Resources.ResourceManager("SatelliteAssemblyExample.string", Assembly.GetExecutingAssembly());
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeCulture(string sLangCode)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(sLangCode);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(sLangCode);
            lblMultiLangResult.Text = _resourceManager.GetString("lblResult");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbLanguage.Items.Add("Ingliș");
            cmbLanguage.Items.Add("Franțuzăște");
            cmbLanguage.Items.Add("Hitaliană");
            cmbLanguage.Items.Add("Rusăște");
            cmbLanguage.Items.Add("Iapaneză");
            ChangeCulture("en-US");
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sLangCode;
            if (cmbLanguage.SelectedIndex == 0)
            {
                sLangCode = "en-US";
                ChangeCulture(sLangCode);
            }
            else if (cmbLanguage.SelectedIndex == 1)
            {
                sLangCode = "fr-FR";
                ChangeCulture(sLangCode);
            }
            else if (cmbLanguage.SelectedIndex == 2)
            {
                sLangCode = "it";
                ChangeCulture(sLangCode);
            }
            else if (cmbLanguage.SelectedIndex == 3)
            {
                sLangCode = "ru";
                ChangeCulture(sLangCode);
            }
            else if (cmbLanguage.SelectedIndex == 4)
            {
                sLangCode = "ja";
                ChangeCulture(sLangCode);
            }
        }

        void Fibonacci(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number) Fibonacci(b, a + b, counter + 1, number);
        }


        private void CalculateFibonacciButton(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            backgroundWorker1.RunWorkerAsync(); // Start the BackgroundWorker.
        }

        //https://www.dotnetperls.com/backgroundworker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker1 = sender as BackgroundWorker;

            for (int j = 0; j < 100; j++)
            {
                Fibonacci(0, 1, 1, 1000);
                Thread.Sleep(500);

                // Use progress to notify UI thread that progress has
                // changed
                backgroundWorker1.ReportProgress((j+1)*100 / 100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            // Set the text.
            this.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Done!");
        }
    }
}
