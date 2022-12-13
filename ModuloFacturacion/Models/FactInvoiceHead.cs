namespace ModuloFacturacion.Models
{
    public class FactInvoiceHead
    {
        public int InvoiceHeadId { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public double? InvoiceSubtotal { get; set; }

        public double? InvoiceIva { get; set; }

        public double? InvoiceTotal { get; set; }

        public string? CliIdentification { get; set; }

        public int? TypId { get; set; }

        public virtual FactClient? CliIdentificationNavigation { get; set; }

        public virtual ICollection<FactInvoiceDetail> FactInvoiceDetails { get; } = new List<FactInvoiceDetail>();

        public virtual FactPayType? Typ { get; set; }
    }
}
