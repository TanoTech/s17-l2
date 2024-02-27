namespace s17_l1.Models
{
    public class Payment
    {
        public int Id { get; set;}
        public DateOnly PeriodoPagamento{get; set;}
        public decimal Totale {get; set;}

        public bool StipendioAcconto {get; set;}
    }
}