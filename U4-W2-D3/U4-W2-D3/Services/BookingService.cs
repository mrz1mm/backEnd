using U4_W2_D3.Entities;
using U4_W2_D3.Interfaces;

namespace U4_W2_D3.Services
{
    /// <summary>
    /// Servizio per la prenotazione di biglietti
    /// </summary>
    public class BookingService : CrudService<Booking>, IBookingService
    {
        /// <summary>
        /// Ottiene tutte le prenotazioni
        /// </summary>
        private static readonly List<Booking> bookings = [];

        /// <summary>
        /// 
        /// </summary>
        private readonly IHallService hallService;

        /// <summary>
        /// Costruttore del servizio di prenotazione
        /// </summary>
        /// <param name="hallService">Servizio di gestione delle sale</param>
        public BookingService(IHallService hallService)
        {
            this.hallService = hallService;
        }

        public IEnumerable<Booking> GetBookings() => bookings;

        public IEnumerable<Booking> GetBookingsByDate(DateTime date) => bookings.Where(b => b.CreatedAt.Date == date.Date);

        public IEnumerable<Booking> GetBookingsByHall(Hall hall) => bookings.Where(b => b.Hall == hall);

        public IEnumerable<Booking> GetBookingsByUser(User user) => bookings.Where(b => b.User == user);

        public IEnumerable<Statistic> GetStatistics() =>
            hallService.GetHalls()
            .Select(r =>
            new Statistic
            {
                Hall = r,
                FullPriceTicket = bookings.Count(p => p.Hall.Equals(r) && p.Ticket.Type == TicketType.FullPrice),
                ReducedTicket = bookings.Count(p => p.Hall.Equals(r) && p.Ticket.Type == TicketType.Reduced),
            });
    }
}
