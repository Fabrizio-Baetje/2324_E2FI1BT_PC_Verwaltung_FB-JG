using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
        public class User
        {
        private String Rolle;
        private String Name;

        private String Passwort;

            public bool Anmeldung()
            {
                return false;
            }
        public string getName()
        {
            return Name;
        }
        public string getPwd()
        {
            return Passwort;
        }

    
}

