using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.GeneralService.Base
{
    public interface IBaseService<T,TViewModel> where T : class
    {
        Task Create(T entity);
        Task Edit(T entity);
        Task Delete(T entity);
        Task<TViewModel> GetByID(string id);
        Task<List<TViewModel>> GetAll();
    }
}
