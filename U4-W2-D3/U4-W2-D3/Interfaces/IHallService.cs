using U4_W2_D3.Entities;
namespace U4_W2_D3.Interfaces
{
    /// <summary>
    /// Interfaccia per i servizi relativi alle sale
    /// </summary>
    public interface IHallService
    {
        /// <summary>
        /// Restituisce tutte le sale
        /// </summary>
        IEnumerable<Hall> GetHalls();
    }
}
