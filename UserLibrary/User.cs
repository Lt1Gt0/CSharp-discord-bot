using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLibrary {
    public abstract class User {
        protected ulong id { get; set; }
        protected string name { get; set; }

        public User(ulong _id, string _name) {
            id = _id;
            name = _name;
        }
    }
}
