using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.StateMachine.States;

namespace Assets.Scripts.StateMachine
{
    public static class StateMachine
    {
        static StateMachine()
        {
            GlobalInputController.Instance.RegisterOnPressedBUttonEvent(OnPressedKeys);
        }

        private static void OnPressedKeys(string key)
        {
            
        }
    }
}
