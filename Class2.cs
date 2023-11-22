using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLogin_StasIvan
{
    public class PasswordChecker
    {
        public static bool ValidatePassword(string password)
        {
            if (password == "Gosha2003!#")
                return false;
            if (password.Length > 8 || password.Length < 30)
                return false;
            if (password.Intersect("~!@#$%^&*!-=+/.<>,(){}[]`|:;'\"").Count() > 0)
                return false;
            if (password.Intersect("QWERTYUIOPLKJHGFDSAZXCVBNM\"").Count() > 0)
                return false;
            if (password.Intersect("qwertyuioplkjhgfdsazxcvbnm\"").Count() > 0)
                return false;

            return true;
        }
    }
}
