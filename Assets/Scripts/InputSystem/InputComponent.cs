using Interfaces;
using System.Collections;
using UnityEngine;
using Zenject;

namespace InputSystem
{
    public class InputComponent : IInputComponent, ITickable
    {
        
        private IInputService inputService;

        private KeyCode moveUpKey;
        private KeyCode moveDownKey;
        private KeyCode rotateLeftKey;
        private KeyCode rotateRightKey;

        public InputComponent(IInputService _inputService,InputScheme _currentInputScheme=null)
        {
            inputService = _inputService;
            if(inputService!=null)
            {
                Debug.Log("input service injected for input component");
            }
            if (_currentInputScheme != null)
            {
                moveUpKey = _currentInputScheme.moveUpKey;
                moveDownKey = _currentInputScheme.moveDownKey;
                rotateLeftKey = _currentInputScheme.rotateLeftKey;
                rotateRightKey = _currentInputScheme.rotateRightKey;
                Debug.Log("scriptable obj recieved");
                Debug.Log("move up key"+ moveUpKey.ToString());
                Debug.Log("move down key"+ moveDownKey.ToString());
                Debug.Log("left key"+ rotateLeftKey.ToString());
                Debug.Log("right  key"+ rotateRightKey.ToString());
                

            }
            else
            {
                Debug.Log("scriptable obj not received");
                moveUpKey = KeyCode.UpArrow;
                moveDownKey = KeyCode.DownArrow;
                rotateLeftKey = KeyCode.LeftArrow;
                rotateRightKey = KeyCode.RightArrow;
            }
        }

        public void Tick()
        {
            Debug.Log("ticking in input component");

            if (Input.GetKey(moveUpKey))
            {               
                inputService.PerformMovement(1);
            }
            if (Input.GetKey(moveDownKey))
            {
                inputService.PerformMovement(-1);
            }
            if (Input.GetKey(rotateLeftKey))
            {
                inputService.PerformRotation(-1);
            }
            if (Input.GetKey(rotateRightKey))
            {
                inputService.PerformRotation(1);
            }
            
           
        }
    }
}