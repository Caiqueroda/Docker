using System.ComponentModel.DataAnnotations.Schema;

namespace DockerNewSwitch.Entities.DbSet
{
    public class Msg
    {
        public int Id { get; set; }
        public int Refnum { get; set; }
        public int Trace { get; set; }
        public int Pan { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal TranAmount { get; set; }
        public DateOnly TranDate { get; set; }
        public TimeSpan TranTime { get; set; }
        public DateOnly LocalDate { get; set; }
        public TimeSpan LocalTime { get; set; }
        public int MCC { get; set; }
        public int RespCode { get; set; }

        public virtual Estabelecimento? Estabelecimento {  get; set; }


    }
}
