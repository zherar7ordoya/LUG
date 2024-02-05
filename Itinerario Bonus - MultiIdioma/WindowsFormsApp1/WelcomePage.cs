using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

// ****************************************************************************
// Description: MultiIdioma
// Developer/s: Gerardo Tordoya
// Create date: 2023-08-14
// Update date: 2023-08-17
// Forked from: https://github.com/tolgahantunc/multilingual-UI-winforms
// Observation: El video original https://youtu.be/r2MiAiU5foM no tiene código. 
//              Es por ello que realicé este fork.
// ****************************************************************************

namespace WindowsFormsApp1
{
    public partial class WelcomePage : Form
    {
        public static ResourceManager resourceManager;

        private int Contador = 0;
        private string Idioma = string.Empty;
        private static readonly string IdiomaActual = CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;

        public WelcomePage()
        {
            InitializeComponent();
            GetIdiomaActual();
            DialogResult respuesta = MessageBox.Show(resourceManager.GetString("LOC_UpdateUIObjectsText"), resourceManager.GetString("LOC_Warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) CambiarTexto();
        }

        private void GetIdiomaActual()
        {
            switch (IdiomaActual)
            {
                case "tr":
                    resourceManager = new ResourceManager("WindowsFormsApp1.Resources.lang_tr", Assembly.GetExecutingAssembly());
                    break;
                case "en":
                    resourceManager = new ResourceManager("WindowsFormsApp1.Resources.lang_en", Assembly.GetExecutingAssembly());
                    break;
                case "es":
                    resourceManager = new ResourceManager("WindowsFormsApp1.Resources.lang_es", Assembly.GetExecutingAssembly());
                    break;
                default:
                    break;
            }
        }

        private void Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            switch (combo.Text)
            {
                case "Türkçe":
                    resourceManager = new ResourceManager("WindowsFormsApp1.Resources.lang_tr", Assembly.GetExecutingAssembly());
                    Idioma = "TR";
                    break;
                case "English":
                    resourceManager = new ResourceManager("WindowsFormsApp1.Resources.lang_en", Assembly.GetExecutingAssembly());
                    Idioma = "EN";
                    break;
                case "Español":
                    resourceManager = new ResourceManager("WindowsFormsApp1.Resources.lang_es", Assembly.GetExecutingAssembly());
                    Idioma = "ES";
                    break;
                default:
                    break;
            }
        }

        private void CambiarTexto()
        {
            BotonAceptar.Text = resourceManager.GetString("LOC_Okay");
            BotonCancelar.Text = resourceManager.GetString("LOC_Cancel");
            BotonIncrementar.Text = resourceManager.GetString("LOC_Increase");
            BotonGuardar.Text = resourceManager.GetString("LOC_Save");
            BotonActualizar.Text = resourceManager.GetString("LOC_Refresh");
            EtiquetaContador.Text = string.Format(resourceManager.GetString("LOC_RemainingDays"), Contador, "çok");
        }

        private void BotonIncrementar_Click(object sender, EventArgs e)
        {
            Contador++;
            EtiquetaContador.Text = string.Format(resourceManager.GetString("LOC_RemainingDays"), Contador, "very");
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            //if app lang combobox selection is empty, show message and return
            if (string.IsNullOrEmpty(Idioma))
            {
                string mensaje = resourceManager.GetString("LOC_AppLanguageNotSelected");
                MessageBox.Show(mensaje);
                return;
            }

            Properties.Settings.Default.ApplicationLanguage = Idioma;
            Properties.Settings.Default.Save();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CambiarTexto();
        }
    }
}


