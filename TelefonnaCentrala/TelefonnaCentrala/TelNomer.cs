using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonnaCentrala
{
    class TelNomer : Danni
    {
        private string ownerName;
        private int number;

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public TelNomer(int number,int age,string profession,string address,string ownername) :base(age,address,profession)
        {
            this.Number = number;
            this.OwnerName = ownername;

        }

        public override void ValidateData()
        {
            if (string.IsNullOrEmpty(Number))
            {
                throw new Exception("Tel. nomer ne moje da bude prazen!");
            }
        }
    }
}
