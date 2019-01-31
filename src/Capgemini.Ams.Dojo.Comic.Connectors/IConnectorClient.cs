namespace Capgemini.Ams.Dojo.Comic.Connectors
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter;
    using Capgemini.Ams.Dojo.Comic.Model;

    /// <summary>Interface de defition du point d'entree d'un connecteur</summary>
    public interface IConnectorClient<T> where T : class, IResourceBase
    {
        /// <summary>Definition de la methode recevant les demandes de récuperation de données</summary>
        /// <param name="query">Object Query qui contient les parametres de la requête vers la source</param>
        /// <returns>returns T qui encapsule un ensemble de ressources</returns>
        Task<IEnumerable<T>> FetchData(ApiQuery query);
    }
}
