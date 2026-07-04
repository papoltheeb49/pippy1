using UnityEngine;
using UnityEngine.InputSystem;
public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float jumpForce = 10f;
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            myRigibody.linearVelocity = new Vector2(0, jumpForce * 2);
        }
    }
}
