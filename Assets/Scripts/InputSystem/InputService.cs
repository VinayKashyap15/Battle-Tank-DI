using UnityEngine;
using Interfaces;
using System.Collections;
using Zenject;

namespace InputSystem
{
    public class InputService : IInputService
    {
        
       
        private IPlayerService playerService;

        public InputService(IPlayerService _playerService)
        {                        
            playerService = _playerService;
            if (playerService != null)
            {
               // Debug.Log("Injected player service scheme");
            }
        }

        public void PerformMovement(int vertical)
        {
            foreach(IPlayerController item in playerService.GetPlayerControllers())
            {
                item.Move(vertical);
            }
        }

        public void PerformRotation(int pitch)
        {
            foreach (IPlayerController item in playerService.GetPlayerControllers())
            {
                item.Rotate(pitch);
            }
        }
    }
}