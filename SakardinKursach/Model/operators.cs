//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SakardinKursach.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class operators
    {
        public operators()
        {
            this.actions_log = new HashSet<actions_log>();
            this.emergency_calls = new HashSet<emergency_calls>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<actions_log> actions_log { get; set; }
        public virtual ICollection<emergency_calls> emergency_calls { get; set; }
    }
}
