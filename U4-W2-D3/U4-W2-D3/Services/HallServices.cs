using U4_W2_D3.Entities;
using U4_W2_D3.Interfaces;

namespace U4_W2_D3.Services
{
    /// <summary>
    /// Servizi relativi alle sale
    /// </summary>
    public class HallServices : CrudService<Hall>, IHallService
    {
        private static readonly List<Hall> _halls = [
            new Hall { Name = "Sala Nord", Capacity = 100, Id = 1 },
            new Hall { Name = "Sala Est", Capacity = 80, Id = 2 },
            new Hall { Name = "Sala Ovest", Capacity = 3, Id= 3 },
            new Hall { Name = "Sala Sud", Capacity = 1, Id = 4 }
        ];

        public IEnumerable<Hall> GetHalls() => _halls;
    }
}