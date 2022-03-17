using DarkSalo.Services.Input;
using UnityEngine;

namespace DarkSalo.Infrastructure
{
    public class BootstrapState: IState
    {
        private const string Initial = "Initial";
        private static IInputService inputService;
        
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;

        public BootstrapState(GameStateMachine stateMachine, SceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            RegisterServices();
            _sceneLoader.Load(Initial, onLoaded: EnterLoadLevel);
        }

        private void EnterLoadLevel()
        {
            
        }

        private void RegisterServices()
        {
            GameHandler.InputService = RegisterInputService();
        }

        public void Exit()
        {
        }


        private static IInputService RegisterInputService()
        {
            if (Application.isEditor)
                inputService  = new StandaloneInputService();
            else
            {
                inputService = new MobileInputService();
            }

            return inputService;
        }
        
    }
}