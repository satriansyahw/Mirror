using EFHelper.Filtering;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.General
{
    public interface IBasicController
    {
        IActionResult Get();
        Task<IActionResult> SimpanListAsync<TView, TOriginal>(List<TView> listEntity) where TView : class, ISaveUpdateProperties where TOriginal : class, ISaveUpdateProperties;
        Task<IActionResult> SimpanAsync<TView, TOriginal>(TView entity) where TView : class, ISaveUpdateProperties where TOriginal : class, ISaveUpdateProperties;
        Task<IActionResult> DeleteAsync<T>( DeleteById delete) where T : class, IDeleteProperties;
        Task<IActionResult> DeleteListAsync<T>(List<DeleteById> deleteList) where T : class, IDeleteProperties;
        Task<IActionResult> ListDataAsync<TSource, TResult>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) 
            where TSource : class where TResult : class;
        Task<IActionResult> SearchByIdAsync<T>(int Id) where T : class;
        Task<IActionResult> UpdateListAsync<TView, TOriginal>(List<TView> listEntity) where TView : class, ISaveUpdateProperties where TOriginal : class, ISaveUpdateProperties;
        Task<IActionResult> UpdateAsync<TView, TOriginal>(TView entity) where TView : class, ISaveUpdateProperties where TOriginal : class, ISaveUpdateProperties;
    }

    public interface ISaveUpdateProperties
    {
        int InsertById { get; set; }
        string InsertBy { get; set; }
        int UpdateById { get; set; }
        string UpdateBy { get; set; }
    }
    public interface IDeleteProperties
    {
        int ID { get; set; }
        int UpdateById { get; set; }
    }
    public class DeleteById
    {
        public int DeletedId { get; set; }
        public int UpdateById { get; set; }
    }
}
