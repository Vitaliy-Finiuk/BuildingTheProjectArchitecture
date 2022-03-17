using DarkSalo.Services.Input;
using UnityEngine;

namespace DarkSalo.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
    {
        private GameHandler _gameHandler;

        private void Awake()
        {
            _gameHandler = new GameHandler(this);
            _gameHandler.StateMachine.Enter<BootstrapState>();
            
            DontDestroyOnLoad(this);
        }
    }
}