using Business.Abstract;
using Core.Aspects.Autofac.Transaction;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class PaymentManager : IPaymentService
    {

        public IResult PayWithCreditCard()
        {
            var rd = new Random().Next(2);
            if (rd == 0) return new ErrorResult("Ödeme Yapılamadı");

            return new SuccessResult("Ödeme Yapıldı");
        }
    }
}
