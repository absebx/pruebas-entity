//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaEntity_2015
{
    using System;
    using System.Collections.Generic;
    
    public partial class TICKET
    {
        public TICKET()
        {
            this.REL_TICKET_HAS_STATUS = new HashSet<REL_TICKET_HAS_STATUS>();
        }
    
        public long id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public System.DateTime date { get; set; }
        public int estimated_time { get; set; }
        public long board_id { get; set; }
    
        public virtual BOARD BOARD { get; set; }
        public virtual ICollection<REL_TICKET_HAS_STATUS> REL_TICKET_HAS_STATUS { get; set; }
    }
}