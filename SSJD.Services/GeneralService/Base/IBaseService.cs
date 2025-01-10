﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.GeneralService.Base
{
    public interface IBaseService<TRequestModel, TViewModel> where TRequestModel : class
    {
        Task Create(TRequestModel request);
        Task Edit(TRequestModel request);
        Task Delete(string id);
        Task<TRequestModel?> GetByID(string id);
        Task<List<TRequestModel>> GetListByID(string id);
        Task<List<TViewModel>> GetAll();
    }
}
