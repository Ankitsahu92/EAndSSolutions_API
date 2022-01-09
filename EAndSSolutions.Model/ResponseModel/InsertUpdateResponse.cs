using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Model.ResponseModel
{
    public class InsertUpdateResponse<T> where T : class
    {
        public bool Success { get; set; } = false;
        public string? Message { get; set; } = "Something went wrong please try again !!!";

        public T? Data { get; set; }

    }
}
