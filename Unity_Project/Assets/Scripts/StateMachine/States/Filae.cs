using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.StateMachine.States
{
    public class Filae : IState
    {
        private bool isPaused = false;
        string IState.KeyInvoking
        {
            get { return "5"; }
        }
        void IState.Init()
        {
            GlobalEventListener.Instance.ReturnToDefaultState();
            ///TODO поставить камеру
            /// поставить комету
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
            VideoScreenComponent.Instance.StopVideo();
            VideoScreenComponent.Instance.Show();
        }
    }
}
