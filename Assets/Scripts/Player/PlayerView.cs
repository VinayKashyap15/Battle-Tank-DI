using System.Collections;
using System.Collections.Generic;
using Zenject;
using Interfaces;
using UnityEngine;

namespace Player
{
    public class PlayerView :MonoBehaviour,IPlayerView
    {
        public void Move(int z)
        {
            Debug.Log("move player");
            transform.Translate(new Vector3(0, 0, z *5f * Time.deltaTime));
        }

        public void RotatePlayer(float pitch)
        {
            Debug.Log("rotate player");
            transform.Rotate(new Vector3(0, pitch, 0));
        }
    }
}