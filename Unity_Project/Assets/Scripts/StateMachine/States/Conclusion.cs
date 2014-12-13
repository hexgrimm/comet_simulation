using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.StateMachine.States
{
    public class Conclusion : IState
    {
        private bool isPaused = false;
        string IState.KeyInvoking
        {
            get { return "6"; }
        }
        void IState.Init()
        {
            GlobalEventListener.Instance.ReturnToDefaultState();
            ///TODO поставить камеру
            /// поставить планеты
            /// поставить розетту
            /// запустить движение розетты
            /// включить видео на экране
            /// дождаться конца видео и начать показывать разные планеты
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
