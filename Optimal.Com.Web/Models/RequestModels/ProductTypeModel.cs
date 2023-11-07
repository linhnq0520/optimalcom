﻿using Optimal.Com.Web.Framework.Commons;

namespace Optimal.Com.Web.Models.RequestModels
{
    public class ProductTypeModel:BaseModel
    {
        public string TypeCode { get; set; } = string.Empty;
        public string TypeName { get; set; } = string.Empty;
    }
}
