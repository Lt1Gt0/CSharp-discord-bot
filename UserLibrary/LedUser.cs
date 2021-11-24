using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLibrary
{
    public class LedUser : User
    {
        public string priv { get; set; }
        public bool currently_allowed { get; set; }
        public LedUser(ulong _id, string _name, string _priv, bool _currently_allowed) : base(_id, _name){
            id = _id;
            name = _name;
            priv = _priv;
            currently_allowed = _currently_allowed;
        }
    }
}
