using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonnaCentrala
{
    public interface IPhoneNumber
    {
        void ValidateData();
        void PrintDetails();
    }
}
