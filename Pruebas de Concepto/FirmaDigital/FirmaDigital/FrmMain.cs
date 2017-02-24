using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.Cms;
using System.IO;
using iTextSharp.text.xml.xmp;
using iTextSharp.text.pdf.security;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace FirmaDigital
{
    public partial class FrmMain : Form
    {
        X509Store store;
        X509Certificate2 cert;
        X509Certificate2Collection fcollection;

        public FrmMain()
        {
            InitializeComponent();
        }


        private void debug(string txt)
        {
            DebugBox.AppendText(txt + System.Environment.NewLine);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;
            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.Filter = "PDF files *.pdf|*.pdf";
            openFile.Title = "Select a file";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            inputBox.Text = openFile.FileName;
            
            PdfReader reader = new PdfReader(inputBox.Text);
            string xmlValue;

            authorBox.Text = reader.Info.ContainsKey("Author") ? reader.Info["Author"] : "";
            titleBox.Text = reader.Info.ContainsKey("Title") ? reader.Info["Title"] : "";
            subjectBox.Text = reader.Info.ContainsKey("Subject") ? reader.Info["Subject"] : "";
            if (reader.Info.TryGetValue("Keywords", out xmlValue))
            {
                kwBox.Text = xmlValue;
            }
            creatorBox.Text = reader.Info.ContainsKey("Creator") ? reader.Info["Creator"] : "";
            prodBox.Text = reader.Info.ContainsKey("Producer") ? reader.Info["Producer"] : "";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFile;
            saveFile = new System.Windows.Forms.SaveFileDialog();            
            saveFile.Filter = "PDF files (*.pdf)|*.pdf";
            saveFile.Title = "Save PDF File";
            if (saveFile.ShowDialog() != DialogResult.OK)
                return;
            outputBox.Text = saveFile.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CHEQUEAR CONFIGURACION
            // CHEQUEAR LOS CAMPOS CARGADOS
            debug("Iniciando ...");
            try
            {
                /*
                X509Store store = new X509Store("MY", StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
                X509Certificate2Collection fcollection = (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
                X509Certificate2Collection scollection = X509Certificate2UI.SelectFromCollection(fcollection, "Test Certificate Select", "Select a certificate from the following list to get information on that certificate", X509SelectionFlag.MultiSelection);
                X509Certificate2 cert = scollection[0];
                 */
                X509Certificate2Collection scollection = X509Certificate2UI.SelectFromCollection(fcollection, "Test Certificate Select", "Select a certificate from the following list to get information on that certificate", X509SelectionFlag.MultiSelection);
                cert = scollection[0];
                
                debug("Certificado OK");
           
                PdfReader reader = new PdfReader(this.inputBox.Text);

                string SourcePdfFileName = this.inputBox.Text;
                string DestPdfFileName = ConfiguracionRutaDestino.Text + "\\" + Path.GetFileName(this.inputBox.Text);  //this.outputBox.Text;
                Org.BouncyCastle.X509.X509CertificateParser cp = new Org.BouncyCastle.X509.X509CertificateParser();
                Org.BouncyCastle.X509.X509Certificate[] chain = new Org.BouncyCastle.X509.X509Certificate[] { cp.ReadCertificate(cert.RawData) };

                IExternalSignature externalSignature = new X509Certificate2Signature(cert, "SHA-1");
                PdfReader pdfReader = new PdfReader(SourcePdfFileName);
                FileStream signedPdf = new FileStream(DestPdfFileName, FileMode.Create);  //the output pdf file
                PdfStamper pdfStamper = PdfStamper.CreateSignature(pdfReader, signedPdf, '\0');

                PdfSignatureAppearance sap = pdfStamper.SignatureAppearance;

                debug("Creating new MetaData ... ");
                Dictionary<String, String> info = reader.Info;
                info["Producer"] = prodBox.Text;
                info["Title"] = titleBox.Text;
                info["Subject"] = subjectBox.Text;
                info["Keywords"] = kwBox.Text;
                info["Creator"] = creatorBox.Text;
                info["Author"] = authorBox.Text;

                pdfStamper.XmpMetadata = ObjectToByteArray(info);

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance("firma.png");
                //image.SetAbsolutePosition(10, 10);
                
                PdfSignatureAppearance signatureAppearance = pdfStamper.SignatureAppearance;

                int lastPage = pdfReader.NumberOfPages;

                signatureAppearance.SetVisibleSignature(new iTextSharp.text.Rectangle(100, 10, 250, 150), lastPage, "GRAPHIC");
                signatureAppearance.SignatureGraphic = image;
                signatureAppearance.SignatureRenderingMode = PdfSignatureAppearance.RenderingMode.GRAPHIC;

                debug("Signing document ... ");
                MakeSignature.SignDetached(signatureAppearance, externalSignature, chain, null, null, null, 0, CryptoStandard.CMS);
                pdfStamper.Close();
                debug("Done :)");
            }
            catch (Exception ex)
            {
                debug("Error : Ocurrió el siguiente error:");
                debug(ex.ToString());
                return;
            }
        }

        private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openFile;
                openFile = new System.Windows.Forms.OpenFileDialog();
                openFile.Filter = "PDF files *.pdf|*.pdf";
                openFile.Title = "Seleccione un archivo";
                if (openFile.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                this.btnLimpiar_Click(sender, e);

                inputBox.Text = openFile.FileName;

                PdfReader reader = new PdfReader(inputBox.Text);
                string xmlValue;

                authorBox.Text = reader.Info.ContainsKey("Author") ? reader.Info["Author"] : "";
                titleBox.Text = reader.Info.ContainsKey("Title") ? reader.Info["Title"] : "";
                subjectBox.Text = reader.Info.ContainsKey("Subject") ? reader.Info["Subject"] : "";
                if (reader.Info.TryGetValue("Keywords", out xmlValue))
                {
                    kwBox.Text = xmlValue;
                }
                creatorBox.Text = reader.Info.ContainsKey("Creator") ? reader.Info["Creator"] : "";
                prodBox.Text = reader.Info.ContainsKey("Producer") ? reader.Info["Producer"] : "";

                this.HabilitarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error: " + ex, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.inputBox.Text = "";
            this.outputBox.Text = "";
            this.authorBox.Text = "";
            this.titleBox.Text = "";
            this.subjectBox.Text = "";
            this.kwBox.Text = "";
            this.creatorBox.Text = "";
            this.prodBox.Text = "";

            //Read Only los campos
            this.authorBox.ReadOnly = true;
            this.titleBox.ReadOnly = true;
            this.subjectBox.ReadOnly = true;
        }

        private void HabilitarControles() 
        {
            this.authorBox.ReadOnly = false;
            this.titleBox.ReadOnly = false;
            this.subjectBox.ReadOnly = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                store = new X509Store("MY", StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
                fcollection = (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);

                this.SetDefaultSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error: " + ex, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void SetDefaultSettings()
        {
            //Levanta las configuraciones del archivo .config
            string targetPath = ConfigurationManager.AppSettings["TargetPath"];
            this.ConfiguracionRutaDestino.Text = targetPath;
            this.SigVisible.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["VisibleSign"].ToString());
            this.filePrefix.Text = ConfigurationManager.AppSettings["FilePrefix"]; 
            this.fileSufix.Text = ConfigurationManager.AppSettings["FileSufix"]; 
        }

        private void btnAbrirRutaDestino_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDlg.ShowDialog();
            if( result == DialogResult.OK )
            {
                string folderName = folderBrowserDlg.SelectedPath;
                this.ConfiguracionRutaDestino.Text = folderName;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string targetPath = this.ConfiguracionRutaDestino.Text;
            string sigVisible = this.SigVisible.Checked.ToString();
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["TargetPath"].Value = targetPath;
            config.AppSettings.Settings["VisibleSign"].Value = sigVisible;
            config.Save(ConfigurationSaveMode.Minimal);

        }

        private void btnDescartarCambios_Click(object sender, EventArgs e)
        {
            this.SetDefaultSettings();
        }

        private void btnLimpiarFirmar_Click(object sender, EventArgs e)
        {
            this.Reasontext.Text = "";
            this.Contacttext.Text = "";
            this.Locationtext.Text = "";
            this.DebugBox.Text = "";
        }
    }
}