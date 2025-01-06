using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.UnitShip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.UnitShip
{
    public class UnitShipService : IBaseService<SSJD.Entities.StoreEntity.UnitShip,UnitShipViewModel>,IUnitShipService
    {
        public Task Create(Entities.StoreEntity.UnitShip entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Entities.StoreEntity.UnitShip entity)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Entities.StoreEntity.UnitShip entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<UnitShipViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UnitShipViewModel> GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<UnitShipViewModel>> GetUnitShipPaging(UnitShipPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
