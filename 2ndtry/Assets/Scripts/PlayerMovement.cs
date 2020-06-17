
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float UpwardsForce = 100f;
    public float SidewaysForce = 500f;
    public float ForwardForce = 2000f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, 500);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }
        if (rb.position.y < -1f)

            FindObjectOfType<GameManager>().EndGame();
       
    }            

}
