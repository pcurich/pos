using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Example
{
    public partial class FrmMonthCalendar : Form
    {
        public FrmMonthCalendar()
        {
            InitializeComponent();
        }

        private void FrmMonthCalendar_Load(object sender, EventArgs e)
        {
            mCal.BoldedDates = new DateTime[]{
                new DateTime(2020,10,01),new DateTime(2020,10,08),new DateTime(2020,10,15)
            };
            mCal.FirstDayOfWeek = Day.Monday;
            mCal.MaxSelectionCount = 8;
            mCal.ShowWeekNumbers = true;
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            lblStart.Text = mCal.SelectionStart.ToString();
            lblEnd.Text = mCal.SelectionEnd.ToString();
        }

        private void MCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblRange.Text = mCal.SelectionRange.ToString();
        }
    }
}
