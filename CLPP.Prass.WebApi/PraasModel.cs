
using System.ComponentModel.DataAnnotations.Schema;

namespace CLPP.Praas.WebApi;


public class Promotion
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int PromotionId { get; set; }
    public string PromotionOccasion { get; set; }
    public System.DateTime ValidFrom { get; set; }
    public System.DateTime ValidTill { get; set; }
    public int CustomerId { get; set; }

    public string Description { get; set; }
}

public class Coupon
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CouponId { get; set; }

    public string CouponCode { get; set; }
    public int PromotionId { get; set; }
    public bool IsSerializable { get; set; }

    public bool IsRedeemed { get; set; }
    public int MinBilling { get; set; }
    public Nullable<System.DateTime> Expiry { get; set; }
}