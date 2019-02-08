
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float sideForce = 100f;
    public float forwardForce = 1000f;
	
	
	
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("q"))
        {
            Debug.Log("Quit");
            Application.Quit();

        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
