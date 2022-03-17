using UnityEngine;

namespace DarkSalo
{
    public interface IInputService
    {
        Vector2 Axis { get; }

        bool isAttackButtonUp();
    }
}