using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinImpactMovementSystem
{
    public class PlayerHardStoppingState : PlayerStoppingState
    {
        public PlayerHardStoppingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        #region IState Methods
        public override void Enter()
        {
            base.Enter();

            StartAnimation(stateMachine.Player.AnimationdData.HardStopParameterHash);

            stateMachine.ReusableData.MovementDecelerationForce = movementData.StopData.HardDecelerationForce;

            stateMachine.ReusableData.CurrentJumpForce = airborneData.JumpData.StrongForce;
        }
        public override void Exit()
        {
            base.Exit();

            StopAnimation(stateMachine.Player.AnimationdData.HardStopParameterHash);
        }
        #endregion

        #region Reusable Methods

        protected override void OnMove()
        {
            if (stateMachine.ReusableData.ShouldWalk)
            {
                return;
            }

            stateMachine.ChangeState(stateMachine.RunningState);
        }

        #endregion
    }
}
