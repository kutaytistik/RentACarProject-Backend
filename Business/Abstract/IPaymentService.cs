﻿using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IResult MakePayment(Payment amount);
    }
}
