using UnityEngine;

public class GameController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            var controller = FindObjectOfType<PauseController>();
            controller.isPaused = !controller.isPaused;
        }
    }
}
