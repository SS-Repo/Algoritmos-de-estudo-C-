using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo21
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if (user.isAdmin)
            {
                return true;
            }
            if (MadeBy == user)
            {
                return true;
            }
            return false;
        }
    }

    public class User
    {
        public bool isAdmin { get; set; }
    }
}
