namespace U4_W2_D3.Entities
{
    /// <summary>
    /// Statistiche di riempimento di una sala
    /// </summary>
    public class Statistic : BaseEntity
    {
        /// <summary>
        /// La sala di cui si vogliono calcolare le statistiche
        /// </summary>
        public required Hall Hall { get; set; }
        /// <summary>
        /// Il numero di biglietti interi venduti
        /// </summary>
        public int FullPriceTicket { get; set; }
        /// <summary>
        /// Il numero di biglietti ridotti venduti
        /// </summary>
        public int ReducedTicket { get; set; }
        /// <summary>
        /// Il numero totale di biglietti venduti
        /// </summary>
        public int TotalTicket { get; set; }
        /// <summary>
        /// La percentuale di posti occupati
        /// </summary>
        public decimal Percentage { get; set; }
    }
}
