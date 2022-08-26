using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siyabonga_Africa.ViewModles
{
    public  class philanthropist : User
    {
        private string _isDeleted = "";
        public philanthropist(String UserName ,int PassCode) : base(UserName, PassCode) {
           // DonationPoints = 0;
            _isDeleted = "Active Donator";

        }
        public int DonationPoints{
            get { return DonationPoints; }
            set { DonationPoints = value; }
           }

        public override String ViewRewards()
        {
            return "You Have "+" "+ " DonationPoints";
        }
        public virtual string isDelete
        {
            get { return _isDeleted + "with Donation Score :" + DonationPoints.ToString(); }
        }
        public string Score {
            get { return DonationPoints.ToString(); }
        }

    }
}