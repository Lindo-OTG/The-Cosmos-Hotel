﻿using System;
using GemBox.Email;
using GemBox.Email.Smtp;
using System.Windows.Forms;

namespace TheCosmosHotel
{
    class Email
    {
        public void SendMail(string email, string name, string id, string chkIN, string chkOut, string roomnum, string type, string price)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            MailMessage message = new MailMessage(
            new MailAddress("lindospam03@gmail.com", "Cosmos Hotel"),
            new MailAddress(email, name));
            Attachment at = new Attachment(@"C:\Users\Lindo\Videos\Logo.PNG");
            message.Attachments.Add(at);
            message.Cc.Add
            (
               new MailAddress("kamo.kamo869@gmail.com", "Company BackUp 1"),
               new MailAddress("nomakhosi.dlomo@gmail.com", "Company BackUp 2")
            );
            message.Subject = "Booking Recieved";
            message.BodyText = "Greetings 👋 " + name + "  ,\n\nYou have been Booked at The Cosmos Hotel\n\nBooking Details:\n• Your Booking ID: " + id  + " \n• Check-In: " + chkIN + " at 15:00 PM\n• Check-Out: " + chkOut + " at 10:30 AM\n• Room Number: " + roomnum + "\n• Room Type: " + type + "\n• Total: R " + price + ".00\n• Please note that a Cancelled bookings will result in a CANCELLATION FEE of 20% The initial Booking Fee\n\n\nKind Regards\nThe Cosmos Hotel\n\nNote: This message was automatically generated by the Booking system.";

            try
            {
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 465))
                {
                    smtp.Connect();
                    smtp.Authenticate("lindospam03@gmail.com", "Dnnls325");
                    smtp.SendMessage(message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "E-mail Not Sent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}