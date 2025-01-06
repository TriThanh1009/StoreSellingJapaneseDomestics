using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.OrderDetail
{
    public interface IOrderDetailService
    {
        Task<PagedResult<OrderDetailViewModel>> GetOrderDetailPaging(OrderDetailPagingRequest request);
    }
}
