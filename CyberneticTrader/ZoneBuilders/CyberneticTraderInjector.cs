using System;
using XRL.World;
using XRL.World.ZoneBuilders;

namespace CyberneticTraderMod
{
    [Serializable]
    public class CyberneticTraderInjector : ZoneBuilder
    {
        public override bool BuildZone(Zone Z)
        {
            if (!Z.ZoneID.Contains("sixdaystilt"))
                return true;

            // Avoid duplicate placement
            if (Z.FindObject(o => o.Blueprint == "CyberneticWedgeTraderNPC") != null)
                return true;

            GameObject trader = GameObjectFactory.Factory.CreateObject("CyberneticWedgeTraderNPC");
            Cell cell = Z.GetCell(65, 17) ?? Z.GetRandomEmptyCell();
            cell?.AddObject(trader);
            return true;
        }
    }
}
