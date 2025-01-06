using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.UnitShip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.UnitShip
{
    public interface IUnitShipService
    {
        Task<PagedResult<UnitShipViewModel>> GetUnitShipPaging(UnitShipPagingRequest request);
    }
}
