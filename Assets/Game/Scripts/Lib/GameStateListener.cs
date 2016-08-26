using UnityEngine;
using UnityEngine.Events;

public class GameStateListener : MonoBehaviour
{
    [SerializeField]
    UnityEvent<string, string> _onStateChange;

    public UnityEvent<string, string> onStateChange
    {
        get { return _onStateChange; }
    }
}
