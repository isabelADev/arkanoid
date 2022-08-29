using UnityEngine;

public class DeathSpace : MonoBehaviour
{
    public GameObject gameOver;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameOver.SetActive(true);    
    }
}
