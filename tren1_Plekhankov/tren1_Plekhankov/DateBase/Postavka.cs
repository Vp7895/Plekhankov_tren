//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tren1_Plekhankov.DateBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Postavka
    {
        public int id { get; set; }
        public int id_postavchik { get; set; }
        public int id_materials { get; set; }
    
        public virtual Materials Materials { get; set; }
        public virtual Postavchik Postavchik { get; set; }
    }
}
