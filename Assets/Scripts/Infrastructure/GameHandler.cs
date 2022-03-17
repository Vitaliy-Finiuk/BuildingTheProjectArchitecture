using UnityEngine;

namespace DarkSalo.Infrastructure
{
    public class GameHandler
    {
        public static IInputService InputService;
        public GameStateMachine StateMachine;

        public GameHandler(ICoroutineRunner coroutineRunner)
        {
            StateMachine = new GameStateMachine(new SceneLoader(coroutineRunner));
        }

    }
}