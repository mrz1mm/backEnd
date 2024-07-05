using U4_W2_D3.Entities;

namespace U4_W2_D3.Interfaces
{
    /// <summary>
    /// Interfaccia per i servizi CRUD
    /// </summary>
    /// <typeparam name="T">Tipo di dato gestito</typeparam>
    public interface ICrudService<T> where T : BaseEntity
    {
        /// <summary>
        /// Crea una nuova entità
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);
        /// <summary>
        /// Aggiorna un'entità esistente
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// Elimina un'entità esistente
        /// </summary>
        /// <param name="entityId"></param>
        void Delete(int entityId);
        /// <summary>
        /// Restituisce un'entità per ID
        /// </summary>
        /// <param name="entityId">Identificativo univoco dell'entità da recuperare</param>
        /// <returns></returns>
        T GetById(int entityId);
    }
}
