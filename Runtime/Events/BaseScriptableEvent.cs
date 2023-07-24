using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.ScriptableEvents
{
    public abstract class BaseScriptableEvent<T> : ScriptableObject
    {
        private readonly HashSet<Action<T>> _registeredActions = new HashSet<Action<T>>();


        private void OnDisable()
        {
            RemoveListeners();
        }

        public void Raise(T arg)
        {
            foreach(var action in _registeredActions)
            {
                action.Invoke(arg);
            }
        }

        public void AddListener(Action<T> action)
        {
            _registeredActions.Add(action);
        }

        public void AddListener(IScriptableEventListener<T> listener)
        {
            AddListener(listener.OnRaise);
        }

        public void RemoveListener(Action<T> action)
        {
            _registeredActions.Remove(action);
        }

        public void RemoveListener(IScriptableEventListener<T> listener)
        {
            RemoveListener(listener.OnRaise);   
        }

        public void RemoveListeners()
        {
            _registeredActions.Clear();
        }
    }
}
