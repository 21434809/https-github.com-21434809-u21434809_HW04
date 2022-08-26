using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siyabonga_Africa.ViewModles
{
    public class admin : User
    {
        private string _isDeleted = "";
        public admin(String UserName, int PassCode) : base(UserName, PassCode)
        {
            _isDeleted = "Active Admin";
        }
        public void Delete()
        {
            _isDeleted = "Admin Hase been Deleted";
        }
        public int _ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public override String ViewRewards()
        {
            return "You have one reward";
        }
        public virtual string isDelete()
        {
            return _isDeleted;
        }
    }
}