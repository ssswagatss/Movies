using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Interfaces
{
    public interface IGenericRepository<T>
    {
        /// <summary>
        /// Add an object of Type T to the dataset
        /// </summary>
        /// <param name="entity">The object that requires to be added</param>
        /// <returns></returns>
        T Add(T entity);

        /// <summary>
        /// Removes an object of Type T from the dataset
        /// </summary>
        /// <param name="entity">The object that requires to be removed</param>
        /// <returns></returns>
        T Delete(T entity);

        /// <summary>
        /// Attach an Entity to the data set and changes its entity state to Modified
        /// </summary>
        /// <param name="entity">The object that requires to be edited</param>
        /// <returns>Void</returns>
        void Edit(T entity);


        /// <summary>
        /// Commit the changes to the database
        /// </summary>
        /// <returns>Void</returns>
        void Save();
        /// <summary>
        /// Commit the changes to the database Asynchronously
        /// </summary>
        /// <returns>Void</returns>
        Task<int> SaveAsync();
        /// <summary>
        /// Fetches all the Entities of Type T
        /// </summary>
        /// <returns>All entities present as IEnumerable</returns>
        IEnumerable<T> GetAll();
    }
}
