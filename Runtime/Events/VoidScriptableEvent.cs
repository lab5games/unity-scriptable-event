using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.ScriptableEvents
{
    public struct Void
    {
        public static Void Empty = new Void();
    }

    [System.Serializable ]
    public class VoidUnityEvent : UnityEvent<Void> { }

    [CreateAssetMenu(
        fileName = "New Void Event",
        menuName = "Lab5Games/Scriptable Events/Void Event")]
    public class VoidScriptableEvent : BaseScriptableEvent<Void>
    {
        public void Raise() => Raise(Void.Empty);
    }
}