using System;
using System.Collections.Generic;
using Core.Common.GameStateMachine.States;
using Core.Common.GameStateMachine.States.Boot;
using Core.Common.GameStateMachine.States.LevelCreator;
using Core.Common.GameStateMachine.States.LevelState;
using Zenject;

namespace Core.Common.GameStateMachine
{
    public class GameStateMachine : IStateMachine<BaseState>
    {
        private DiContainer _container;
        private Dictionary<Type, BaseState> _stateMap;
        private KeyValuePair<Type, BaseState> _currentState;

        [Inject]
        public GameStateMachine(DiContainer diContainer)
        {
            _container =  diContainer;
            UnityEngine.Debug.Log("GameStateMachine Created");
        }

        public void Boot()
        {
            UnityEngine.Debug.Log("GameStateMachine Boot");
            _currentState = new KeyValuePair<Type, BaseState>(null, null);

            _stateMap = new Dictionary<Type, BaseState>();
            _stateMap.Add(typeof(BootState), _container.Instantiate<BootState>());
            _stateMap.Add(typeof(MainMenuState), _container.Instantiate<MainMenuState>());
            _stateMap.Add(typeof(LevelCreatorState), _container.Instantiate<LevelCreatorState>());
            _stateMap.Add(typeof(LevelState), _container.Instantiate<LevelState>());
        }

        public void ChangeState<T>(BaseStateArgs args)
        {
            UnityEngine.Debug.Log($"Call ChangeState func with <{typeof(T)}> state");
            if (_currentState.Key == typeof(T)) return;
            if (!_stateMap.ContainsKey(typeof(T))) return;
            _currentState.Value?.Exit(args);

            _currentState = new KeyValuePair<Type, BaseState>(typeof(T), _stateMap[typeof(T)]);
            _currentState.Value.Entry(args);
        }
    }
}