using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siyabonga_Africa.ViewModles
{
    public abstract class User

    {
        private int _Password;
        private string NameOfUser;
        private static bool LoggedIn = false;
        public User(String UserName,int Password) {
              NameOfUser = UserName;
            _Password = Password;
        }
     public string Name
        {
            get { return NameOfUser; }
            set { NameOfUser = value; }
        }
        public int Passcode
        {
            get { return _Password; }
            set { _Password = value; }
        }
        //public string _Name { get; set; }
        //public string Email { get; set; }

        //public int Id { get; set; }

        //public DateTime Created { get; set; }

        //public bool IsDeleted { get; set; } 

        public virtual bool Delete()
        {
            return false;
        }
        //public int GenerateID(DateTime DateTimeNow) { 

        //        return Id++;
        //  }
        public abstract String ViewRewards();
    }
}