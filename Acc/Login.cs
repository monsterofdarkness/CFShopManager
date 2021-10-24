using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Acc
{
    class Login
    {

        public Account CheckLogin(string username, string password,Model1 dbcontext)
        {
            //try
            //{
            //var account = dbcontext.Accounts.SingleOrDefault(a => a.UserName.Equals(username));
            Account account = dbcontext.Accounts.SingleOrDefault(a => a.UserName.Equals(username));
                if (account != null)
                {
                    if(BCrypt.Net.BCrypt.Verify(password, account.PassWord))
                    {
                        return account;
                    }
                }
                return null;
                    //return dbcontext.Accounts.Any(tk => tk.UserName == username && tk.PassWord == HashCode.HashPassword(password));

            //}
            //catch (Exception exception)
            //{
             //   error = exception.Message;
                //return false;
            //}
        }
    }
}