using Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerService : IPlayerService
    {
        private List<IPlayerController> playerControllers = new List<IPlayerController>();
        private int noOfPlayers;
        private GameObject playerPrefab;

        public PlayerService(int _noOfPlayers, GameObject _playerPrefab)
        {
            //playerControllers = _playerControllers;
            noOfPlayers = _noOfPlayers;
            playerPrefab = _playerPrefab;
            SpawnPlayers();
        }

        private void SpawnPlayers()
        {
            for(int i=0;i<noOfPlayers;i++)
            {
                IPlayerController _controller = new PlayerController(this);
                playerControllers.Add(_controller);

            }
        }

        public List<IPlayerController> GetPlayerControllers()
        {
            return playerControllers;
        }

        public GameObject GetInstance()
        {
            return playerPrefab;
        }
    }
}