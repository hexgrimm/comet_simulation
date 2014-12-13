using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class ToDefaultReturnerComponent : MonoBehaviour
    {
        public void Awake()
        {
            GlobalEventListener.Instance.ReturnObjectsToDefaultAction += SetDefaultPosRot;
        }
        public void SetDefaultPosRot()
        {

        }

        public void OnDestroy()
        {
            GlobalEventListener.Instance.ReturnObjectsToDefaultAction -= SetDefaultPosRot;
        }
    }
}
