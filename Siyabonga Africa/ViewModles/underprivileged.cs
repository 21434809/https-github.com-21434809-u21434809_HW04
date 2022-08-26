using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siyabonga_Africa.ViewModles
{
    public  class underprivileged : User
    {
        private string _isDeleted = "";
        public underprivileged(String UserName, int PassCode):base(UserName, PassCode)
        {
           // WorkingScore = 0;
            _isDeleted = "Active User";
        }

        public void Delete() {
            _isDeleted = "User Hase been Deleted";
        }
        public int WorkingScore
        {
            get { return WorkingScore; }
            set { WorkingScore = value; }
        }
        public string Score
        {
            get { return WorkingScore.ToString(); }


        }
        public override String ViewRewards()
        {
          return "You have " + " " + " rewards"; 
        }
        public virtual string isDelete
        {
            get { return _isDeleted + "with Working Score :" + WorkingScore.ToString(); } 
        }
    }
}