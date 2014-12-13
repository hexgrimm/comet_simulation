using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.StateMachine.States
{
    public class WakeUp : IState
    {
        private bool isPaused = false;
        string IState.KeyInvoking
        {
            get { return "4"; }
        }

        void IState.Init()
        {
            GlobalEventListener.Instance.ReturnToDefaultState();
            ///TODO поставить камеру
            /// 
            /// поставить розетту
            /// запустить движение розетты
            /// включить видео на экране

        }

        void IState.Pause()
        {
            if (isPaused)
            {
                isPaused = false;
                //Запустить счетчик видео на экране
                ///приостановить счетчик убирания 
            }
            else
            {
                isPaused = true;
                //Приостановить видео на экране
                ///приостановить счетчик убирания 

            }
        }

        void IState.Hide()
        {
            VideoScreenComponent.Instance.Show();
            VideoScreenComponent.Instance.StopVideo();
        }
    }
}
