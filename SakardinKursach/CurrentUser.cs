using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakardinKursach
{
    class CurrentUser
    {
        public int id;
        public string name;
        public string Password; 
       
        public CurrentUser(int iD, string Name, string password) 
        {
            this.id = iD;
            this.name = Name;
            this.Password = password;     
        }
    }
}
