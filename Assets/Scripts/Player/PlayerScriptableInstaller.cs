using System.Collections;
using UnityEngine;
using Zenject;

namespace Player
{
    [CreateAssetMenu(fileName = "Player Prefab", menuName = "Custom Objects/Player", order = 0)]
    public class PlayerScriptableInstaller : ScriptableObjectInstaller
    {
       public GameObject playerPrefab;

    }
}