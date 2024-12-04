using UnityEngine;
namespace Task20
{


    public class InteractiveToy : MonoBehaviour
    {
        public float speed = 5.0f;



        // Update is called once per frame
        void Update()
        {
            Vector3 position = transform.position;

            // Move forward
            if (Input.GetKey(KeyCode.W))
            {
                position.z += speed * Time.deltaTime;
            }
            // Move backward
            if (Input.GetKey(KeyCode.S)
            {
                position.z -= speed * Time.deltaTime;
            }
            // Move right
            if (Input.GetKey(KeyCode.D))
            {
                position.x += speed * Time.deltaTime;
            }
            // Move Left 
            if (Input.GetKey(KeyCode.A))
            {
                position.x -= speed * Time.deltaTime;
            }
            transform.position = position;

        }

    }
}