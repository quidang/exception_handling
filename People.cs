using System;

namespace ExceptionTask
{
    public class EnteringRoom
    {
        public string roomNumber; 
        public string fullName;
        public DateTime dateEntered;
        public TimeSpan timestayed; 

        public EnteringRoom (string roomNumber, string fullName, DateTime dateEntered, TimeSpan timeStayed) 
        {
            this.roomNumber = roomNumber;
            this.fullName = fullName; 
            this.dateEntered = dateEntered; 
            this.timestayed = timeStayed; 
        }
    }
}