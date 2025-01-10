using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Order;
using SSJD.ViewModel.StoreViewModel.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Order
{
    public interface IOrderService : IBaseService<OrderRequestModel, OrderViewModel>
    {
        Task<PagedResult<OrderViewModel>> GetOrderPaging (OrderPagingRequest request);
    }
}
