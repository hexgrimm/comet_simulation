using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class GlobalEventListener
    {
        public event Action ReturnObjectsToDefaultAction = () => { };

        private static GlobalEventListener instance;
        public static GlobalEventListener Instance
        {
            get
            {
                if (instance == null)
                    instance = new GlobalEventListener();

                return instance;
            }
        }

        public void ReturnToDefaultState()
        {
            ReturnObjectsToDefaultAction();
        }
    }
}
