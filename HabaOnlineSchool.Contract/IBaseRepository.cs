using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabaOnlineSchool.Contract
{
    /// <summary>
    /// Adding The Interface IBase Reposotry 
    /// We will add the parameter T 
    /// We will implement this interface inside our data project,  by calling it Base Repository
    /// </summary>
    /// <typeparam name ="T"></typeparam>
    public interface IBaseRepository<T>
    {
        //THis method will return IQueryable of T
        //return T with GetAll,it is a collection Type
        IQueryable<T> GetAll();
        //Method for retrieving an element returning an object of type T
        //Retrieve an element by its Id
        T GetById(int id);
        //Addding element by using entiry T like element
        /// <param name="entity"></param>
       
        void Add(T entity);
        /// <summary>
        /// Modifier
        /// </summary>
        /// <param name="entity"></param>
        void Uppdate(T entity);
        //Delete/// <summary>
        ///Delete
        /// </summary>
        /// <param name="entity"></param>
        void Delete(int Id);
    }



}

