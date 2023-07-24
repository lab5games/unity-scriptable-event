using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.ScriptableEvents
{
    [System.Serializable]
    public class IntegerUnityEvent : UnityEvent<int> { }

    [CreateAssetMenu(
        fileName = "New Integer Event",
        menuName = "Lab5Games/Scriptable Events/Integer Event")]
    public class IntegerScriptableEvent : BaseScriptableEvent<int> { }
}