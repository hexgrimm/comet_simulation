using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.StateMachine
{
    class EarthComponent : ToDefaultReturnerComponent
    {

        public Vector3 defaultEarPos1;
        public Vector3 defaultEarRotation1;

        public static EarthComponent Instance;

        private void Awake()
        {
            Instance = this;
        }
        public override void SetDefaultPosRot()
        {
            
        }
    }
}
