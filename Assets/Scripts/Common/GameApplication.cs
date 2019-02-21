using System.Collections;
using System.Collections.Generic;
using Zenject;
using Player;
using Interfaces;
using InputSystem;
using UnityEngine;

namespace Common
{
    public class GameApplication : MonoInstaller
    {
        public GameObject playerPrefab;

        public override void InstallBindings()
        {
            base.InstallBindings();
            Container.Bind<IPlayerService>().To<PlayerService>().FromInstance(new PlayerService(1,playerPrefab)).AsSingle().NonLazy();
            Container.Bind<IInputService>().To<InputService>().AsSingle().NonLazy();             
            Container.Bind<IInputComponent>().To<InputComponent>().AsTransient().NonLazy();
            Container.Bind<ITickable>().To<InputComponent>().AsTransient().Lazy();
           
           
            
            
        }
    }
}