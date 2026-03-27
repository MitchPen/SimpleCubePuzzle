using System;
using UniRx;
using UnityEngine;
using Zenject;

namespace Core.Common.Input
{
    public class InputService: IInputService, IDisposable
    {
        public event Action<InputActionType> ButtonPressed;
        public event Action<InputActionType> ButtonReleased;
        public event Action<InputActionType> Scroll;


        private Vector2 _pointerPosition;
        private InputMapConfig _config;
        private CompositeDisposable  _disposables;

        [Inject]
        public InputService(InputMapConfig  config)
        {
            _config =  config;
        }

        public void BootStrap()
        {
            _disposables =  new CompositeDisposable();
            
            var buttons = _config.GetButtonsSetup();
            if (buttons != null)
            {
                foreach (var buttonSetup in buttons)
                {
                    SubscribeOnButtonPressed(buttonSetup);
                    SubscribeOnButtonRelease(buttonSetup);
                }
            }
        }

        private void SubscribeOnButtonPressed(InputItem item)
        {
            Observable
                .EveryUpdate()
                .Subscribe(_ =>
                {
                    if( UnityEngine.Input.GetKeyDown(item.Key))
                        ButtonPressed?.Invoke(item.Type);
                   
                })
                .AddTo(_disposables);
        }
        
        private void SubscribeOnButtonRelease(InputItem item)
        {
            Observable
                .EveryUpdate()
                .Subscribe(_ =>
                {
                    if( UnityEngine.Input.GetKeyUp(item.Key))
                        ButtonReleased?.Invoke(item.Type);
                   
                })
                .AddTo(_disposables);
        }
        
        public Vector2 GetPointerPosition()
        {
            return Vector2.zero;
        }

        public void Dispose()
        {
            _disposables?.Dispose();
        }
    }
}