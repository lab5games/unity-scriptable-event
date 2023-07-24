using UnityEngine;

namespace Lab5Games.ScriptableEvents
{
    [AddComponentMenu("Lab5Games/Scriptable Events/GameObject Event Listener")]
    public class GameObjectScriptableEventListener : BaseScriptableEventListener<GameObject, GameObjectScriptableEvent, GameObjectUnityEvent> { }
}