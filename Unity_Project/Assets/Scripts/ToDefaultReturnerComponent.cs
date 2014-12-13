using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public class ToDefaultReturnerComponent : MonoBehaviour
    {
        public void Awake()
        {
            GlobalEventListener.Instance.ReturnObjectsToDefaultAction += SetDefaultPosRot;
        }
        public virtual void SetDefaultPosRot()
        {

        }

        public virtual void OnDestroy()
        {
            GlobalEventListener.Instance.ReturnObjectsToDefaultAction -= SetDefaultPosRot;
        }
    }
}
