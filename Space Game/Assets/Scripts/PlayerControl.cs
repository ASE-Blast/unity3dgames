using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody player;
    public ParticleSystem fire;

    public float jumpForce;
    public float moveSpeed;
    public float rotateSpeed;

    public LayerMask Obstacle;
    public MeshCollider playerCollider;

    // Start is called before the first frame update
    void Start()
    {

        player.GetComponent<Rigidbody>();
        playerCollider.GetComponent<MeshCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);

        

        if (Input.GetButton("Jump"))
        {
            player.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
            fire.Play();
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, 50), -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, 50), rotateSpeed * Time.deltaTime);
        }
    }
    public void FixedUpdate()
    {
        player.GetComponent<Rigidbody>().AddForce(Physics.gravity * 2, ForceMode.Acceleration);

        if(player.position.y < -1f)
        {
            FindObjectOfType<GameManager>().PlayerCollidesWall();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstical"))
        {
            FindObjectOfType<GameManager>().PlayerCollidesWall();
        }
    }

}
