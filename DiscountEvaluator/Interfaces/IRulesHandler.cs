using DiscountEvaluator.Rules.Rules_Interfaces;

namespace DiscountEvaluator.Interfaces
{
    interface IRulesHandler
    {
        void ApplyRules(IShipment shipment);
    }
}
