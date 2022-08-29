using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 20f;

    private Rigidbody2D _rigidbody2D;
    private float _hValue;
    private Vector2 _direction;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _hValue = Input.GetAxis("Horizontal");

        if (_hValue > 0)
        {
            _direction = Vector2.right;
        }
        else if (_hValue < 0)
        {
            _direction = Vector2.left;
        }
        else
        {
            _direction = Vector2.zero;
        }

        Vector2 position = _rigidbody2D.position;

        _rigidbody2D.MovePosition(new Vector2(position.x + _direction.x * moveSpeed * Time.deltaTime, position.y));
    }
}
