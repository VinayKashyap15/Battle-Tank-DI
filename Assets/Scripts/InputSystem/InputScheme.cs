using UnityEngine;
using Zenject;
using Interfaces;
using System.Collections;

namespace InputSystem
{
    [CreateAssetMenu(fileName = "NewInputScheme", menuName = "Custom Objects/Input/Keyboard Input Scheme", order = 0)]
    public class InputScheme : ScriptableObject
    {
        public KeyCode moveUpKey;
        public KeyCode moveDownKey;
        public KeyCode rotateRightKey;
        public KeyCode rotateLeftKey;

        


    }
}