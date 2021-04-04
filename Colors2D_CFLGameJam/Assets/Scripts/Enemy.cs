using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // TODO add stuff
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

        if (other.tag == gameObject.tag)
        {
            // TODO add stuff
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else
        {
            // TODO add stuff better SceneManager 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
