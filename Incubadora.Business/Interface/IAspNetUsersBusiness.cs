using Incubadora.Domain;
using System.Collections.Generic;

namespace Incubadora.Business.Interface
{
    public interface IAspNetUsersBusiness
    {
        List<AspNetUsersDomainModel> GetUsers();
        /// <summary>
        /// Este metodo se encarga de realizar la insercion o actualizacion de una entidad AspNetUsersDM
        /// </summary>
        /// <param name="aspNetUsersDM">la entidad aspnetuserdm</param>
        /// <returns>un valor true/false</returns>
        bool AddUpdateUser(AspNetUsersDomainModel aspNetUsersDM);
    }
}
