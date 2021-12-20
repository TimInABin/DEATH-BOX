using UnityEngine;

public class EndOfLevel : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
