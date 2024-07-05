using U4_W2_D3.Entities;
namespace U4_W2_D3.Interfaces
{
    /// <summary>
    /// Servizio per la gestione delle prenotazioni
    /// </summary>
    public interface IBookingService : ICrudService<Booking>
    {
        /// <summary>
        /// Ottiene tutte le prenotazioni
        /// </summary>
        IEnumerable<Booking> GetBookings();
        /// <summary>
        /// Ottiene le prenotazioni per una data specifica
        /// </summary>
        IEnumerable<Booking> GetBookingsByDate(DateTime date);
        /// <summary>
        /// Ottiene le prenotazioni per una sala specifica
        /// </summary>
        IEnumerable<Booking> GetBookingsByHall(Hall hall);
        /// <summary>
        /// Ottiene le prenotazioni per un utente specifico
        /// </summary>
        IEnumerable<Booking> GetBookingsByUser(User user);
        /// <summary>
        /// Ottiene le statistiche sulle prenotazioni
        /// </summary>
        IEnumerable<Statistic> GetStatistics();
    }
}
