using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Acc
{
    class LogUp
    {
        public bool CheckUser(String username)
        {
            try
            {
                using (var dbcontext = new Model1())
                {
                    if (dbcontext.Accounts.Any(tk => tk.UserName == username))
                        return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        /*public List<Account> GetAcc()
        {
            using (var dbcontext = new Model1())
            {
                HashCode hashpass = new HashCode();
                var Acc = from b in dbcontext.Accounts
                                  select new Account()
                                  {
                                      DisplayName = b.DisplayName,
                                      UserName = b.UserName,
                                      PassWord = hashpass.PassHash(b.PassWord),
                                      TypeUser = b.TypeUser,
                                  };
                return Acc.ToList();
            }
        }*/

        public bool NewAccount(Account Acc, string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new Model1())
                {
                    dbcontext.Accounts.Add(Acc);
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;

            }
        }
    }
}
