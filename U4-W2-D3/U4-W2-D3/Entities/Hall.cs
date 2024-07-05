namespace U4_W2_D3.Entities
{
    /// <summary>
    /// Una sala del cinema
    /// </summary>
    public class Hall : BaseEntity
    {
        /// <summary>
        /// Nome della sala
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Numero di posti disponibili
        /// </summary>
        public int Capacity { get; set; } = 120;
    }
}
