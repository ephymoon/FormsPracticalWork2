using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPracticalWork2
{
    internal class Admin : User
    {
        public int accessLevel;
        public Admin()
            : base()
        {
            group = "Admin";
            accessLevel = 0;
        }
        public Admin(int uid, string login, string password, string group, int accessLevel)
            : base(uid, login, password, group)
        {
            this.accessLevel = accessLevel;
        }
        public Admin(Admin admin)
        {
            this.accessLevel = admin.accessLevel;
            this.group = admin.group;
            this.uid = admin.uid;
            this.password = admin.password;
            this.login = admin.login;
        }
        public string Access()
        {
            string x;
            switch (accessLevel)
            {
                case 0:
                    {
                        x = "Вы не имеете никакого доступа";
                        break;
                    }
                case 1: 
                    {
                        x = "Вы имеете доступ только к основным темам";
                        break;
                    }
                case 2:
                    {
                        x = "Вы имеете доступ к основным темам, модераторскому чату";
                        break;
                    }
                case 3:
                    {
                        x = "Вы имеете полный администраторский доступ";
                        break;
                    }
                default:
                    {
                        x = "У вас и так максимальный доступ";
                        break;
                    }
            }
            return x;
        }
        public override string Print()
        {
            string x = $"\nuid - {uid}\ngroup - {group}\nlogin - {login}\npassword - {password}\naccessLevel - {accessLevel}";
            return x;
        }

    }
    
    internal class Anon : User
    {
        public string ip;
        public Anon()
            : base()
        {
            group = "Anonimous";
            ip = "null";
        }
        public Anon(int uid, string login, string password, string group, string ip)
            : base (uid, login, password, group)
        {
            this.ip = ip;
        }
        public Anon(Anon anon)
        {
            this.group = anon.group;
            this.ip = anon.ip;
            this.uid = anon.uid;
            this.password = anon.password;
            this.login = anon.login;
        }
        public string WhereFrom()
        {
            string x;
            switch (ip)
            {
                case "null":
                    x = "Местоположение неопределенно";
                    break;
                default:
                    x = "Местоположение было определенно";
                    break;
            }
            return x;
        }
        public override string Print() 
        {
            string x = $"\nuid - {uid}\ngroup - {group}\nlogin - {login}\npassword - {password}\nip - {ip}";
            return x;
        }
    }

    internal class Customer : User
    {
        public string quote;
        public Customer()
            : base()
        {
            group = "user";
            quote = "null";
        }
        public Customer(int uid, string login, string password, string group, string quote)
            : base (uid, login, password, group)
        {
            this.quote = quote;
        }
        public Customer(Customer customer)
        {
            this.group = customer.group;
            this.uid = customer.uid;
            this.password = customer.password;
            this.login = customer.login;
            this.quote = customer.quote;
        }
        public string NameQuote()
        {
            string x = $"Пользователь под логином - {login},\n в своём профиле выставил следующую цитату - {quote}";
            return x;
        }
        public override string Print()
        {
            string x = $"\nuid - {uid}\ngroup - {group}\nlogin - {login}\npassword - {password}\nquote - {quote}";
            return x;
        }
    }
}
