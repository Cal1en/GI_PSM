using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinImpactMovementSystem
{
    public class PlayerMovingState : PlayerGroundedState
    {
        public PlayerMovingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        #region IState Methods

        public override void Enter()
        {
            base.Enter();

            StartAnimation(stateMachine.Player.AnimationdData.MovingParameterHash);
        }
        public override void Exit()
        {
            base.Exit();

            StopAnimation(stateMachine.Player.AnimationdData.MovingParameterHash);
        }
        #endregion
    }
}
