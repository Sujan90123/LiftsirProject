namespace LiftsirProject
{
    public partial class Form1 : Form
    {
        bool isMovingUp = false;
        bool isMovingDown = false;
        int liftSpeed = 10;
        bool isClosing = false;
        bool isOpening = false;
        int doorSpeed = 10;

        int doorMaxOpenWidth;
        int doorMaxCLoseWidth;


        public Form1()
        {
            InitializeComponent();
            doorMaxOpenWidth = mainElevator.Width / 2 - 50;
            doorMaxCLoseWidth = mainElevator.Width / 2 ;
        }
        private void btn_Open_Click(object sender, EventArgs e)
        {
            isOpening = true;
            isClosing = false;
            doorTime.Start();
            btn_Close.Enabled = false;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            isOpening = false;
            isClosing = true;
            doorTime.Start();
            btn_Open.Enabled = false;
        }
        public void button3_click(object sender, EventArgs e)
        {
            isMovingUp = true;
            isMovingDown = false;
            liftTimer.Start();
            button3.Enabled = false;
        } 
        public void button2_click(object sender, EventArgs e)
        {
            isMovingUp = false;
            isMovingDown = true;
            liftTimer.Start();
            button2.Enabled = false;
        }
        public void lifttimer_Tick(object sender, EventArgs e)
        {
            if (isMovingUp)
            {
                button2.BackColor = Color.LightBlue;
                if(mainElevator.Top > 0)
                {
                    mainElevator.Top -= liftSpeed;
                }
                else
                {
                    liftTimer.Stop();
                    mainElevator.Top = 0;
                    button3.Enabled = true;

                }
            }
            if (isMovingDown)
            {
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.LightGreen;
                if (mainElevator.Bottom < this.ClientSize.Height)
                {
                    mainElevator.Top += liftSpeed;

                }
                else
                {
                    liftTimer.Stop();
                    button2.Enabled=true;
                }
            }
        }
        private void door_timer_Tick( object sender, EventArgs e)
        {
            if (mainElevator.Top != 0)
            {
                if (isOpening)
                {
                    if (doorLeft_G.Left > doorMaxOpenWidth / 2)
                    {
                        doorLeft_G.Left -= doorSpeed;
                        doorRight_G.Left += doorSpeed;
                    }
                    else
                    {
                        doorTime.Stop();
                        btn_Close.Enabled = true;
                    }

                }
                if (isClosing)
                {
                    if (doorLeft_G.Right < mainElevator.Width + doorMaxCLoseWidth / 2 - 80)
                    {
                        doorLeft_G.Left += doorSpeed;
                        doorRight_G.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTime.Stop();
                        btn_Open.Enabled = true;
                    }

                }
            }
            else
                
            {
                if (isOpening)
                {
                    if (door1_CloseLeft.Left > doorMaxOpenWidth / 2)
                    {
                        door1_CloseLeft.Left -= doorSpeed;
                        door1_CloseRight.Left += doorSpeed;
                    }
                    else
                    {
                        doorTime.Stop();
                        btn_Close.Enabled = true;
                    }

                }
                if (isClosing)
                {
                    if (door1_CloseLeft.Right < mainElevator.Width + doorMaxCLoseWidth / 2 - 80)
                    {
                        door1_CloseLeft.Left += doorSpeed;
                        door1_CloseRight.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTime.Stop();
                        btn_Open.Enabled = true;
                    }

                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

    }
}
