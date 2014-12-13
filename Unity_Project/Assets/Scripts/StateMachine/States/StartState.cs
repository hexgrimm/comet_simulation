﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.StateMachine.States
{
    public class StartState: IState
    {
        private bool isPaused = false;
        string IState.KeyInvoking
        {
            get { return "1"; }
        }

        void IState.Init()
        {
            GlobalEventListener.Instance.ReturnToDefaultState();
            ///TODO поставить камеру
            /// поставить землю
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
            VideoScreenComponent.Instance.StopVideo();
            VideoScreenComponent.Instance.Show();
        }
    }
}
