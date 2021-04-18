using Digital_Photo_Diary.Data_Access_Layer;
using Digital_Photo_Diary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Photo_Diary.Codes
{
    class UserRegistrationService
    {
        UserDataAccess userDataAccess;

        public UserRegistrationService()
        {
            this.userDataAccess = new UserDataAccess();
        }

        public int AddUser(string name, string userName, string password, string email, string gender, string dateofBirth, string bloodGroup)
        {
            User user = new User()
            {
                Name = name,
                UserName = userName,
                Password = password,
                Email = email,
                Gender = gender,
                DateOfBirth = dateofBirth,
                BloodGroup = bloodGroup
            };
            this.userDataAccess = new UserDataAccess();
            return this.userDataAccess.AddUser(user);
        }

        public string LoginValidation(string userName)
        {
            User user = new User()
            {
                UserName = userName,
                
            };
            return userDataAccess.Search(user);
        }
    }
}
