﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        //CRUD : CREATE + READ + UPDATE + DELETE
        IDataResult<List<Customer>> GetAll();
        

        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);

        IDataResult<List<CustomerDetailDto>> GetCustomerDetail();
    }
}
