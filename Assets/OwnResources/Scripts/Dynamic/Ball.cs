using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 250f;
    private Vector2 _velocity;
    private Rigidbody2D _rigidBody2D;
    private bool started;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButtonDown("Jump") && !started)
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
            _velocity = new Vector2(Random.Range(-1f, 1f), 1);
            _rigidBody2D.AddForce(_velocity * speed);
            started = !started;
        }
    }
}
