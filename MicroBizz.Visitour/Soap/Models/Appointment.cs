using System.Diagnostics;
using System.Runtime.Serialization;

namespace MicroBizz.Visitour.Soap.Models
{
    [DebuggerDisplay("{FunctionCode}; Status: {Status}; Info: {Info}")]
    [DataContract(Name = nameof(Appointment), Namespace = "http://www.tourenserver.de/")]
    public class Appointment
    {
        [DataMember(IsRequired = true)]
        public int FunctionCode { get; set; }

        [DataMember(IsRequired = true)]
        public int Status { get; set; }

        [DataMember(IsRequired = true, Order = 2)]
        public DateTime Date { get; set; }

        [DataMember(IsRequired = true, Order = 3)]
        public DateTime Time { get; set; }

        [DataMember(IsRequired = true, Order = 4)]
        public int Detour { get; set; }

        [DataMember(Name = "FMVTID", IsRequired = true, EmitDefaultValue = false, Order = 5)]
        public string? FmVtId { get; set; }

        [DataMember(Name = "FMExtID", IsRequired = true, EmitDefaultValue = false, Order = 6)]
        public string? FmExtId { get; set; }

        [DataMember(IsRequired = true, EmitDefaultValue = false, Order = 7)]
        public string? Info { get; set; }

        [DataMember(IsRequired = true, Order = 8)]
        public float Cost { get; set; }
    }
}
