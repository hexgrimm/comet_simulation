using System;
using Rosetta.Global;
using UnityEngine;
using System.Collections;

public class GlobalInputController : MonoBehaviour, IInputController
{
    public static IInputController Instance { get; private set; }

    private Action<string> OnpressedKey = s => { }; 
    private void Awake()
    {
        Instance = this;
        OnpressedKey += Log;
    }

    private void OnDestroy()
    {
        OnpressedKey -= Log;
    }

    private void Log(string text)
    {
        Debug.Log(text);
    }
    public void RegisterOnPressedBUttonEvent(Action<string> pressedKey)
    {
        OnpressedKey += pressedKey;
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.Z))
                OnpressedKey("1");

            if (Input.GetKeyDown(KeyCode.X))
                OnpressedKey("2");

            if (Input.GetKeyDown(KeyCode.C))
                OnpressedKey("3");

            if (Input.GetKeyDown(KeyCode.V))
                OnpressedKey("4");

            if (Input.GetKeyDown(KeyCode.B))
                OnpressedKey("5");

            if (Input.GetKeyDown(KeyCode.N))
                OnpressedKey("6");

            if (Input.GetKeyDown(KeyCode.Space))
                OnpressedKey("space");
        }
    }

}
