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
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            liftTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainElevator
            // 
            mainElevator.BackColor = Color.Chocolate;
            mainElevator.BackgroundImage = (Image)resources.GetObject("mainElevator.BackgroundImage");
            mainElevator.BackgroundImageLayout = ImageLayout.Stretch;
            mainElevator.Location = new Point(120, 272);
            mainElevator.Name = "mainElevator";
            mainElevator.Size = new Size(276, 372);
            mainElevator.TabIndex = 0;
            mainElevator.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(895, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(471, 571);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(83, 228);
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
            button3.Location = new Point(83, 317);
            button3.Name = "button3";
            button3.Size = new Size(89, 72);
            button3.TabIndex = 1;
            button3.Text = "G";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button2_click;
            // 
            // button4
            // 
            button4.BackColor = Color.BurlyWood;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(31, 412);
            button4.Name = "button4";
            button4.Size = new Size(89, 73);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.BlueViolet;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(141, 412);
            button5.Name = "button5";
            button5.Size = new Size(82, 73);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(605, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 571);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // liftTimer
            // 
            liftTimer.Interval = 50;
            liftTimer.Tick += lifttimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 681);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(mainElevator);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button mainElevator;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private System.Windows.Forms.Timer liftTimer;
    }
}
