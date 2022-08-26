using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Siyabonga_Africa.ViewModles;

namespace Siyabonga_Africa.ViewModles
{
    public class loginVM
    {
        public string Username { get; set; }
        public int Passcode { get; set; }

       public List<User> AllUsers { get; set; }

    }
}