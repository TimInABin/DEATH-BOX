using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlayerMovment : MonoBehaviour{

    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float RightForce = 500f;
    public float LeftForce = 500f;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(RightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-LeftForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
