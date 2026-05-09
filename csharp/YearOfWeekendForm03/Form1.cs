namespace YearOfWeekendForm03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rocYear = int.Parse(textBox1.Text);
            int year = rocYear + 1911;

            int saturdayCount = 52;
            int sundayCount = 52;

            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime secondDay = firstDay.AddDays(1);

            if (firstDay.DayOfWeek == DayOfWeek.Saturday || (DateTime.IsLeapYear(year) && secondDay.DayOfWeek == DayOfWeek.Saturday))
            {
                saturdayCount++;
            }

            if (firstDay.DayOfWeek == DayOfWeek.Sunday || (DateTime.IsLeapYear(year) && secondDay.DayOfWeek == DayOfWeek.Sunday))
            {
                sundayCount++;
            }
            label2.Text = ($"星期六{saturdayCount}天，星期日{sundayCount}天");
        }
    }
}
