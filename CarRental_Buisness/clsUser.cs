using CarRental_DataAccess;
using CarRental_DTO;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CarRental_Buisness
{
    public class clsUser
    {
        enum enMode
        {
            AddNew = 0, Update = 1
        }

        enMode _Mode = enMode.AddNew;

        public int UserID { get; set; }

        public int PersonID { get; set; }

        public clsPerson PersonInfo;

        public string Username { get; set; }

        public string Password { get; set; }

        public int Permissions { get; set; }

        public DateTime JoinDate { get; set; }

        public string ImagePath { get; set; }

        public bool IsActive { get; set; }


        public clsUser()
        {
            UserID = -1;
            PersonID = -1;

            PersonInfo = new clsPerson();

            Username = "";
            Password = "";
            Permissions = 0;

            JoinDate = DateTime.Now;

            ImagePath = "";

            IsActive = true;

            _Mode = enMode.AddNew;
        }


        private clsUser(
            int userID,
            int personID,
            string username,
            string password,
            int permissions,
            DateTime joinDate,
            string imagePath,
            bool isActive)
        {
            UserID = userID;

            PersonID = personID;

            Username = username;

            Password = password;

            Permissions = permissions;

            JoinDate = joinDate;

            ImagePath = imagePath;

            IsActive = isActive;

            _Mode = enMode.Update;
        }

        // DTO Converter

        internal UserDTO ToDTO()
        {
            return new UserDTO
            {
                UserID = this.UserID,
                PersonID = this.PersonID,
                Username = this.Username,
                Password = this.Password,
                Permissions = this.Permissions,
                JoinDate = this.JoinDate,
                ImagePath = this.ImagePath,
                IsActive = this.IsActive
            };
        }


        private async Task<bool> _AddNewAsync()
        {
            this.UserID =
                await clsUser_DA.AddNewUserAsync(this.ToDTO());

            return this.UserID != -1;
        }


        private async Task<bool> _UpdateAsync()
        {
            return await clsUser_DA.UpdateUserAsync(this.ToDTO());
        }
        internal void MarkAsSaved()
        {
            _Mode = enMode.Update;
        }
        public async Task<bool> SaveAsync()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    if (await _AddNewAsync())
                    {
                        _Mode = enMode.Update;

                        return true;
                    }

                    break;

                case enMode.Update:

                    return await _UpdateAsync();
            }

            return false;
        }

        public static async Task<clsUser> FindByIDAsync(int userID)
        {
            UserDTO user =
                await clsUser_DA
                .GetUserByIDAsync(userID);

            if (user == null)
                return null;

            clsUser newUser = new clsUser
                                        (
                                            user.UserID,
                                            user.PersonID,
                                            user.Username,
                                            user.Password,
                                            user.Permissions,
                                            user.JoinDate,
                                            user.ImagePath,
                                            user.IsActive
                                        );

            // load personal info
            newUser.PersonInfo = await clsPerson.FindAsync(user.PersonID);

            return newUser;
        }



        public static async Task<clsUser> FindByUsernameAsync(string username)
        {
            UserDTO user = await clsUser_DA.GetUserByUsernameAsync(username);

            if (user == null)
                return null;

            clsUser newUser = new clsUser
                                        (
                                            user.UserID,
                                            user.PersonID,
                                            user.Username,
                                            user.Password,
                                            user.Permissions,
                                            user.JoinDate,
                                            user.ImagePath,
                                            user.IsActive
                                        );


            // load personal info
            newUser.PersonInfo = await clsPerson.FindAsync(user.PersonID);

            return newUser;
        }


        public static async Task<bool> DeleteUserAsync(int userID)
        {
            return await clsUser_DA
                .DeleteUserAsync(userID);
        }



        public static async Task<bool> IsUserExistsAsync(string userName)
        {
            return await clsUser_DA.IsUserExistsAsync(userName);
        }
        public static async Task<bool> IsUserExistsAsync(int userID)
        {
            return await clsUser_DA.IsUserExistsAsync(userID);
        }
        public static async Task<DataTable> GetAllUsersAsync()
        {
            return await clsUser_DA.GetAllUsersAsync();
        }
    }
}