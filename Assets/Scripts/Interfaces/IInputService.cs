using UnityEngine;
using System.Collections;

namespace Interfaces
{
    public interface IInputService
    {
        void PerformMovement( int vertical);
        void PerformRotation( int pitch);

    }
}