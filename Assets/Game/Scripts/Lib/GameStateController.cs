using UnityEngine;
using UnityEngine.Events;

public class GameStateController : MonoBehaviour
{
    [SerializeField]
    string _currentState;

    [SerializeField]
    UnityEvent<string, string> _onStateChange;

    public string currentState
    {
        get { return _currentState; }
        set
        {
            if (_currentState != value)
            {
                OnStateChange(currentState, value);
                _currentState = value;
            }
        }
    }

    public UnityEvent<string, string> onStateChange
    {
        get { return _onStateChange; }
    }

    void OnStateChange(string current, string next)
    {
        onStateChange.Invoke(current, next);

        foreach (var listener in FindObjectsOfType<GameStateListener>())
        {
            listener.onStateChange.Invoke(current, next);
        }
    }
}
