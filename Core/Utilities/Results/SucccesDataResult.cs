using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SucccesDataResult<T> : DataResult<T>
    {
        public SucccesDataResult(T data , string message ):base(data ,true , message )
        {
            
        }
        public SucccesDataResult(T data):base(data,true) 
        {
            
        }
        public SucccesDataResult(string message ):base(default,true ,message ) 
        {
            
        }

        public SucccesDataResult():base (default,true)
        {
            
        }
    }
}
