using UnityEngine;
using Zenject;
using Interfaces;

namespace Player
{
    public class PlayerController:IPlayerController
    {
        //[Inject]
        private IPlayerService playerService;
       
        private IPlayerModel playerModel;
        private PlayerView playerView;

        private GameObject playerInstance;

        public PlayerController(IPlayerService _playerService)
        {
            playerService = _playerService;
          

            playerModel = new PlayerModel();
           GameObject playerPrefab=playerService.GetInstance();
            GameObject playerInstance=GameObject.Instantiate(playerPrefab);
            playerView = playerInstance.GetComponent<PlayerView>();
        }


        public void Move(int vertical)
        {
           
            playerView.Move(vertical);
        }
        public void Rotate(int pitch)
        {
           
            playerView.RotatePlayer(pitch);
           
        }
    }
}