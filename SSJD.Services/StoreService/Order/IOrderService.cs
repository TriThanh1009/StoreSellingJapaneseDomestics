using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Order
{
    public interface IOrderService
    {
        Task<PagedResult<OrderViewModel>> GetOrderPaging (OrderPagingRequest request);
    }
}
