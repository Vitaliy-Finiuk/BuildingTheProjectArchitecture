using DarkSalo.Infrastructure;
using UnityEngine;

namespace DarkSalo.Player
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private float _movementSpeed;
        
        private Camera _camera;
        private IInputService _inputService;
        
        private void Awake()
        {
            _inputService = GameHandler.InputService;
        }

        private void Update()
        {
            var movementVector = Vector3.zero;

            if (_inputService.Axis.sqrMagnitude > Constants.Epsilon)
            {
                movementVector = Camera.main.transform.TransformDirection(_inputService.Axis);
                movementVector.y = 0;
                movementVector.Normalize();
                
                transform.forward = movementVector;
            }

            movementVector += Physics.gravity;
            
            _characterController.Move(_movementSpeed * movementVector * Time.deltaTime);
        }
    }    
}

