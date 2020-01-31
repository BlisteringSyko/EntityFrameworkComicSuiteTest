using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkComicSuiteTest
{

    [Table("Customer")]
    public partial class Customer
    {
        [StringLength(20)]
        public string AccountNumber { get; set; }

        public int AccountTypeID { get; set; } // RMH

        [StringLength(50)]
        public string Address2 { get; set; }

        public bool AssessFinanceCharges { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        public DateTime? CustomDate1 { get; set; }

        public DateTime? CustomDate2 { get; set; }

        public DateTime? CustomDate3 { get; set; }

        public DateTime? CustomDate4 { get; set; }

        public DateTime? CustomDate5 { get; set; }

        public double CustomNumber1 { get; set; }

        public double CustomNumber2 { get; set; }

        public double CustomNumber3 { get; set; }

        public double CustomNumber4 { get; set; }

        public double CustomNumber5 { get; set; }

        [StringLength(30)]
        public string CustomText1 { get; set; }

        [StringLength(30)]
        public string CustomText2 { get; set; }

        [StringLength(30)]
        public string CustomText3 { get; set; }

        [StringLength(30)]
        public string CustomText4 { get; set; }

        [StringLength(30)]
        public string CustomText5 { get; set; }

        public bool GlobalCustomer { get; set; } // RMH

        public int HQID { get; set; } // RMH

        public DateTime? LastStartingDate { get; set; } // RMH

        public DateTime? LastClosingDate { get; set; } // RMH

        public DateTime LastUpdated { get; set; }

        public bool LimitPurchase { get; set; } // RMH

        [Column(TypeName = "money")]
        public decimal LastClosingBalance { get; set; } // RMH

        public int PrimaryShipToID { get; set; } // RMH

        [StringLength(20)]
        public string State { get; set; }

        public int StoreID { get; set; }

        [Key]
        public int ID { get; set; }

        public bool LayawayCustomer { get; set; } // RMH

        public bool Employee { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        //[Required]
        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(15)]
        public string Zip { get; set; }

        [Column(TypeName = "money")]
        public decimal AccountBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal CreditLimit { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalSales { get; set; } // RMH

        public DateTime AccountOpened { get; set; }

        public DateTime LastVisit { get; set; }

        public int TotalVisits { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalSavings { get; set; } // RMH

        public float CurrentDiscount { get; set; } // RMH

        public short PriceLevel { get; set; }

        public bool TaxExempt { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        [StringLength(255)]
        public string EmailAddress { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] DBTimeStamp { get; set; } // RMH

        [StringLength(20)]
        public string TaxNumber { get; set; } // RMH

        [StringLength(50)]
        public string PictureName { get; set; } // RMH

        public int DefaultShippingServiceID { get; set; } // RMH

        [StringLength(30)]
        public string PhoneNumber { get; set; }

        //[Required]
        [StringLength(30)]
        public string FaxNumber { get; set; }

        public int CashierID { get; set; } // RMH

        public int SalesRepID { get; set; } // RMH

        [Column(TypeName = "money")]
        public decimal Vouchers { get; set; } // RMH


        public virtual ICollection<SpecialOrder> SpecialOrders { get; set; }
        public virtual ICollection<CustSeries> CustSeries { get; set; }
        public virtual ICollection<CustSeriesPosting> CustSeriesPosted { get; set; }
        public virtual ICollection<SpecialOrderHistory> SpecialOrdersHistory { get; set; }
    }
}
