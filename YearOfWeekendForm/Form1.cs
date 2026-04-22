namespace YearOfWeekendForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adYear = int.Parse(textBox1.Text);
            int daysInYear;
            if (DateTime.IsLeapYear(adYear))
            {
                daysInYear = 366;
            }
            else
            {
                daysInYear = 365;
            }

            int saturdayCount = 0;
            int sundayCount = 0;
            DateTime firstDay = new DateTime(adYear, 1, 1);
            for (int i = 0; i < daysInYear; i++)
            {
                DateTime currentDay = firstDay.AddDays(i);
                if (currentDay.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                else if (currentDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }
            label2.Text = ($"星期六{saturdayCount}天，星期日{sundayCount}天");
        }
    }
}
