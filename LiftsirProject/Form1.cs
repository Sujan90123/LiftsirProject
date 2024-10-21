namespace LiftsirProject
{
    public partial class Form1 : Form
    {
        bool isMovingUp = false;
        bool isMovingDown = false;
        int liftSpeed = 10;
        int x = 10;


        public Form1()
        {
            InitializeComponent();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
