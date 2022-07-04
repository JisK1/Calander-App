namespace Calander_App
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;
    
  
    
    public partial class Form : System.Windows.Forms.Form
    {

        public class Day
        {
            public Button Btn_day;
            public Panel Pnl_day;
            //The number day of the month.
            public int dayNum = 0;


            public Day(Button btn_day, Panel pnl_day)
            {   
                Btn_day = btn_day;
                
                Pnl_day = pnl_day;
            }
            
        }

        Day[,] Days = new Day[6, 7];
        DateTime CurrentFirstOfMonth;

        public Form()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            initilizeDays();
            CurrentFirstOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            populateBasedOnMonthYear(CurrentFirstOfMonth);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calander_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Day_1_Click(object sender, EventArgs e)
        {

        }


        private void populateDays()
        {
            int h = 0;
            for (int i = 0; i < Calander_Body.RowCount - 1; i++)
            {
                for (int j = 0; j < Calander_Body.ColumnCount; j++)
                {
                    h++;
                    Days[i, j].Btn_day.Text = h.ToString();
                }
            }
        }

        //populates the calander based on a date time of the first of the month.
        private void populateBasedOnMonthYear(DateTime firstOfMonth)
        {
            //set the month label
            lbl_Month.Text = firstOfMonth.ToString("MMMM");
            lbl_Year.Text = firstOfMonth.ToString("yyyy");

            for (int i = 0; i < Calander_Body.RowCount - 1; i++)
            {
                for (int j = 0; j < Calander_Body.ColumnCount; j++)
                {

                    //Find the first of the month by checking for the first day of the week.
                    if (i == 0 && (int)firstOfMonth.DayOfWeek == j)
                    {
                        Days[i, j].Btn_day.Enabled = true;
                        Days[i, j].Btn_day.Visible = true;

                        Days[i, j].Btn_day.Text = firstOfMonth.Day.ToString();

                        if (firstOfMonth.Equals(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)))
                        {
                            Days[i, j].Btn_day.BackColor = Color.Gray;
                            Days[i, j].Pnl_day.BackColor = Color.White;
                        }
                        else
                        {
                            Days[i, j].Btn_day.BackColor = Color.Silver;
                            Days[i, j].Pnl_day.BackColor = Color.White;
                        }

                        firstOfMonth = firstOfMonth.AddDays(1);

                    }
                    //Add every day of the month if the first day has been found.
                    else if (firstOfMonth.Day > 1)
                    {
                        Days[i, j].Btn_day.Enabled = true;
                        Days[i, j].Btn_day.Visible = true;
                        Days[i, j].Btn_day.Text = firstOfMonth.Day.ToString();
                        if (firstOfMonth.Equals(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)))
                        {
                            Days[i, j].Btn_day.BackColor = Color.Gray;
                            Days[i, j].Pnl_day.BackColor = Color.White;
                        }
                        else
                        {
                            Days[i, j].Btn_day.BackColor = Color.Silver;
                            Days[i, j].Pnl_day.BackColor = Color.White;
                        }

                        firstOfMonth = firstOfMonth.AddDays(1);
                    }
                    //Before the first of the month.
                    else if(firstOfMonth.Day == 1)
                    {
                        Days[i, j].Btn_day.Text = "";
                        //If before the first of the month then set daynum = 0;
                        Days[i, j].dayNum = 0;
                        Days[i, j].Btn_day.Enabled = false;
                        Days[i, j].Btn_day.Visible = false;

                        Days[i, j].Btn_day.BackColor = Color.Silver;
                        Days[i, j].Pnl_day.BackColor = Color.White;
                    }

                }
            }
        }

        private void initilizeDays()
        {
            Days[0, 0] = new Day(btn_Day1,pnl_Day1);
            Days[0, 1] = new Day(btn_Day2,pnl_Day2);
            Days[0, 2] = new Day(btn_Day3,pnl_Day3);
            Days[0, 3] = new Day(btn_Day4,pnl_Day4);
            Days[0, 4] = new Day(btn_Day5,pnl_Day5);
            Days[0, 5] = new Day(btn_Day6,pnl_Day6);
            Days[0, 5] = new Day(btn_Day6,pnl_Day6);
            Days[0, 6] = new Day(btn_Day7,pnl_Day7);

            Days[1, 0] = new Day(btn_Day8,pnl_Day8);
            Days[1, 1] = new Day(btn_Day9,pnl_Day9);
            Days[1, 2] = new Day(btn_Day10,pnl_Day10);
            Days[1, 3] = new Day(btn_Day11,pnl_Day11);
            Days[1, 4] = new Day(btn_Day12,pnl_Day12);
            Days[1, 5] = new Day(btn_Day13,pnl_Day13);
            Days[1, 6] = new Day(btn_Day14,pnl_Day14);

            Days[2, 0] = new Day(btn_Day15,pnl_Day15);
            Days[2, 1] = new Day(btn_Day16,pnl_Day16);
            Days[2, 2] = new Day(btn_Day17,pnl_Day17);
            Days[2, 3] = new Day(btn_Day18,pnl_Day18);
            Days[2, 4] = new Day(btn_Day19,pnl_Day19);
            Days[2, 5] = new Day(btn_Day20,pnl_Day20);
            Days[2, 6] = new Day(btn_Day21,pnl_Day21);

            Days[3, 0] = new Day(btn_Day22,pnl_Day22);
            Days[3, 1] = new Day(btn_Day23,pnl_Day23);
            Days[3, 2] = new Day(btn_Day24,pnl_Day24);
            Days[3, 3] = new Day(btn_Day25,pnl_Day25);
            Days[3, 4] = new Day(btn_Day26,pnl_Day26);
            Days[3, 5] = new Day(btn_Day27,pnl_Day27);
            Days[3, 6] = new Day(btn_Day28,pnl_Day28);

            Days[4, 0] = new Day(btn_Day29,pnl_Day29);
            Days[4, 1] = new Day(btn_Day30,pnl_Day30);
            Days[4, 2] = new Day(btn_Day31,pnl_Day31);
            Days[4, 3] = new Day(btn_Day32,pnl_Day32);
            Days[4, 4] = new Day(btn_Day33,pnl_Day33);
            Days[4, 5] = new Day(btn_Day34,pnl_Day34);
            Days[4, 6] = new Day(btn_Day35,pnl_Day35);

            Days[5, 0] = new Day(btn_Day36,pnl_Day36);
            Days[5, 1] = new Day(btn_Day37,pnl_Day37);
            Days[5, 2] = new Day(btn_Day38,pnl_Day38);
            Days[5, 3] = new Day(btn_Day39,pnl_Day39);
            Days[5, 4] = new Day(btn_Day40,pnl_Day40);
            Days[5, 5] = new Day(btn_Day41,pnl_Day41);
            Days[5, 6] = new Day(btn_Day42,pnl_Day42);


        }

        private void btn_Day34_Click(object sender, EventArgs e)
        {

        }

        private void btn_Day8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            CurrentFirstOfMonth = CurrentFirstOfMonth.AddMonths(1);
            populateBasedOnMonthYear(CurrentFirstOfMonth);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            CurrentFirstOfMonth = CurrentFirstOfMonth.AddMonths(-1);
            populateBasedOnMonthYear(CurrentFirstOfMonth);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}