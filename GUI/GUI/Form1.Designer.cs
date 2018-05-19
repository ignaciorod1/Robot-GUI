namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.posX = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.LbPosX = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPuertoSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.CbCOM = new System.Windows.Forms.ToolStripComboBox();
            this.baudRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbBaud = new System.Windows.Forms.ToolStripComboBox();
            this.BtnConectar = new System.Windows.Forms.ToolStripMenuItem();
            this.LbPosY = new System.Windows.Forms.Label();
            this.LbPosZ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbAng1 = new System.Windows.Forms.Label();
            this.LbAng2 = new System.Windows.Forms.Label();
            this.LbAng3 = new System.Windows.Forms.Label();
            this.LbTool = new System.Windows.Forms.Label();
            this.LbHerramienta = new System.Windows.Forms.Label();
            this.LbConfig = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxV1 = new System.Windows.Forms.TextBox();
            this.textBoxV2 = new System.Windows.Forms.TextBox();
            this.textBoxV3 = new System.Windows.Forms.TextBox();
            this.LbAvanceM1 = new System.Windows.Forms.Label();
            this.textBoxAvance = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Bebas Kai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(115, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 200);
            this.button1.TabIndex = 0;
            this.button1.Text = "regar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Bebas Kai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(389, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 200);
            this.button2.TabIndex = 1;
            this.button2.Text = "sembrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // posX
            // 
            this.posX.AutoSize = true;
            this.posX.BackColor = System.Drawing.Color.Transparent;
            this.posX.Font = new System.Drawing.Font("Bebas Kai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posX.ForeColor = System.Drawing.Color.Aqua;
            this.posX.Location = new System.Drawing.Point(1620, 286);
            this.posX.Name = "posX";
            this.posX.Size = new System.Drawing.Size(83, 48);
            this.posX.TabIndex = 2;
            this.posX.Text = "posX";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("Bebas Kai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(115, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 200);
            this.button3.TabIndex = 3;
            this.button3.Text = "Arar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Bebas Kai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(389, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 200);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cortar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Font = new System.Drawing.Font("Bebas Kai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(115, 612);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 200);
            this.button5.TabIndex = 5;
            this.button5.Text = "Demo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Font = new System.Drawing.Font("Bebas Kai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(389, 612);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 200);
            this.button6.TabIndex = 6;
            this.button6.Text = "Luces";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Font = new System.Drawing.Font("Bebas Kai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(664, 80);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(384, 111);
            this.button7.TabIndex = 7;
            this.button7.Text = "stop";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(1422, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 60);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bebas Kai", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(1413, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Input";
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSend.Font = new System.Drawing.Font("Bebas Kai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(1759, 194);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(94, 60);
            this.BtnSend.TabIndex = 10;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.button8_Click);
            // 
            // LbPosX
            // 
            this.LbPosX.AutoSize = true;
            this.LbPosX.BackColor = System.Drawing.Color.Transparent;
            this.LbPosX.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPosX.ForeColor = System.Drawing.Color.Aqua;
            this.LbPosX.Location = new System.Drawing.Point(1417, 302);
            this.LbPosX.Name = "LbPosX";
            this.LbPosX.Size = new System.Drawing.Size(132, 29);
            this.LbPosX.TabIndex = 11;
            this.LbPosX.Text = "Posición eje X:";
            this.LbPosX.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1882, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnPuertoSerial,
            this.baudRateToolStripMenuItem,
            this.BtnConectar});
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.conectarToolStripMenuItem.Text = "Conectar";
            // 
            // BtnPuertoSerial
            // 
            this.BtnPuertoSerial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CbCOM});
            this.BtnPuertoSerial.Name = "BtnPuertoSerial";
            this.BtnPuertoSerial.Size = new System.Drawing.Size(166, 26);
            this.BtnPuertoSerial.Text = "Puerto serial";
            this.BtnPuertoSerial.Click += new System.EventHandler(this.puertoSerialToolStripMenuItem_Click);
            // 
            // CbCOM
            // 
            this.CbCOM.Name = "CbCOM";
            this.CbCOM.Size = new System.Drawing.Size(181, 28);
            this.CbCOM.Text = "COMs";
            this.CbCOM.Click += new System.EventHandler(this.com3ToolStripMenuItem_Click);
            // 
            // baudRateToolStripMenuItem
            // 
            this.baudRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CbBaud});
            this.baudRateToolStripMenuItem.Name = "baudRateToolStripMenuItem";
            this.baudRateToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.baudRateToolStripMenuItem.Text = "Baud Rate";
            // 
            // CbBaud
            // 
            this.CbBaud.Items.AddRange(new object[] {
            "9600",
            "14400"});
            this.CbBaud.Name = "CbBaud";
            this.CbBaud.Size = new System.Drawing.Size(181, 28);
            this.CbBaud.Text = "9600";
            this.CbBaud.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(166, 26);
            this.BtnConectar.Text = "Iniciar";
            this.BtnConectar.Click += new System.EventHandler(this.iniciarConexiónToolStripMenuItem_Click);
            // 
            // LbPosY
            // 
            this.LbPosY.AutoSize = true;
            this.LbPosY.BackColor = System.Drawing.Color.Transparent;
            this.LbPosY.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPosY.ForeColor = System.Drawing.Color.Aqua;
            this.LbPosY.Location = new System.Drawing.Point(1417, 370);
            this.LbPosY.Name = "LbPosY";
            this.LbPosY.Size = new System.Drawing.Size(132, 29);
            this.LbPosY.TabIndex = 13;
            this.LbPosY.Text = "Posición eje Y:";
            this.LbPosY.Click += new System.EventHandler(this.label4_Click);
            // 
            // LbPosZ
            // 
            this.LbPosZ.AutoSize = true;
            this.LbPosZ.BackColor = System.Drawing.Color.Transparent;
            this.LbPosZ.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPosZ.ForeColor = System.Drawing.Color.Aqua;
            this.LbPosZ.Location = new System.Drawing.Point(1418, 436);
            this.LbPosZ.Name = "LbPosZ";
            this.LbPosZ.Size = new System.Drawing.Size(131, 29);
            this.LbPosZ.TabIndex = 14;
            this.LbPosZ.Text = "Posición eje Z:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Kai", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(1617, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "posY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bebas Kai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(1617, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 48);
            this.label3.TabIndex = 16;
            this.label3.Text = "posZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(1417, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ángulo motor 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(1417, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ángulo motor 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(1417, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ángulo motor 3";
            // 
            // LbAng1
            // 
            this.LbAng1.AutoSize = true;
            this.LbAng1.BackColor = System.Drawing.Color.Transparent;
            this.LbAng1.Font = new System.Drawing.Font("Bebas Kai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAng1.ForeColor = System.Drawing.Color.Aqua;
            this.LbAng1.Location = new System.Drawing.Point(1617, 529);
            this.LbAng1.Name = "LbAng1";
            this.LbAng1.Size = new System.Drawing.Size(122, 48);
            this.LbAng1.TabIndex = 20;
            this.LbAng1.Text = "angle 1";
            // 
            // LbAng2
            // 
            this.LbAng2.AutoSize = true;
            this.LbAng2.BackColor = System.Drawing.Color.Transparent;
            this.LbAng2.Font = new System.Drawing.Font("Bebas Kai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAng2.ForeColor = System.Drawing.Color.Aqua;
            this.LbAng2.Location = new System.Drawing.Point(1617, 592);
            this.LbAng2.Name = "LbAng2";
            this.LbAng2.Size = new System.Drawing.Size(125, 48);
            this.LbAng2.TabIndex = 21;
            this.LbAng2.Text = "angle 2";
            // 
            // LbAng3
            // 
            this.LbAng3.AutoSize = true;
            this.LbAng3.BackColor = System.Drawing.Color.Transparent;
            this.LbAng3.Font = new System.Drawing.Font("Bebas Kai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAng3.ForeColor = System.Drawing.Color.Aqua;
            this.LbAng3.Location = new System.Drawing.Point(1617, 654);
            this.LbAng3.Name = "LbAng3";
            this.LbAng3.Size = new System.Drawing.Size(125, 48);
            this.LbAng3.TabIndex = 22;
            this.LbAng3.Text = "angle 2";
            // 
            // LbTool
            // 
            this.LbTool.AutoSize = true;
            this.LbTool.BackColor = System.Drawing.Color.Transparent;
            this.LbTool.Font = new System.Drawing.Font("Bebas Kai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTool.ForeColor = System.Drawing.Color.Aqua;
            this.LbTool.Location = new System.Drawing.Point(1395, 772);
            this.LbTool.Name = "LbTool";
            this.LbTool.Size = new System.Drawing.Size(166, 40);
            this.LbTool.TabIndex = 23;
            this.LbTool.Text = "Herramienta";
            // 
            // LbHerramienta
            // 
            this.LbHerramienta.AutoSize = true;
            this.LbHerramienta.BackColor = System.Drawing.Color.Transparent;
            this.LbHerramienta.Font = new System.Drawing.Font("Bebas Kai", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHerramienta.ForeColor = System.Drawing.Color.Aqua;
            this.LbHerramienta.Location = new System.Drawing.Point(1579, 763);
            this.LbHerramienta.Name = "LbHerramienta";
            this.LbHerramienta.Size = new System.Drawing.Size(234, 56);
            this.LbHerramienta.TabIndex = 24;
            this.LbHerramienta.Text = "Herramienta";
            // 
            // LbConfig
            // 
            this.LbConfig.AutoSize = true;
            this.LbConfig.BackColor = System.Drawing.Color.Transparent;
            this.LbConfig.Font = new System.Drawing.Font("Bebas Kai", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbConfig.Location = new System.Drawing.Point(847, 286);
            this.LbConfig.Name = "LbConfig";
            this.LbConfig.Size = new System.Drawing.Size(335, 72);
            this.LbConfig.TabIndex = 25;
            this.LbConfig.Text = "configuración";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(854, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Velocidad Motor 1: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(853, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Velocidad Motor 2: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(852, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "Velocidad Motor 3: ";
            // 
            // textBoxV1
            // 
            this.textBoxV1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxV1.ForeColor = System.Drawing.Color.Lime;
            this.textBoxV1.Location = new System.Drawing.Point(1044, 385);
            this.textBoxV1.Multiline = true;
            this.textBoxV1.Name = "textBoxV1";
            this.textBoxV1.ReadOnly = true;
            this.textBoxV1.Size = new System.Drawing.Size(116, 34);
            this.textBoxV1.TabIndex = 29;
            // 
            // textBoxV2
            // 
            this.textBoxV2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxV2.ForeColor = System.Drawing.Color.Lime;
            this.textBoxV2.Location = new System.Drawing.Point(1044, 441);
            this.textBoxV2.Multiline = true;
            this.textBoxV2.Name = "textBoxV2";
            this.textBoxV2.ReadOnly = true;
            this.textBoxV2.Size = new System.Drawing.Size(116, 34);
            this.textBoxV2.TabIndex = 30;
            // 
            // textBoxV3
            // 
            this.textBoxV3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxV3.ForeColor = System.Drawing.Color.Lime;
            this.textBoxV3.Location = new System.Drawing.Point(1044, 495);
            this.textBoxV3.Multiline = true;
            this.textBoxV3.Name = "textBoxV3";
            this.textBoxV3.ReadOnly = true;
            this.textBoxV3.Size = new System.Drawing.Size(116, 34);
            this.textBoxV3.TabIndex = 30;
            // 
            // LbAvanceM1
            // 
            this.LbAvanceM1.AutoSize = true;
            this.LbAvanceM1.BackColor = System.Drawing.Color.Transparent;
            this.LbAvanceM1.Font = new System.Drawing.Font("Bebas Kai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAvanceM1.ForeColor = System.Drawing.Color.Aqua;
            this.LbAvanceM1.Location = new System.Drawing.Point(878, 556);
            this.LbAvanceM1.Name = "LbAvanceM1";
            this.LbAvanceM1.Size = new System.Drawing.Size(151, 29);
            this.LbAvanceM1.TabIndex = 31;
            this.LbAvanceM1.Text = "Avance Motor 1: ";
            // 
            // textBoxAvance
            // 
            this.textBoxAvance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxAvance.ForeColor = System.Drawing.Color.Lime;
            this.textBoxAvance.Location = new System.Drawing.Point(1044, 551);
            this.textBoxAvance.Multiline = true;
            this.textBoxAvance.Name = "textBoxAvance";
            this.textBoxAvance.ReadOnly = true;
            this.textBoxAvance.Size = new System.Drawing.Size(116, 34);
            this.textBoxAvance.TabIndex = 32;
            this.textBoxAvance.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1882, 1033);
            this.Controls.Add(this.textBoxAvance);
            this.Controls.Add(this.LbAvanceM1);
            this.Controls.Add(this.textBoxV3);
            this.Controls.Add(this.textBoxV2);
            this.Controls.Add(this.textBoxV1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LbConfig);
            this.Controls.Add(this.LbHerramienta);
            this.Controls.Add(this.LbTool);
            this.Controls.Add(this.LbAng3);
            this.Controls.Add(this.LbAng2);
            this.Controls.Add(this.LbAng1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbPosZ);
            this.Controls.Add(this.LbPosY);
            this.Controls.Add(this.LbPosX);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.posX);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Iron Plant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label posX;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label LbPosX;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnPuertoSerial;
        private System.Windows.Forms.ToolStripMenuItem baudRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox CbCOM;
        private System.Windows.Forms.ToolStripMenuItem BtnConectar;
        private System.Windows.Forms.ToolStripComboBox CbBaud;
        private System.Windows.Forms.Label LbPosY;
        private System.Windows.Forms.Label LbPosZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbAng1;
        private System.Windows.Forms.Label LbAng2;
        private System.Windows.Forms.Label LbAng3;
        private System.Windows.Forms.Label LbTool;
        private System.Windows.Forms.Label LbHerramienta;
        private System.Windows.Forms.Label LbConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxV1;
        private System.Windows.Forms.TextBox textBoxV2;
        private System.Windows.Forms.TextBox textBoxV3;
        private System.Windows.Forms.Label LbAvanceM1;
        private System.Windows.Forms.TextBox textBoxAvance;
    }
}

