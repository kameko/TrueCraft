using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Blocks
{
    public class ClayBlock : BlockProvider
    {
        public static readonly byte BlockID = 0x52;
        
        public override byte ID { get { return 0x52; } }
        
        public override double BlastResistance { get { return 3; } }

        public override double Hardness { get { return 0.6; } }

        public override byte Luminance { get { return 0; } }
        
        public override string DisplayName { get { return "Clay"; } }

        public override Tuple<int, int> GetTextureMap(byte metadata)
        {
            return new Tuple<int, int>(8, 4);
        }
    }
}