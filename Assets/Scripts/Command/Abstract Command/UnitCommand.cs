using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command.Player {
    public abstract class UnitCommand : ICommand
    {
        public int ActorPlayerID;
        public int TargetPlayerID;
        public int ActorUnitID;
        public int TargetUnitID;

        protected UnitController actorUnit;
        protected UnitController targetUnit;
        public abstract void Execute();

        public abstract bool WillHitTraget();
    }
}
