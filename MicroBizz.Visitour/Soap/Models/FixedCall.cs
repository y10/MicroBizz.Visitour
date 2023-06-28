using System.Diagnostics;
using System.Runtime.Serialization;

namespace MicroBizz.Visitour.Soap.Models
{
    [DebuggerDisplay("{ExtId}; Info: {Info};")]
    [DataContract(Name = nameof(FixedCall), Namespace = "http://www.tourenserver.de/")]
    public class FixedCall
    {
        [DataMember(Name = "ExtID", IsRequired = true, EmitDefaultValue = false)]
        public string? ExtId { get; set; }

        [DataMember(Name = "VTID", IsRequired = true)]
        public int VtId { get; set; }

        [DataMember(IsRequired = true, Order = 2)]
        public DateTime Date { get; set; }

        [DataMember(IsRequired = true, Order = 3)]
        public DateTime Arrival { get; set; }

        [DataMember(Name = "FMExtID", IsRequired = true, EmitDefaultValue = false, Order = 4)]
        public string? FmExtId { get; set; }

        [DataMember(IsRequired = true, Order = 5)]
        public int Sequence { get; set; }

        [DataMember(IsRequired = true, Order = 6)]
        public bool Fixed { get; set; }

        [DataMember(IsRequired = true, Order = 7)]
        public int State { get; set; }

        [DataMember(IsRequired = true, Order = 8)]
        public int DrivingTime { get; set; }

        [DataMember(IsRequired = true, Order = 9)]
        public int Distance { get; set; }

        [DataMember(IsRequired = true, EmitDefaultValue = false, Order = 10)]
        public string? Info { get; set; }

        [DataMember(IsRequired = true, Order = 11)]
        public int BuendelNr { get; set; }
    }
}
