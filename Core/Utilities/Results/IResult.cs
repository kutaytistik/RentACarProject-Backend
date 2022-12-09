using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //işlem sonucu + kullanıcı bilgilendirme mesaji
    //get okuyabilmek için set yazmak için
    //peki nasıl set edeceğiz constructor ile yapacağız
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
