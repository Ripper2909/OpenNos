﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;

namespace OpenNos.GameObject
{
    [PacketHeader("$Speed")]
    public class SpeedPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public byte Value { get; set; }

        #endregion
    }
}