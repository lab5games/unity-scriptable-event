using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.ScriptableEvents
{
    [System.Serializable]
    public class GameObjectUnityEvent : UnityEvent<GameObject> { }

    [CreateAssetMenu(
        fileName = "New GameObject Event",
        menuName = "Lab5Games/Scriptable Events/GameObject Event")]
    public class GameObjectScriptableEvent : BaseScriptableEvent<GameObject> { }
}