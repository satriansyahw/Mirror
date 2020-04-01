using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFHelper;
using EFHelper.ColumnHelper;
using EFHelper.Filtering;
using GenHelper.Compress;
using GenHelper.Props;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.General
{

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [EnableCors("MirrorCORS")]
    [ValidateHeaderAntiForgery]
    [Route("api/[controller]")]
    public class BasicController : ControllerBase, IBasicController
    {
        private readonly CompressObject compress = CompressObject.GetInstance;
        private readonly RepoWrapperAsync repo = RepoWrapperAsync.GetInstance;
        private readonly PropHelper prop = PropHelper.GetInstance;
        private readonly APIReturn apiReturn = new APIReturn();
        private readonly ColumnPropGet column = ColumnPropGet.GetInstance;
        private byte[] jsonResult = null;

        [HttpGet]
        [AllowAnonymous]
        [Route("Get")]
        public IActionResult Get()
        {
            string hasil = "Hi Hello World2";
            jsonResult = compress.CompressedData(hasil);
            return Ok(hasil);
        }

        public async Task<IActionResult> SimpanAsync<TView, TOriginal>([FromBody] TView entity)
            where TView : class, ISaveUpdateProperties
            where TOriginal : class, ISaveUpdateProperties
        {
            var data = prop.CopyPropertiesTo<TView, TOriginal>(entity);
            data.InsertById = entity.InsertById;
            data.InsertBy = entity.InsertBy;            
            var hasil = await repo.SaveAsync<TOriginal>(data);
            bool isSaved = repo.ConvertReturnValueToBool(hasil);
            jsonResult = compress.CompressedData(isSaved);
            return Ok(jsonResult);
        }


        public async Task<IActionResult> SimpanListAsync<TView, TOriginal>([FromBody] List<TView> listEntity)
            where TView : class, ISaveUpdateProperties
            where TOriginal : class ,ISaveUpdateProperties
        {
            var listData = prop.CopyPropertiesTo<TView, TOriginal>(listEntity);
            for (int i = 0; i < listData.Count; i++)
            {
                listData[i].InsertById = listEntity[0].InsertById;
                listData[i].InsertBy = listEntity[0].InsertBy;
            }
            var hasil = await repo.SaveListAsync<TOriginal>(listData);
            bool isSaved = repo.ConvertReturnValueToBool(hasil);
            jsonResult = compress.CompressedData(isSaved);
            return Ok(jsonResult);
        }

        public async Task<IActionResult> DeleteAsync<T>(DeleteById delete) where T : class, IDeleteProperties
        {
            T kelas = Activator.CreateInstance<T>();
            kelas.ID = delete.DeletedId;
            kelas.UpdateById = delete.UpdateById;

            var hasil = await repo.DeleteActiveBoolAsync<T>(kelas);
            bool isSaved = repo.ConvertReturnValueToBool(hasil);
            jsonResult = compress.CompressedData(isSaved);
            return Ok(jsonResult);
        }

        public async Task<IActionResult> DeleteListAsync<T>(List<DeleteById> deleteList) where T : class, IDeleteProperties
        {
            List<T> listKelas = new List<T>();
            for (int i = 0; i < deleteList.Count; i++)
            {
                T kelas = Activator.CreateInstance<T>();
                kelas.ID = deleteList[i].DeletedId;
                kelas.UpdateById = deleteList[i].UpdateById;
            }
            var hasil = await repo.DeleteActiveBoolListAsync<T>(listKelas);
            bool isSaved = repo.ConvertReturnValueToBool(hasil);
            jsonResult = compress.CompressedData(isSaved);
            return Ok(jsonResult);
        }

        public async Task<IActionResult> ListDataAsync<TSource, TResult>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake)
            where TSource : class
            where TResult : class
        {
            var hasil = await repo.ListDataAsync<TSource, TResult>(SearchFieldList, sortColumn, isascending, toptake);
            List<TResult> listResult = repo.ConvertReturnValueToList<TResult>(hasil);
            apiReturn.Message = APIMessage.APISuccess;
            apiReturn.Data1 = listResult;
            jsonResult = compress.CompressedData(apiReturn);
            return Ok(jsonResult); 
        }

        public async Task<IActionResult> SearchByIdAsync<T>(int Id) where T : class
        {
            var pk = column.GetIdentityColumnProps<T>();
            List<SearchField> SearchFieldList = new List<SearchField>();
            SearchFieldList.Add(new SearchField { Name = pk.Name, Operator = "=", Value = Id });
            var hasil = await repo.ListDataAsync<T>(SearchFieldList, pk.Name, true, 0);
            T result = repo.ConvertReturnValueToClass<T>(hasil);
            apiReturn.Message = APIMessage.APISuccess;
            apiReturn.Data1 = result;
            jsonResult = compress.CompressedData(apiReturn);
            return Ok(jsonResult);
        }

        public async Task<IActionResult> UpdateListAsync<TView, TOriginal>(List<TView> listEntity)
            where TView : class, ISaveUpdateProperties
            where TOriginal : class, ISaveUpdateProperties
        {
            var listData = prop.CopyPropertiesTo<TView, TOriginal>(listEntity);
            for (int i = 0; i < listData.Count; i++)
            {
                listData[i].UpdateById = listEntity[0].InsertById;
                listData[i].UpdateBy = listEntity[0].UpdateBy;
            }
            var hasil = await repo.UpdateListAsync<TOriginal>(listData);
            bool isSaved = repo.ConvertReturnValueToBool(hasil);
            jsonResult = compress.CompressedData(isSaved);
            return Ok(jsonResult);
        }

        public async Task<IActionResult> UpdateAsync<TView, TOriginal>(TView entity)
            where TView : class, ISaveUpdateProperties
            where TOriginal : class, ISaveUpdateProperties
        {
            var data = prop.CopyPropertiesTo<TView, TOriginal>(entity);
            data.UpdateById = entity.InsertById;
            data.UpdateBy = entity.UpdateBy;
            var hasil = await repo.UpdateAsync<TOriginal>(data);
            bool isSaved = repo.ConvertReturnValueToBool(hasil);
            jsonResult = compress.CompressedData(isSaved);
            return Ok(jsonResult);
        }
    }
}
