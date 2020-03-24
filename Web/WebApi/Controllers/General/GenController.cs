using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenHelper;
using GenHelper.Cache;
using GenHelper.Compress;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace WebApi.Controllers.General
{
    public class GenController : BasicController
    {
        private readonly CompressObject compress = CompressObject.GetInstance;
        private readonly MemoryCacher cacher = MemoryCacher.GetInstance;

        [HttpPost]
        [Route("PostUploadChunk")]
        public async Task PostUploadChunk([FromBody] object obj)
        {
            bool IsChunkData = compress.IsChunkData(obj.ToString());
            ChunkData dataChunk = null;
            if (IsChunkData)
            {
                dataChunk = Newtonsoft.Json.JsonConvert.DeserializeObject<ChunkData>(obj.ToString());
                var RequestHeaders = this.Request.Headers;
                StringValues ChunkKeyCurrent = "";
                if (RequestHeaders.Keys.Contains(compress.ChunkResponseUploadHeader))
                {
                    RequestHeaders.TryGetValue(compress.ChunkResponseUploadHeader, out ChunkKeyCurrent);
                }
                if (!string.IsNullOrEmpty(ChunkKeyCurrent))
                {
                    string[] checkChunk = ChunkKeyCurrent.ToString().Split("_");
                    string key1 = string.Empty;
                    string key2 = string.Empty;
                    if (checkChunk.Count() > 1)
                    {
                        await CompressObject.GetInstance.ChunkDataUploadSvr(dataChunk);
                        MemoryCacher.GetInstance.AddMinutes(ChunkKeyCurrent.ToString(), dataChunk, dataChunk.ChunkTimeMinutes);
                    }
                }
            }
        }


        public object GetDownloadChunk(string paramFields)
        {
            object result = null;
            var RequestHeaders = this.Request.Headers;
            StringValues ChunkKeyCurrent = "";
            if (RequestHeaders.Keys.Contains(compress.ChunkRequestDownloadHeader))
            {
                RequestHeaders.TryGetValue(compress.ChunkRequestDownloadHeader, out ChunkKeyCurrent);
            }
            if (!string.IsNullOrEmpty(ChunkKeyCurrent))
            {
                result = MemoryCacher.GetInstance.GetValue(ChunkKeyCurrent);
                if (result != null)
                    result= (ChunkData)result;
            }
            return result;
        }
    }
}