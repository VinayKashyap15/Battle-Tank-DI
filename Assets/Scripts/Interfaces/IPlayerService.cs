using UnityEngine;
using System.Collections.Generic;
using Player;

namespace Interfaces
{
    public interface IPlayerService
    {
        List<IPlayerController> GetPlayerControllers();
        GameObject GetInstance();
    }
}