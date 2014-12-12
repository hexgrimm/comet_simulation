using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.StateMachine.States
{
    public class StartState: IState
    {
        string IState.KeyInvoking
        {
            get { return "1"; }
        }

        void IState.Init()
        {
            GlobalEventListener.Instance.ReturnToDefaultState();
        }

        void IState.Pause()
        {
            throw new NotImplementedException();
        }

        void IState.Hide()
        {
            throw new NotImplementedException();
        }
    }
}
