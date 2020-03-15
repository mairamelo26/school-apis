using Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.User
{
    public enum CompanyType
    {
        Trial = 1,
        Premium = 2
    }

    public class Company : BaseModel
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }
                
        /// <summary>
        /// NIF in the EU
        /// </summary>
        public string Tin { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        
        public string Address { get; set; }

        public string Town { get; set; }

        public string PostalCode { get; set; }

        public string LogoImage { get; set; }

        public string Filename { get; set; }

        public int CompanyType { get; set; }

        public DateTime? ContractStartDate { get; set; }

        public DateTime? ContractExpireDate { get; set; }
        
        public bool? IsActive { get; set; }

        #region MetaData

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        #endregion

        #region ForeignKeys

        public int? AssociationId { get; set; }

        [ForeignKey("AssociationId")]
        public virtual Association Association { get; set; }

        #endregion
    }
}
