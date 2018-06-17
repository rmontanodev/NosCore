﻿using NosCore.Core.Serializing;

namespace NosCore.Packets.ServerPackets
{
    [PacketHeader("in_character_subpacket")]
    public class InCharacterSubPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public byte Authority { get; set; }

        [PacketIndex(1)]
        public byte Gender { get; set; }

        [PacketIndex(2)]
        public byte HairStyle { get; set; }

        [PacketIndex(3)]
        public byte HairColor { get; set; }

        [PacketIndex(4)]
        public byte Class { get; set; }

        [PacketIndex(5)]
        public InEquipmentSubPacket Equipment { get; set; }

        [PacketIndex(6, RemoveSeparator = true)]
        public InAliveSubPacket InAliveSubPacket { get; set; }

        [PacketIndex(7)]
        public bool IsSitting { get; set; }

        [PacketIndex(8)]
        public int? GroupId { get; set; }

        #endregion
    }
}