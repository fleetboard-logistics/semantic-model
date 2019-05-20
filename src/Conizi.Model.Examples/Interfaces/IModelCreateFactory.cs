using System;
using System.Collections.Generic;
using System.Text;

namespace Conizi.Model.Examples.Interfaces
{
    public  interface IModelCreateFactory<out TModel>
    {
        TModel Create();
    }
}
