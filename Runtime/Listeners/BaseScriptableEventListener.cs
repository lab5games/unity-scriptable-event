using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.ScriptableEvents
{
    public interface IScriptableEventListener<T>
    {
        void OnRaise(T arg);
    }

    public abstract class BaseScriptableEventListener<T, E, U> : MonoBehaviour, IScriptableEventListener<T>
        where E : BaseScriptableEvent<T>
        where U : UnityEvent<T>
    {
        [SerializeField] protected E scriptableEvent;
        [SerializeField] protected U unityEvent;

        protected virtual void OnEnable()
        {
            scriptableEvent?.AddListener(this);
        }

        protected virtual void OnDisable()
        {
            scriptableEvent?.RemoveListener(this);
        }

        public virtual void OnRaise(T arg)
        {
            unityEvent?.Invoke(arg);
        }
    }
}