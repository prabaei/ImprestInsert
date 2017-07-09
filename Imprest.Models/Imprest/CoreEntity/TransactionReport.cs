namespace Imprest.Models.Imprest.CoreEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionReport")]
    public partial class TransactionReport
    {
        [Key]
        [StringLength(16)]
        public string TransactionNo { get; set; }

        public decimal? Amount { get; set; }

        public bool? credit { get; set; }

        [StringLength(20)]
        public string voucherType { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UserId { get; set; }

        public bool? BrsDone { get; set; }

        [StringLength(15)]
        public string ChequeNo { get; set; }

        public DateTime? ChequeDate { get; set; }

        [StringLength(250)]
        public string Narration { get; set; }

        [StringLength(22)]
        public string ProjectNo { get; set; }

        public int? ProjectType { get; set; }

        [StringLength(50)]
        public string SupplierName { get; set; }

        public DateTime? VoucherDate { get; set; }

        [StringLength(12)]
        public string VoucherNo { get; set; }

        [StringLength(13)]
        public string AccountNo { get; set; }
    }
}
