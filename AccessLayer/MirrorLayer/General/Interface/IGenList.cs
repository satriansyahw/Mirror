using EFHelper.Filtering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MirrorLayer.General.Interface
{
    public interface IGenList
    {
        object ListData(List<SearchField> lsf);
        Task<object> ListDataAsync(List<SearchField> lsf);
    }
}