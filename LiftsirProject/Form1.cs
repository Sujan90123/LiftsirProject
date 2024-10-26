using System.Data;
using System.Data.SqlClient;
using System.Media;
using System.Windows.Forms;


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

        DataTable dt = new DataTable();
        DBContext db = new DBContext();
        private bool isEmergencyActive = false;


        string connectionstring = @"Server=DESKTOP-C9FMAFR;Database=UserDetails;Trusted_connection = True;";


        public Form1()
        {
            InitializeComponent();
            doorMaxOpenWidth = mainElevator.Width / 2 - 50;
            doorMaxCLoseWidth = mainElevator.Width / 2;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Time";
            dataGridView1.Columns[1].Name = "Events";


            dt.Columns.Add("LogTime");
            dt.Columns.Add("EventDescription");


        }
        private void dataEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            dt.Rows.Add(currentTime, message);
            dataGridView1.Rows.Add(currentTime, message);
            db.InsertlogsintoDB(dt);

        }
        private void DeleteEvents(string logTime, string message)
        {
            // Delete from the database
            //DeleteFromDB(logTime);

            //// Remove row from DataTable if it exists
            //DataRow[] rows = dt.Select("LogTime = '" + logTime + "' AND Message = '" + message + "'");
            //foreach (DataRow row in rows)
            //{
            //    dt.Rows.Remove(row);
            //}

            //// Refresh DataGridView
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = dt;

            //MessageBox.Show("Log deleted successfully from display.");
        }

        private void Form1_load(object sender, EventArgs e)
        {
            db.LoadLogsFromDB(dt, dataGridView1);
        }
        private void btn_Open_Click(object sender, EventArgs e)
        {
            isOpening = true;
            isClosing = false;
            doorTime.Start();
            btn_Close.Enabled = false;
            dataEvents("lift is khuldaii xa");


        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            isOpening = false;
            isClosing = true;
            doorTime.Start();
            btn_Open.Enabled = false;
            dataEvents("lift is banda ");

        }
        public void button3_click(object sender, EventArgs e)
        {
            isMovingUp = true;
            isMovingDown = false;
            liftTimer.Start();
            button3.Enabled = false;
            dataEvents("lift is going up");

        }
        public void button2_click(object sender, EventArgs e)
        {
            isMovingUp = false;
            isMovingDown = true;
            liftTimer.Start();
            button2.Enabled = false;

            dataEvents("lift is going down");

        }
        public void lifttimer_Tick(object sender, EventArgs e)
        {
            if (isMovingUp)
            {
                button2.BackColor = Color.LightBlue;
                if (mainElevator.Top > 0)
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
                    button2.Enabled = true;
                }
            }
        }
        private void door_timer_Tick(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void door1_CloseRight_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyAlarmButton_Click(object sender, EventArgs e)
        {
            if (!isEmergencyActive)
            {

                PlayAlarmSound();
                isEmergencyActive = true;
            }
            else
            {
                EmergencyAlarmButton.BackColor = Color.Blue;
                StopAlarmSound();
                isEmergencyActive = false;
            }

        }
        private void PlayAlarmSound()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Acer\Downloads\mixkit-retro-emergency-notification-alarm-2970.wav");
            player.PlayLooping(); // Loop sound for continuous alarm
        }

        private void StopAlarmSound()
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop(); // Stop any playing sound
        }
    }
}
