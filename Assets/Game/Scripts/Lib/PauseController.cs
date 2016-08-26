using UnityEngine;
using UnityEngine.Events;

public class PauseController : MonoBehaviour
{
    [SerializeField]
    bool _isPaused;

    [SerializeField]
    UnityEvent _onPause;

    [SerializeField]
    UnityEvent _onResume;

    public bool isPaused
    {
        get { return _isPaused; }
        set
        {
            if (_isPaused != value)
            {
                if (value) OnPause(); else OnResume();
                _isPaused = value;
            }
        }
    }

    public UnityEvent onPause
    {
        get { return _onPause; }
    }

    public UnityEvent onResume
    {
        get { return _onResume; }
    }

    void OnPause()
    {
        onPause.Invoke();
        
        foreach (var listener in FindObjectsOfType<PauseListener>())
            listener.onPause.Invoke();
    }

    void OnResume()
    {
        onResume.Invoke();

        foreach (var listener in FindObjectsOfType<PauseListener>())
            listener.onResume.Invoke();
    }

    void OnApplicationPause(bool pause)
    {
        isPaused = pause;
    }

    public void Pause()
    {
        isPaused = true;
    }

    public void Resume()
    {
        isPaused = false;
    }
}
