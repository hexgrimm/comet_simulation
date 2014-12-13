using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.StateMachine.States;

namespace Assets.Scripts.StateMachine
{
    public static class StateMachine
    {
        private static IState currentState;
        private static IState[] statesArray = new IState[]
        {
            new StartState(), new WakeUp(), new SleepRosetta(), new ManeureState(), new Filae(), new Conclusion()
        };
        static StateMachine()
        {
            GlobalInputController.Instance.RegisterOnPressedBUttonEvent(OnPressedKeys);
        }

        private static void OnPressedKeys(string key)
        {
            foreach (var state in statesArray)
            {
                if (state.KeyInvoking == key)
                {
                    if (currentState != null)
                    {
                        currentState.Hide();
                        currentState = state;
                    }
                    state.Init();
                }
            }
        }
    }
}
