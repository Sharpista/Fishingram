using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.Domain.ValueObject.Entities
{
    public class FullAddress
    {
        public virtual string ZipCode { get; private set; }
        public virtual string Adress { get; private set; }
        public virtual string Country { get; private set; }
        public virtual string State { get; private set; }
        public virtual string UF { get; private set; }

        public FullAddress(string zipCode, string adress, string country, string state, string uF)
        {
            ZipCode = zipCode;
            Adress = adress;
            Country = country;
            State = state;
            UF = uF;
        }
    }
}
