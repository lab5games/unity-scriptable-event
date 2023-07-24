using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.ScriptableEvents
{
    [System.Serializable]
    public class StringUnityEvent : UnityEvent<string> { }

    [CreateAssetMenu(
        fileName = "New String Event",
        menuName = "Lab5Games/Scriptable Events/String Event")]
    public class StringScriptableEvent : BaseScriptableEvent<string> { }
}