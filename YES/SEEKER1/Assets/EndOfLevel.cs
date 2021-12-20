using UnityEngine;
using UnityEngine.Audio;

public class TheEndOfLevel : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();

    }

    


}
