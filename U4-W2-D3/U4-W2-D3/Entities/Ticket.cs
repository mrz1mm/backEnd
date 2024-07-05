namespace U4_W2_D3.Entities
{
    /// <summary>
    /// Tipo di biglietto
    /// </summary>
    public enum TicketType
    {
        /// <summary>
        /// Biglietto intero
        /// </summary>
        FullPrice,
        /// <summary>
        /// Biglietto ridotto
        /// </summary>
        Reduced
    }
    public class Ticket : BaseEntity
    {
        /// <summary>
        /// Tipo di biglietto
        /// </summary>
        public TicketType Type { get; set; }
    }
}
