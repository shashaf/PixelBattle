namespace ClientPB
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
            canvas = new Panel();
            label1 = new Label();
            txtServerIP = new TextBox();
            btnConnect = new Button();
            worldList = new ComboBox();
            btnJoin = new Button();
            btnCreate = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            btnColor7 = new Button();
            btnColor6 = new Button();
            btnColor5 = new Button();
            btnColor4 = new Button();
            btnColor3 = new Button();
            btnColor2 = new Button();
            btnColor1 = new Button();
            btnColor0 = new Button();
            lblStatus = new Label();
            lblCooldown = new Label();
            cooldownTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.BackColor = Color.Black;
            canvas.Location = new Point(251, 53);
            canvas.Margin = new Padding(3, 4, 3, 4);
            canvas.Name = "canvas";
            canvas.Size = new Size(571, 667);
            canvas.TabIndex = 0;
            canvas.Paint += canvas_Paint;
            canvas.MouseClick += canvas_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 79);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "IP сервера";
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(96, 75);
            txtServerIP.Margin = new Padding(3, 4, 3, 4);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(148, 27);
            txtServerIP.TabIndex = 2;
            txtServerIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(16, 140);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(205, 31);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Подключиться к серверу";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // worldList
            // 
            worldList.Enabled = false;
            worldList.FormattingEnabled = true;
            worldList.Location = new Point(16, 255);
            worldList.Margin = new Padding(3, 4, 3, 4);
            worldList.Name = "worldList";
            worldList.Size = new Size(228, 28);
            worldList.TabIndex = 4;
            // 
            // btnJoin
            // 
            btnJoin.Enabled = false;
            btnJoin.Location = new Point(16, 328);
            btnJoin.Margin = new Padding(3, 4, 3, 4);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(205, 31);
            btnJoin.TabIndex = 3;
            btnJoin.Text = "Зайти на мир";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // btnCreate
            // 
            btnCreate.Enabled = false;
            btnCreate.Location = new Point(16, 381);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(205, 31);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Создать мир";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Enabled = false;
            btnRefresh.Location = new Point(16, 440);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(205, 31);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Обновить список миров";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnColor7);
            panel1.Controls.Add(btnColor6);
            panel1.Controls.Add(btnColor5);
            panel1.Controls.Add(btnColor4);
            panel1.Controls.Add(btnColor3);
            panel1.Controls.Add(btnColor2);
            panel1.Controls.Add(btnColor1);
            panel1.Controls.Add(btnColor0);
            panel1.Location = new Point(853, 96);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 53);
            panel1.TabIndex = 5;
            // 
            // btnColor7
            // 
            btnColor7.BackColor = Color.Cyan;
            btnColor7.FlatStyle = FlatStyle.Flat;
            btnColor7.Location = new Point(331, 7);
            btnColor7.Margin = new Padding(3, 4, 3, 4);
            btnColor7.Name = "btnColor7";
            btnColor7.Size = new Size(40, 40);
            btnColor7.TabIndex = 0;
            btnColor7.UseVisualStyleBackColor = false;
            // 
            // btnColor6
            // 
            btnColor6.BackColor = Color.Magenta;
            btnColor6.FlatStyle = FlatStyle.Flat;
            btnColor6.Location = new Point(285, 7);
            btnColor6.Margin = new Padding(3, 4, 3, 4);
            btnColor6.Name = "btnColor6";
            btnColor6.Size = new Size(40, 40);
            btnColor6.TabIndex = 0;
            btnColor6.UseVisualStyleBackColor = false;
            // 
            // btnColor5
            // 
            btnColor5.BackColor = Color.Yellow;
            btnColor5.FlatStyle = FlatStyle.Flat;
            btnColor5.Location = new Point(238, 7);
            btnColor5.Margin = new Padding(3, 4, 3, 4);
            btnColor5.Name = "btnColor5";
            btnColor5.Size = new Size(40, 40);
            btnColor5.TabIndex = 0;
            btnColor5.UseVisualStyleBackColor = false;
            // 
            // btnColor4
            // 
            btnColor4.BackColor = Color.Blue;
            btnColor4.FlatStyle = FlatStyle.Flat;
            btnColor4.Location = new Point(191, 7);
            btnColor4.Margin = new Padding(3, 4, 3, 4);
            btnColor4.Name = "btnColor4";
            btnColor4.Size = new Size(40, 40);
            btnColor4.TabIndex = 0;
            btnColor4.UseVisualStyleBackColor = false;
            // 
            // btnColor3
            // 
            btnColor3.BackColor = Color.Green;
            btnColor3.FlatStyle = FlatStyle.Flat;
            btnColor3.Location = new Point(144, 7);
            btnColor3.Margin = new Padding(3, 4, 3, 4);
            btnColor3.Name = "btnColor3";
            btnColor3.Size = new Size(40, 40);
            btnColor3.TabIndex = 0;
            btnColor3.UseVisualStyleBackColor = false;
            // 
            // btnColor2
            // 
            btnColor2.BackColor = Color.Red;
            btnColor2.FlatStyle = FlatStyle.Flat;
            btnColor2.Location = new Point(97, 7);
            btnColor2.Margin = new Padding(3, 4, 3, 4);
            btnColor2.Name = "btnColor2";
            btnColor2.Size = new Size(40, 40);
            btnColor2.TabIndex = 0;
            btnColor2.UseVisualStyleBackColor = false;
            // 
            // btnColor1
            // 
            btnColor1.BackColor = Color.White;
            btnColor1.FlatStyle = FlatStyle.Flat;
            btnColor1.Location = new Point(50, 7);
            btnColor1.Margin = new Padding(3, 4, 3, 4);
            btnColor1.Name = "btnColor1";
            btnColor1.Size = new Size(40, 40);
            btnColor1.TabIndex = 0;
            btnColor1.UseVisualStyleBackColor = false;
            // 
            // btnColor0
            // 
            btnColor0.BackColor = Color.Black;
            btnColor0.FlatStyle = FlatStyle.Flat;
            btnColor0.Location = new Point(3, 7);
            btnColor0.Margin = new Padding(3, 4, 3, 4);
            btnColor0.Name = "btnColor0";
            btnColor0.Size = new Size(40, 40);
            btnColor0.TabIndex = 0;
            btnColor0.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(853, 265);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Статус";
            // 
            // lblCooldown
            // 
            lblCooldown.AutoSize = true;
            lblCooldown.Location = new Point(853, 303);
            lblCooldown.Name = "lblCooldown";
            lblCooldown.Size = new Size(31, 20);
            lblCooldown.TabIndex = 1;
            lblCooldown.Text = "КД:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 783);
            Controls.Add(panel1);
            Controls.Add(worldList);
            Controls.Add(btnRefresh);
            Controls.Add(btnCreate);
            Controls.Add(btnJoin);
            Controls.Add(btnConnect);
            Controls.Add(txtServerIP);
            Controls.Add(lblCooldown);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(canvas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel canvas;
        private Label label1;
        private TextBox txtServerIP;
        private Button btnConnect;
        private ComboBox worldList;
        private Button btnJoin;
        private Button btnCreate;
        private Button btnRefresh;
        private Panel panel1;
        private Button btnColor7;
        private Button btnColor6;
        private Button btnColor5;
        private Button btnColor4;
        private Button btnColor3;
        private Button button3;
        private Button btnColor1;
        private Button btnColor0;
        private Button btnColor2;
        private Label lblStatus;
        private Label lblCooldown;
        private System.Windows.Forms.Timer cooldownTimer;
    }
}
