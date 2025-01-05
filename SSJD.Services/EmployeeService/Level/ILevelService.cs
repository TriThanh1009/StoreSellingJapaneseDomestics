using SSJD.ViewModel.EmployeeViewModel.Level;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.GeneralViewModel.PageResultBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.EmployeeService.Level
{
    public interface ILevelService
    {
        Task Create(LevelCreateViewModel request);
        Task Edit(LevelEditViewModel request);
        Task Delete(int ID);
        Task<List<LevelViewModel>> GetAll();
        Task<PagedResult<LevelViewModel>> GetAllPage(LevelPagingRequest paging);
    }
}
