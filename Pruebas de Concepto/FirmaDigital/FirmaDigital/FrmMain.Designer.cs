﻿namespace FirmaDigital
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prodBox = new System.Windows.Forms.TextBox();
            this.creatorBox = new System.Windows.Forms.TextBox();
            this.kwBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DebugBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Locationtext = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Contacttext = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Reasontext = new System.Windows.Forms.TextBox();
            this.btnFirmar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SigVisible = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnDescartarCambios = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAbrirRutaDestino = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.ConfiguracionRutaDestino = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.filePrefix = new System.Windows.Forms.TextBox();
            this.fileSufix = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimpiarFirmar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 364);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Archivo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.prodBox);
            this.groupBox1.Controls.Add(this.creatorBox);
            this.groupBox1.Controls.Add(this.kwBox);
            this.groupBox1.Controls.Add(this.subjectBox);
            this.groupBox1.Controls.Add(this.titleBox);
            this.groupBox1.Controls.Add(this.authorBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 191);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2- MetaData PDF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Productor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Creador:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Keywords: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Asunto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Título:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autor:";
            // 
            // prodBox
            // 
            this.prodBox.Location = new System.Drawing.Point(75, 148);
            this.prodBox.Name = "prodBox";
            this.prodBox.ReadOnly = true;
            this.prodBox.Size = new System.Drawing.Size(620, 20);
            this.prodBox.TabIndex = 3;
            // 
            // creatorBox
            // 
            this.creatorBox.Location = new System.Drawing.Point(75, 122);
            this.creatorBox.Name = "creatorBox";
            this.creatorBox.ReadOnly = true;
            this.creatorBox.Size = new System.Drawing.Size(620, 20);
            this.creatorBox.TabIndex = 3;
            // 
            // kwBox
            // 
            this.kwBox.Location = new System.Drawing.Point(75, 96);
            this.kwBox.Name = "kwBox";
            this.kwBox.ReadOnly = true;
            this.kwBox.Size = new System.Drawing.Size(620, 20);
            this.kwBox.TabIndex = 3;
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(75, 70);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.ReadOnly = true;
            this.subjectBox.Size = new System.Drawing.Size(620, 20);
            this.subjectBox.TabIndex = 2;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(75, 44);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(620, 20);
            this.titleBox.TabIndex = 1;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(75, 19);
            this.authorBox.Name = "authorBox";
            this.authorBox.ReadOnly = true;
            this.authorBox.Size = new System.Drawing.Size(620, 20);
            this.authorBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 46);
            this.panel2.TabIndex = 23;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.ImageIndex = 9;
            this.btnLimpiar.ImageList = this.imageList1;
            this.btnLimpiar.Location = new System.Drawing.Point(639, 10);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 28);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.inputBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAbrirArchivo);
            this.groupBox2.Controls.Add(this.outputBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 91);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1- Documento PDF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Destino:";
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputBox.Location = new System.Drawing.Point(75, 29);
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.Size = new System.Drawing.Size(585, 20);
            this.inputBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Origen:";
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirArchivo.ImageIndex = 7;
            this.btnAbrirArchivo.ImageList = this.imageList1;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(666, 29);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(29, 20);
            this.btnAbrirArchivo.TabIndex = 14;
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(75, 55);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(620, 20);
            this.outputBox.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DebugBox);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(715, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Firmar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DebugBox
            // 
            this.DebugBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DebugBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugBox.Location = new System.Drawing.Point(3, 140);
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugBox.Size = new System.Drawing.Size(709, 191);
            this.DebugBox.TabIndex = 30;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLimpiarFirmar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.Locationtext);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Contacttext);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.Reasontext);
            this.groupBox4.Controls.Add(this.btnFirmar);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(709, 328);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3- Firma";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Locación:";
            // 
            // Locationtext
            // 
            this.Locationtext.Location = new System.Drawing.Point(72, 82);
            this.Locationtext.Name = "Locationtext";
            this.Locationtext.Size = new System.Drawing.Size(630, 20);
            this.Locationtext.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Contacto:";
            // 
            // Contacttext
            // 
            this.Contacttext.Location = new System.Drawing.Point(72, 56);
            this.Contacttext.Name = "Contacttext";
            this.Contacttext.Size = new System.Drawing.Size(630, 20);
            this.Contacttext.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Razón:";
            // 
            // Reasontext
            // 
            this.Reasontext.Location = new System.Drawing.Point(72, 30);
            this.Reasontext.Name = "Reasontext";
            this.Reasontext.Size = new System.Drawing.Size(630, 20);
            this.Reasontext.TabIndex = 28;
            // 
            // btnFirmar
            // 
            this.btnFirmar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFirmar.ImageIndex = 8;
            this.btnFirmar.ImageList = this.imageList1;
            this.btnFirmar.Location = new System.Drawing.Point(614, 108);
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Size = new System.Drawing.Size(88, 23);
            this.btnFirmar.TabIndex = 27;
            this.btnFirmar.Text = "Firmar";
            this.btnFirmar.UseVisualStyleBackColor = true;
            this.btnFirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.ImageIndex = 3;
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(715, 334);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Configuración";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.fileSufix);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.SigVisible);
            this.groupBox6.Controls.Add(this.filePrefix);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 60);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(709, 209);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Opciones:";
            // 
            // SigVisible
            // 
            this.SigVisible.AutoSize = true;
            this.SigVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SigVisible.Location = new System.Drawing.Point(83, 76);
            this.SigVisible.Name = "SigVisible";
            this.SigVisible.Size = new System.Drawing.Size(86, 17);
            this.SigVisible.TabIndex = 35;
            this.SigVisible.Text = "Firma visible:";
            this.SigVisible.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardarCambios);
            this.panel1.Controls.Add(this.btnDescartarCambios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 46);
            this.panel1.TabIndex = 22;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.ImageIndex = 4;
            this.btnGuardarCambios.ImageList = this.imageList1;
            this.btnGuardarCambios.Location = new System.Drawing.Point(580, 9);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(116, 28);
            this.btnGuardarCambios.TabIndex = 15;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnDescartarCambios
            // 
            this.btnDescartarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescartarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescartarCambios.ImageIndex = 5;
            this.btnDescartarCambios.ImageList = this.imageList1;
            this.btnDescartarCambios.Location = new System.Drawing.Point(450, 9);
            this.btnDescartarCambios.Name = "btnDescartarCambios";
            this.btnDescartarCambios.Size = new System.Drawing.Size(123, 28);
            this.btnDescartarCambios.TabIndex = 14;
            this.btnDescartarCambios.Text = "Descartar Cambios";
            this.btnDescartarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescartarCambios.UseVisualStyleBackColor = true;
            this.btnDescartarCambios.Click += new System.EventHandler(this.btnDescartarCambios_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAbrirRutaDestino);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.ConfiguracionRutaDestino);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(709, 57);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rutas:";
            // 
            // btnAbrirRutaDestino
            // 
            this.btnAbrirRutaDestino.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirRutaDestino.ImageIndex = 6;
            this.btnAbrirRutaDestino.ImageList = this.imageList1;
            this.btnAbrirRutaDestino.Location = new System.Drawing.Point(667, 19);
            this.btnAbrirRutaDestino.Name = "btnAbrirRutaDestino";
            this.btnAbrirRutaDestino.Size = new System.Drawing.Size(29, 20);
            this.btnAbrirRutaDestino.TabIndex = 13;
            this.btnAbrirRutaDestino.UseVisualStyleBackColor = true;
            this.btnAbrirRutaDestino.Click += new System.EventHandler(this.btnAbrirRutaDestino_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Destino:";
            // 
            // ConfiguracionRutaDestino
            // 
            this.ConfiguracionRutaDestino.HideSelection = false;
            this.ConfiguracionRutaDestino.Location = new System.Drawing.Point(155, 19);
            this.ConfiguracionRutaDestino.Name = "ConfiguracionRutaDestino";
            this.ConfiguracionRutaDestino.ReadOnly = true;
            this.ConfiguracionRutaDestino.Size = new System.Drawing.Size(505, 20);
            this.ConfiguracionRutaDestino.TabIndex = 17;
            this.ConfiguracionRutaDestino.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "key.png");
            this.imageList1.Images.SetKeyName(2, "pencil_go.png");
            this.imageList1.Images.SetKeyName(3, "cog.png");
            this.imageList1.Images.SetKeyName(4, "disk.png");
            this.imageList1.Images.SetKeyName(5, "delete.png");
            this.imageList1.Images.SetKeyName(6, "folder_magnify.png");
            this.imageList1.Images.SetKeyName(7, "folder_page.png");
            this.imageList1.Images.SetKeyName(8, "script_edit.png");
            this.imageList1.Images.SetKeyName(9, "application_form_delete.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Prefijo archivo firmado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // filePrefix
            // 
            this.filePrefix.HideSelection = false;
            this.filePrefix.Location = new System.Drawing.Point(155, 19);
            this.filePrefix.Name = "filePrefix";
            this.filePrefix.Size = new System.Drawing.Size(112, 20);
            this.filePrefix.TabIndex = 19;
            this.filePrefix.TabStop = false;
            // 
            // fileSufix
            // 
            this.fileSufix.HideSelection = false;
            this.fileSufix.Location = new System.Drawing.Point(155, 47);
            this.fileSufix.Name = "fileSufix";
            this.fileSufix.Size = new System.Drawing.Size(112, 20);
            this.fileSufix.TabIndex = 37;
            this.fileSufix.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Sufijo archivo firmado:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLimpiarFirmar
            // 
            this.btnLimpiarFirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFirmar.ImageIndex = 9;
            this.btnLimpiarFirmar.ImageList = this.imageList1;
            this.btnLimpiarFirmar.Location = new System.Drawing.Point(72, 108);
            this.btnLimpiarFirmar.Name = "btnLimpiarFirmar";
            this.btnLimpiarFirmar.Size = new System.Drawing.Size(70, 23);
            this.btnLimpiarFirmar.TabIndex = 34;
            this.btnLimpiarFirmar.Text = "Limpiar";
            this.btnLimpiarFirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFirmar.UseVisualStyleBackColor = true;
            this.btnLimpiarFirmar.Click += new System.EventHandler(this.btnLimpiarFirmar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 364);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Firmador OPDS";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Locationtext;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Contacttext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Reasontext;
        private System.Windows.Forms.Button btnFirmar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox DebugBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnDescartarCambios;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAbrirRutaDestino;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ConfiguracionRutaDestino;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox SigVisible;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prodBox;
        private System.Windows.Forms.TextBox creatorBox;
        private System.Windows.Forms.TextBox kwBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fileSufix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePrefix;
        private System.Windows.Forms.Button btnLimpiarFirmar;
    }
}

