using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheCosmosHotel
{
    class Room
    {
        private int roomNo;
        private string roomType;
        private double dailyRate;
        private string status;

        public int RoomNo
        {
            get
            {
                return roomNo;
            }

            set
            {
                roomNo = value;
            }
        }

        public string RoomType
        {
            get
            {
                return roomType;
            }

            set
            {
                roomType = value;
            }
        }

        public double DailyRate
        {
            get
            {
                return dailyRate;
            }

            set
            {
                dailyRate = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public Room(int roomNo, string roomType, double dailyRate, string status)
        {
            this.RoomNo = roomNo;
            this.RoomType = roomType;
            this.DailyRate = dailyRate;
            this.Status = status;
        }
    }
}
