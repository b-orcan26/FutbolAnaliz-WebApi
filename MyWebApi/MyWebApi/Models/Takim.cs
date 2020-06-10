namespace MyWebApi.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Takim")]
    public partial class Takim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Takim()
        {
            Mac = new HashSet<Mac>();
            Mac1 = new HashSet<Mac>();
        }

        [Key]
        public int takim_id { get; set; }

        [Required]
        public string takim_ad { get; set; }

        [Column(TypeName = "image")]
        public byte[] takim_logo { get; set; }

        public int? lig_id { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Lig Lig { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mac> Mac { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mac> Mac1 { get; set; }
    }
}
