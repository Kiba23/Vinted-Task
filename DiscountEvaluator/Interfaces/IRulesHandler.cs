using DiscountEvaluator.Rules.Rules_Interfaces;

namespace DiscountEvaluator.Interfaces
{
    interface IRulesHandler
    {
        ILowestPackagePrice LowestPackagePrice { get; set; }
        IThirdFreeShipment ThirdFreeShipment { get; set; }
        IDiscountExceed DiscountExceed { get; set; }
        void ApplyRules(IShipment shipment);
    }
}
