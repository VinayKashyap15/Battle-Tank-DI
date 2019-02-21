using UnityEngine;
using Zenject;
using System.Collections;

namespace InputSystem
{
    [CreateAssetMenu(fileName = "InputScriptableInstaller", menuName = "Custom Objects/InputSchemeInstallers/InputScriptableInstaller")]

    public class InputSchemeInstaller : ScriptableObjectInstaller
    {
        public InputScheme _obj;
        public override void InstallBindings()
        {
            Container.BindInstance(_obj);
        }
    }
}