﻿using Microsoft.Xna.Framework;

namespace LF2datConverter.dat.Convenient
{
    class NormalHit: Interaction, IForceElement, IHittableInteraction, IDamagingElement
        , IFallPointDealerInteraction, IZVerticalInteraction, IDefendableInteraction
    {
        public int ARest;
        public int Effect;
        public Vector3 VelocityDelta { get; set; }
        public int VRest { get; set; }
        public int Injury { get; set; }
        public int FallPoints { get; set; }
        public int ZWidth { get; set; }
        public int BDefend { get; set; }
    }
}
