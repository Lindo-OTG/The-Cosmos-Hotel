using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheCosmosHotel
{
    class Booking
    {
        private int bookingID;
        private string bookingDate;
        private int customerID;
        private string roomID;
        private string proposedCheckInDate;
        private string proposedCheckoutDate;
        private string actualCheckInDate;        
        private string actualCheckoutDate;
        private string cancellationDate;
        private string cencellationReason;
        public string CencellationReason
        {
            get { return cencellationReason; }
            set { cencellationReason = value; }
        }
        public string CencellationDate
        {
            get { return cancellationDate; }
            set { cancellationDate = value; }
        }
        public string ActualCheckoutDate
        {
            get { return actualCheckoutDate; }
            set { actualCheckoutDate = value; }
        }
        public string ProposedCheckoutDate
        {
            get { return proposedCheckoutDate; }
            set { proposedCheckoutDate = value; }
        }
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string BookingDate
        {
            get { return bookingDate; }
            set { bookingDate = value; }
        }
        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        public string ProposedCheckInDate
        {
            get
            {
                return proposedCheckInDate;
            }

            set
            {
                proposedCheckInDate = value;
            }
        }
        public string ActualCheckInDate
        {
            get
            {
                return actualCheckInDate;
            }
            set
            {
                actualCheckInDate = value;
            }
        }
        public Booking()
        {
        }
        public Booking(int bookingID, string bookingDate, int customerID, string roomID, string proposedCheckInDate, string actualCheckInDate, string proposedCheckoutDate, string actualCheckoutDate, string cancellationDate, string cencellationReason)
        {
            this.bookingID = bookingID;
            this.bookingDate = bookingDate;
            this.customerID = customerID;
            this.roomID = roomID;
            this.proposedCheckInDate = proposedCheckInDate;
            this.actualCheckInDate = actualCheckInDate;
            this.proposedCheckoutDate = proposedCheckoutDate;
            this.actualCheckoutDate = actualCheckoutDate;
            this.cancellationDate = cancellationDate;
            this.cencellationReason = cencellationReason;
        }
        public Booking(string bookingDate, int customerID, string roomID, string proposedCheckInDate, string proposedCheckoutDate)
        {
            this.bookingDate = bookingDate;
            this.customerID = customerID;
            this.roomID = roomID;
            this.proposedCheckInDate = proposedCheckInDate;
            this.proposedCheckoutDate = proposedCheckoutDate;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
