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
    }
}
