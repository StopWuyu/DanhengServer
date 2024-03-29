﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Database.Avatar;
using EggLink.DanhengServer.Database.Inventory;
using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Send.Player
{
    public class PacketPlayerSyncScNotify : BasePacket
    {
        public PacketPlayerSyncScNotify(ItemData item) : base(CmdIds.PlayerSyncScNotify)
        {
            AddItemToProto(item, out var proto);
            SetData(proto);
        }

        public PacketPlayerSyncScNotify(AvatarInfo avatar) : base(CmdIds.PlayerSyncScNotify)
        {
            var proto = new PlayerSyncScNotify
            {
                AvatarSync = new()
            };
            proto.AvatarSync.AvatarList.Add(avatar.ToProto());

            if (avatar.HeroId > 0)
            {
                proto.BasicTypeInfoList.Add(avatar.ToHeroProto());
            }

            SetData(proto);
        }
        
        public PacketPlayerSyncScNotify(AvatarInfo avatar, ItemData item) : base(CmdIds.PlayerSyncScNotify)
        {
            AddItemToProto(item, out var proto);
            proto.AvatarSync = new();
            proto.AvatarSync.AvatarList.Add(avatar.ToProto());

            if (avatar.HeroId > 0)
            {
                proto.BasicTypeInfoList.Add(avatar.ToHeroProto());
            }

            SetData(proto);
        }

        public PacketPlayerSyncScNotify(MissionSync mission) : base(CmdIds.PlayerSyncScNotify)
        {
            var proto = new PlayerSyncScNotify
            {
                MissionSync = mission,
            };

            SetData(proto);
        }

        public PacketPlayerSyncScNotify(PlayerBasicInfo info) : base(CmdIds.PlayerSyncScNotify)
        {
            var proto = new PlayerSyncScNotify()
            {
                BasicInfo = info,
            };

            SetData(proto);
        }

        private void AddItemToProto(ItemData item, out PlayerSyncScNotify notify)
        {
            notify = new PlayerSyncScNotify();
            GameData.ItemConfigData.TryGetValue(item.ItemId, out var itemConfig);
            if (itemConfig == null) return;
            switch (itemConfig.ItemMainType)
            {
                case ItemMainTypeEnum.Equipment:
                    if (item.Count > 0)
                    {
                        notify.EquipmentList.Add(item.ToEquipmentProto());
                    } else
                    {
                        notify.RemoveEquipmentTidList.Add((uint)item.UniqueId);
                    }
                    break;
                case ItemMainTypeEnum.Relic:
                    if (item.Count > 0)
                    {
                        notify.RelicList.Add(item.ToRelicProto());
                    }
                    else
                    {
                        notify.RemoveRelicTidList.Add((uint)item.UniqueId);
                    }
                    break;
                case ItemMainTypeEnum.Material:
                    notify.MaterialList.Add(item.ToMaterialProto());
                    break;
            }
        }
    }
}
