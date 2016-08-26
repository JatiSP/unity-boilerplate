using UnityEngine;
using UnityEngine.Events;

public class PauseListener : MonoBehaviour
{
    [SerializeField]
    UnityEvent _onPause;

    [SerializeField]
    UnityEvent _onResume;

    public UnityEvent onPause
    {
        get { return _onPause; }
    }

    public UnityEvent onResume
    {
        get { return _onResume; }
    }
}
