namespace U4_W2_D3.Entities
{
    /// <summary>
    /// Un utente del sistema
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// Il nome
        /// </summary>
        public required string FirstName { get; set; }
        /// <summary>
        /// Il cognome
        /// </summary>
        public required string LastName { get; set; }
    }
}
