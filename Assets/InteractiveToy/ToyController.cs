using UnityEngine;
namespace InteractiveToy
{

public class ToyController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the toy with arrow keys
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);


            // Rotate the toy with mouse movement
            float rotateHorizontal = Input.GetAxis("Mouse X");
            float rotateVertical = Input.GetAxis("Mouse Y");

            Vector3 rotation = new Vector3(rotateVertical, -rotateHorizontal, 0.0f);
            transform.Rotate(rotation * rotateSpeed * Time.deltaTime, Space.Self);

    }
 }
}
