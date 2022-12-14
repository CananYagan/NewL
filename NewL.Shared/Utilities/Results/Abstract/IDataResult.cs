using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T>:IResult
    {
        public T Data { get; }  //new Dataresult<Category>(ResultStatus.Success,category)
                                //new Dataresult<<IList<Category>>(ResultStatus.Success,categoryList) -- out T bunun için kullanılır.
    }
}
