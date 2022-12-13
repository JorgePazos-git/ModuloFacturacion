namespace ModuloFacturacion.Models
{
    public class FactPayType
    {
        public int TypId { get; set; }

        public string? Typ { get; set; }

        public virtual ICollection<FactClient> FactClients { get; } = new List<FactClient>();

        public virtual ICollection<FactInvoiceHead> FactInvoiceHeads { get; } = new List<FactInvoiceHead>();
    }
}
