﻿using EggLink.DanhengServer.Game.Scene.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Command.Cmd
{
    [CommandInfo("scene", "", "")]
    public class CommandScene : ICommand
    {
        [CommandMethod("0 group")]
        public void GetLoadedGroup(CommandArg arg)
        {
            var scene = arg.Target!.Player!.SceneInstance!;
            var loadedGroup = new List<int>();
            foreach (var group in scene.Entities)
            {
                if (!loadedGroup.Contains(group.Value.GroupID))
                {
                    loadedGroup.Add(group.Value.GroupID);
                }
            }
            arg.SendMsg($"Loaded groups: {string.Join(", ", loadedGroup)}");
        }

        [CommandMethod("0 prop")]
        public void GetProp(CommandArg arg)
        {
            var scene = arg.Target!.Player!.SceneInstance!;
            EntityProp? prop = null;
            foreach (var entity in scene.GetEntitiesInGroup<EntityProp>(arg.GetInt(0)))
            {
                if (entity.PropInfo.ID == arg.GetInt(1))
                {
                    prop = entity;
                    break;
                }
            }
            if (prop == null)
            {
                arg.SendMsg("Prop not found");
                return;
            }
            prop.SetState((Enums.PropStateEnum)arg.GetInt(2));
            arg.SendMsg($"Prop: {prop.EntityID} has been set to {(Enums.PropStateEnum)arg.GetInt(2)}");
        }
    }
}
