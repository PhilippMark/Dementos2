using EFMonkey;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration
{   
    public class User
    {

        //public int? GetLogin(string login, string password)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        var logins = context.Login.ToList();
        //        var users = context.User.ToList();
        //        Login loginVal = context.Login.FirstOrDefault(l => l.LoginName == login && l.Password == password);
        //        if(loginVal != null)
        //        {
        //            return context.User.Single(u => u.Login.Id == loginVal.Id).Id;
        //        }
        //        return null;
        //    }
        //}

        //public int InsertUserAdmin(string login, string password, string name, string firstname, string lastname)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {

        //        if (context.Login.Where(l => l.LoginName == login).ToList().Count > 0)
        //        {
        //            return -1;
        //        }           
        //        Login loginEntity = new Login();
        //        EFMonkey.Corporation corp = new EFMonkey.Corporation();
        //        EFMonkey.User user = new EFMonkey.User();
        //        loginEntity.LoginName = login;
        //        loginEntity.Password = password;

        //        corp.Name = name;

        //        user.FirstName = firstname;
        //        user.LastName = lastname;
        //        loginEntity.User = user;
        //        user.CorporationAdmin = true;
        //        user.Corporation = corp;


        //        context.User.Add(user);
        //        context.Login.Add(loginEntity);

        //        context.SaveChanges();

        //        return user.Id;
        //    }
        //}

        //public string GetCorpName(string id)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        int userId = Convert.ToInt32(id);
        //        return context.User.Include(e => e.Corporation).Where(c => c.Id == userId).First().Corporation.Name;
        //    }

        //}

        public EFMonkey.User GetUserById(int userId)
        {
            using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
            {
                return context.User.First(u => u.Id == userId);
            }
        }

        //public string GetUserNameById(int userId)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        EFMonkey.User user = context.User.First(u => u.Id == userId);
        //        return user.FirstName + " " + user.LastName;
        //    }
        //}

        //public int InsertUser(string login, string password, string firstname, string lastname, int corpId, string queryString)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {

        //        if (context.Login.Where(l => l.LoginName == login).Count() > 0)
        //        {
        //            return -1;
        //        }

        //        Login loginEntity = new Login();
        //        loginEntity.LoginName = login;
        //        loginEntity.Password = password;

        //        EFMonkey.User user = new EFMonkey.User();
        //        user.FirstName = firstname;
        //        user.LastName = lastname;

        //        loginEntity.User = user;
        //        context.User.Add(user);
        //        context.Login.Add(loginEntity);
        //        EFMonkey.Corporation corpo = context.Corporation.Include(c => c.CorporationUsers).SingleOrDefault(c => c.Id == corpId);
        //        corpo.CorporationUsers.Add(user);

        //        context.Corporation.Attach(corpo);
        //        var entry = context.Entry(corpo);

        //        UsedRegistration ur = new UsedRegistration();
        //        ur.Registrations = queryString;
        //        context.UsedRegistration.Add(ur);

        //        context.SaveChanges();

        //        return user.Id;
        //    }
        //}

        //public DataTable GetUsersByCorporation(int corpId)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        IList<EFMonkey.User> users = context.Corporation.Include(c => c.CorporationUsers).FirstOrDefault(c => c.Id == corpId).CorporationUsers.ToList();
        //        DataTable table = new DataTable();
        //        if (users.Count > 0)
        //        {
        //            table.Columns.Add("name");
        //            table.Columns.Add("id");

        //            foreach (EFMonkey.User user in users)
        //            {
        //                DataRow row = table.NewRow();
        //                row["name"] = user.FirstName + " " + user.LastName;
        //                row["id"] = user.Id;
        //                table.Rows.Add(row);
        //                table.AcceptChanges();
        //            }
        //        }
        //        return table;
        //    }
        //}

        ////public IList<User> GetUserList()
        ////{
        ////    using (EFMonkeyContext context = new EFMonkeyContext())
        ////    {
        ////        return IList()context.User.ToList();
        ////    }
        ////}

        ////public void InsertUser(User user)
        ////{
        ////    using (EFMonkeyContext context = new EFMonkeyContext())
        ////    {
        ////        int userId = context.User.Add(user).Id;
        ////        context.SaveChanges();
        ////    }
        ////}
    }
}
