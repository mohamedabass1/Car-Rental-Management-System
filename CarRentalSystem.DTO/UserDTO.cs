using System;

namespace CarRentalSystem.DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }

        public int PersonID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Permissions { get; set; }

        public DateTime JoinDate { get; set; }

        public string ImagePath { get; set; }

        public bool IsActive { get; set; }
    }
}