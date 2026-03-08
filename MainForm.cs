using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace HotelBookingManager
{
    public class MainForm : Form
    {
        // Controls
        TextBox txtGuestName = new TextBox() { Left = 100, Top = 20, Width = 150 };
        TextBox txtRoomNumber = new TextBox() { Left = 360, Top = 20, Width = 60 };
        DateTimePicker dtpCheckIn = new DateTimePicker() { Left = 100, Top = 60, Width = 150, Format = DateTimePickerFormat.Custom, CustomFormat = "MM/dd/yyyy HH:mm", ShowUpDown = true };
        DateTimePicker dtpCheckOut = new DateTimePicker() { Left = 360, Top = 60, Width = 150, Format = DateTimePickerFormat.Custom, CustomFormat = "MM/dd/yyyy HH:mm", ShowUpDown = true };
        Button btnBookRoom = new Button() { Left = 20, Top = 100, Width = 90, Text = "Book Room" };
        Button btnCancelBooking = new Button() { Left = 120, Top = 100, Width = 120, Text = "Cancel Booking" };
        Button btnViewBookings = new Button() { Left = 260, Top = 100, Width = 130, Text = "View All Bookings" };
        Button btnExit = new Button() { Left = 420, Top = 100, Width = 90, Text = "Exit" };
        ListBox lstBookings = new ListBox() { Left = 20, Top = 140, Width = 490, Height = 150 };
        Label lblStatus = new Label() { Left = 20, Top = 300, Width = 490, Text = "Status: " };

        BookingManager manager = new BookingManager();

        public MainForm()
        {
            this.Text = "Hotel Booking System";
            this.ClientSize = new System.Drawing.Size(540, 350);

            // Add controls
            Controls.AddRange(new Control[] {
                txtGuestName, txtRoomNumber, dtpCheckIn, dtpCheckOut,
                btnBookRoom, btnCancelBooking, btnViewBookings, btnExit,
                lstBookings, lblStatus
            });

            // Button events
            btnBookRoom.Click += (s, e) => BookRoom();
            btnCancelBooking.Click += (s, e) => CancelBooking();
            btnViewBookings.Click += (s, e) => RefreshList();
            btnExit.Click += (s, e) => this.Close();
        }

   
    }
}