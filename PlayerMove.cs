using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 20f;
    public float runspeed = 600f;
    public float jump = 1f;
    protected bool dojump = false;
    protected bool Left = false;
    protected bool Right = false;
    protected bool Up = false;
    protected bool Down = false;

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        if (Input.GetKey("d"))
            Left = true;
        else
            Left = false;
        if (Input.GetKey("a"))
            Right = true;
        else
            Right = false;
        if (Input.GetKeyDown("space"))
            dojump = true;
        if (Input.GetKey("w"))
            Up = true;
        else
            Up = false;
        if (Input.GetKey("s"))
            Down = true;
        else
            Down = false;
    }
    void FixedUpdate()
    { 
        
        if (Left)
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Right)
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Up)
        {
            rb.AddForce(0, 0, runspeed * Time.deltaTime);
        }
        if (Down)
        {
            rb.AddForce(0, 0, -runspeed * Time.deltaTime);
        }
        if (dojump)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            dojump = false;
        }
      
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 80, 25), "Deaths = " + Teleport_Death.score);
        GUI.Box(new Rect(600, 0, 80, 25), "Level = " + Level.wins);
    }
}
