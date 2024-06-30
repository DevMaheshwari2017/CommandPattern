using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Command.Main;
using Command.Actions;

namespace Command.Player
{
    public class MeditateCommand : UnitCommand
    {
        private bool willHitTarget;
        MeditateCommand(CommandData commandData) 
        {
            this.commandData = commandData;
            willHitTarget = WillHitTraget();
        }
        public override void Execute() => GameService.Instance.ActionService.GetActionByType(CommandType.Attack).PerformAction(actorUnit, targetUnit, willHitTarget);

        public override bool WillHitTraget() => true;
    }
}
