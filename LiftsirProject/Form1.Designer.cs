namespace LiftsirProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainElevator = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            btn_Close = new Button();
            btn_Open = new Button();
            panel1 = new Panel();
            liftTimer = new System.Windows.Forms.Timer(components);
            door1_CloseLeft = new PictureBox();
            door1_CloseRight = new PictureBox();
            doorLeft_G = new PictureBox();
            doorRight_G = new PictureBox();
            doorTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)door1_CloseLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door1_CloseRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorLeft_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorRight_G).BeginInit();
            SuspendLayout();
            // 
            // mainElevator
            // 
            mainElevator.BackColor = Color.Chocolate;
            mainElevator.BackgroundImage = (Image)resources.GetObject("mainElevator.BackgroundImage");
            mainElevator.BackgroundImageLayout = ImageLayout.Stretch;
            mainElevator.Location = new Point(130, 475);
            mainElevator.Name = "mainElevator";
            mainElevator.Size = new Size(276, 372);
            mainElevator.TabIndex = 0;
            mainElevator.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(895, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(659, 835);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(83, 361);
            button2.Name = "button2";
            button2.Size = new Size(89, 74);
            button2.TabIndex = 0;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button3_click;
            // 
            // button3
            // 
            button3.BackColor = Color.BlanchedAlmond;
            button3.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(83, 473);
            button3.Name = "button3";
            button3.Size = new Size(89, 72);
            button3.TabIndex = 1;
            button3.Text = "G";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button2_click;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.BurlyWood;
            btn_Close.BackgroundImage = (Image)resources.GetObject("btn_Close.BackgroundImage");
            btn_Close.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Close.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Close.Location = new Point(21, 569);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(89, 73);
            btn_Close.TabIndex = 2;
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Open_Click;
            // 
            // btn_Open
            // 
            btn_Open.BackColor = Color.BlueViolet;
            btn_Open.BackgroundImage = (Image)resources.GetObject("btn_Open.BackgroundImage");
            btn_Open.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Open.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Open.Location = new Point(143, 569);
            btn_Open.Name = "btn_Open";
            btn_Open.Size = new Size(82, 73);
            btn_Open.TabIndex = 3;
            btn_Open.UseVisualStyleBackColor = false;
            btn_Open.Click += btn_Close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btn_Open);
            panel1.Controls.Add(btn_Close);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(605, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 835);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // liftTimer
            // 
            liftTimer.Interval = 50;
            liftTimer.Tick += lifttimer_Tick;
            // 
            // door1_CloseLeft
            // 
            door1_CloseLeft.BackgroundImage = (Image)resources.GetObject("door1_CloseLeft.BackgroundImage");
            door1_CloseLeft.BackgroundImageLayout = ImageLayout.Stretch;
            door1_CloseLeft.Location = new Point(130, -6);
            door1_CloseLeft.Name = "door1_CloseLeft";
            door1_CloseLeft.Size = new Size(136, 372);
            door1_CloseLeft.TabIndex = 3;
            door1_CloseLeft.TabStop = false;
            // 
            // door1_CloseRight
            // 
            door1_CloseRight.BackgroundImage = (Image)resources.GetObject("door1_CloseRight.BackgroundImage");
            door1_CloseRight.BackgroundImageLayout = ImageLayout.Stretch;
            door1_CloseRight.Location = new Point(261, -6);
            door1_CloseRight.Name = "door1_CloseRight";
            door1_CloseRight.Size = new Size(144, 372);
            door1_CloseRight.TabIndex = 4;
            door1_CloseRight.TabStop = false;
            // 
            // doorLeft_G
            // 
            doorLeft_G.BackgroundImage = (Image)resources.GetObject("doorLeft_G.BackgroundImage");
            doorLeft_G.BackgroundImageLayout = ImageLayout.Stretch;
            doorLeft_G.Location = new Point(130, 475);
            doorLeft_G.Name = "doorLeft_G";
            doorLeft_G.Size = new Size(148, 372);
            doorLeft_G.TabIndex = 5;
            doorLeft_G.TabStop = false;
            // 
            // doorRight_G
            // 
            doorRight_G.BackgroundImage = (Image)resources.GetObject("doorRight_G.BackgroundImage");
            doorRight_G.BackgroundImageLayout = ImageLayout.Stretch;
            doorRight_G.Location = new Point(272, 475);
            doorRight_G.Name = "doorRight_G";
            doorRight_G.Size = new Size(140, 372);
            doorRight_G.TabIndex = 6;
            doorRight_G.TabStop = false;
            // 
            // doorTime
            // 
            doorTime.Tick += door_timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 859);
            Controls.Add(doorRight_G);
            Controls.Add(doorLeft_G);
            Controls.Add(door1_CloseRight);
            Controls.Add(door1_CloseLeft);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(mainElevator);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)door1_CloseLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)door1_CloseRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorLeft_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorRight_G).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mainElevator;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button btn_Close;
        private Button btn_Open;
        private Panel panel1;
        private System.Windows.Forms.Timer liftTimer;
        private PictureBox door1_CloseLeft;
        private PictureBox door1_CloseRight;
        private PictureBox doorLeft_G;
        private PictureBox doorRight_G;
        private System.Windows.Forms.Timer doorTime;
    }
}
