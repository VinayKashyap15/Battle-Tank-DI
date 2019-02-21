using UnityEngine;
using System.Collections;

namespace Interfaces
{
    public interface IPlayerController
    {
        void Move(int vertical);
        void Rotate(int pitch);
    }
}