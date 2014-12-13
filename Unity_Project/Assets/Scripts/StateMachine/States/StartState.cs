using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

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
            MainCameraController.Instance.gameObject.transform.position = MainCameraController.Instance.defaultCamPos1;
            MainCameraController.Instance.gameObject.transform.rotation = Quaternion.Euler(MainCameraController.Instance.defaultCamRotation1);

            MainCameraController.Instance.gameObject.transform.position = EarthComponent.Instance.defaultEarPos1;
            MainCameraController.Instance.gameObject.transform.rotation = Quaternion.Euler(EarthComponent.Instance.defaultEarRotation1);

            
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
