using System;

namespace Rosetta.Global
{
    public interface IInputController
    {
        void RegisterOnPressedBUttonEvent(Action<string> pressedKey);
    }
}