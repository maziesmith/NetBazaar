//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetBazaar.Dalc.Dtos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TranslationValue
    {
        public long Id { get; set; }
        public long TranslationId { get; set; }
        public string Language { get; set; }
        public string Value { get; set; }
    
        public virtual Translation Translation { get; set; }
    }
}
