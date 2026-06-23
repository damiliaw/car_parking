using System;
using System.Windows.Forms;

namespace park_management
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        public Receipt(string transactionId, string paymentId, string licensePlate,
                        string vehicleType, string colorModel, string slotNumber,
                        DateTime entryTime, DateTime exitTime, int durationHours,
                        double baseFee, double hourlyCharge, double totalDue, string method)
        {
            InitializeComponent();

            labelTransID.Text = transactionId;
            labelPayID.Text = paymentId;
            labelLP.Text = licensePlate;
            labelVT.Text = vehicleType;
            labelCM.Text = colorModel;
            labelSlot.Text = slotNumber;
            labelEntryTime.Text = entryTime.ToString("dd/MM/yyyy hh:mm tt");
            labelExitTime.Text = exitTime.ToString("dd/MM/yyyy hh:mm tt");
            labelDuration.Text = durationHours + " Hour(s)";
            labelOutputRate.Text = "RM " + hourlyCharge.ToString("0.00");
            labelBaseFee.Text = "RM " + baseFee.ToString("0.00");
            labelPaymentMethod.Text = method;
            labelTotalPaid.Text = "RM " + totalDue.ToString("0.00");
        }
    }
}