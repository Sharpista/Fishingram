namespace Fishingram.Domain.ValueObject.Entities
{
    public class FullAddress
    {
        public virtual string ZipCode { get; private set; }
        public virtual string Street { get; private set; }
        public virtual string Number { get; private set; }
        public virtual string District { get; private set; }
        public virtual string State { get; private set; }
        public virtual string UF { get; private set; }

        public FullAddress(string zipCode, string number, string street, string district,string state, string uF)
        {
            ZipCode = zipCode;
            Number = number;
            Street = street;
            District = district;
            State = state;
            UF = uF;
        }
    }
}
