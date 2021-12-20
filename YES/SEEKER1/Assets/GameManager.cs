
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    
    bool gameHasEnded = false;

    public GameObject completeLevelUI;
    public GameObject LevelFaildUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Level Completed");
    }

    public void EndGame () {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            LevelFaildUI.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Level Failed");
            Invoke("restart", 1.5f);
            
        }
    }
        void restart ()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
      
        


    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
