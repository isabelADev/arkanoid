using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    Animation _animation;
    // Start is called before the first frame update
    void Start()
    {
        _animation = GetComponent<Animation>();

        foreach (AnimationState state in _animation)
        {
            state.speed = 0.5F;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
