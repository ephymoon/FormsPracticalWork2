using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPracticalWork2
{
    internal class User
    {
        public int uid;
        public string login;
        public string password;
        public string group;
        public User() 
        {
            uid = 0;
            login = "null";
            password = "null";
            group = "null";
        }
        public User(int uid, string login, string password, string group)
        {
            this.uid = uid;
            this.login = login;
            this.password = password;
            this.group = group;
        }
        public User(User user)
        {
            this.uid = user.uid;
            this.login = user.login;
            this.password = user.password;
            this.group = user.group;
        }
        public virtual string Print()
        {
            string x = $"uid - {uid}\ngroup - {group}\nlogin - {login}\npassword - {password}";
            return x;
        }
    }
}
