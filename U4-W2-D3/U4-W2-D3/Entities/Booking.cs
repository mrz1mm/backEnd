namespace U4_W2_D3.Entities
{
    /// <summary>
    /// La prenotazione di un biglietto
    /// </summary>
    public class Booking : BaseEntity
    {
        /// <summary>
        /// Il biglietto prenotato
        /// </summary>
        public required Ticket Ticket { get; set; }
        /// <summary>
        /// L'utente che ha effettuato la prenotazione
        /// </summary>
        public required User User { get; set; }
        /// <summary>
        /// La sala in cui si svolge la proiezione
        /// </summary>
        public required Hall Hall { get; set; }

    }
}
