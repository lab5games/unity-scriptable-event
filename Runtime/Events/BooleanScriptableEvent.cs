using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.ScriptableEvents
{
    [System.Serializable]
    public class BooleanUnityEvent : UnityEvent<bool> { }

    [CreateAssetMenu(
        fileName = "New Boolean Event",
        menuName = "Lab5Games/Scriptable Events/Boolean Event")]
    public class BooleanScriptableEvent : BaseScriptableEvent<bool> { }
}