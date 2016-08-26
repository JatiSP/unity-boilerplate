using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text ui;

    void Update()
    {
        ui.text = Mathf.FloorToInt(Time.realtimeSinceStartup).ToString();
    }
}
