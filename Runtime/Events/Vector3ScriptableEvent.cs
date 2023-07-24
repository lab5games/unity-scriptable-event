using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.ScriptableEvents
{
    [System.Serializable]
    public class Vector3UnityEvent : UnityEvent<Vector3> { }

    [CreateAssetMenu(
        fileName = "New Vector3 Event",
        menuName = "Lab5Games/Scriptable Events/Vector3 Event")]
    public class Vector3ScriptableEvent : BaseScriptableEvent<Vector3> { }
}