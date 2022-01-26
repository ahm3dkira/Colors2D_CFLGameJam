using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public enum Color {        
        red, green, blue, yellow
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Color getRandomColor() {
        return (Color) Random.Range(0, 3 /* Color.values().length-1 */);
    }   
}
