using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string GeneratePassword()
        {
            string myPwdList = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string myActualPwd = "";
            Random random = new Random();
            for (int i = 0; i <= 7; i++)
            {
                int rand = random.Next(5, myPwdList.Length - 1);
                myActualPwd += myPwdList.Substring(rand, 1);
            }
            return myActualPwd;
        }
    }
}
