using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.StateMachine.States
{
    interface IState
    {
        string KeyInvoking { get; }
        void Init();
        void Pause();
        void Hide();
    }
}
