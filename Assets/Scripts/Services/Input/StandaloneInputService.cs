using DarkSalo.Services.Input;
using UnityEngine;

namespace DarkSalo
{
    public class StandaloneInputService : InputService
    {
        private InputService _inputServiceImplementation;
        public override Vector2 Axis
        {
            get
            {
                var axis = SimpleInputAxis();

                if (axis == Vector2.zero)
                {
                    axis = UnityAxis();
                }
                
                return axis;
            }
        }

        private static Vector2 UnityAxis()
        {
            return new Vector2(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));
        }
    }
}