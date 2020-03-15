using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.User
{
    public enum DisclaimerType
    {
        TermsOfService = 1,
        PrivacyPolicy = 2
    }

    public class Disclaimer
    {
        [Key]
        public int Id { get; set; }

        public int Type { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Version { get; set; }

        public bool IsUsed { get; set; }

        public bool IsActive { get; set; }

        public DateTime? PublishedAt { get; set; }

        #region MetaData

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        #endregion
    }
}
