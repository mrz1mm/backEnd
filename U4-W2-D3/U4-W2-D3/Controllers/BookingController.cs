using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using U4_W2_D3.Models; // chiedere come fare l'implementazione rapida senza doverlo scrivere a mano

namespace U4_W2_D3.Controllers
{
    public class BookingController : Controller
    {
        // simuliamo un database
        private static List<Hall> Halls = new List<Hall>
        {
            new Hall { Id = 1, Name = "SALA NORD"},
            new Hall { Id = 2, Name = "SALA EST"},
            new Hall { Id = 3, Name = "SALA SUD"}
        };

        private static List<Booking> Bookings = new List<Booking>();

        public IActionResult Index()
        {
            ViewBag.Halls = Halls;
            return View();
        }

        [HttpPost]
        public IActionResult BookTicket(Booking booking)
        {
            var hall = Halls.FirstOrDefault(h => h.Name == booking.HallName);
            if (hall != null && hall.TicketsSold < hall.Capacity)
            {
                hall.TicketsSold++;
                if (booking.IsReducedTicket)
                {
                    hall.ReducedTicketsSold++;
                }
                Bookings.Add(booking);
            }
            // Aggiorna la vista con i dati aggiornati
            ViewBag.Halls = Halls;
            return View("Index");
        }
    }
}

