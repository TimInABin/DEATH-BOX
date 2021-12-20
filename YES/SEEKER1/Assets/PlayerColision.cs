using UnityEngine;

public class PlayerColision : MonoBehaviour
{

    public PlayerMovment movmant;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstical")
            {

            movmant.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

            FindObjectOfType<AudioManager>().Play("Level Failed");

            }
    }

    
}
