using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] colorBallsGameobject;
    private List<GameObject> ballsStack = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TODO add buttons? for mobile?
        if (Input.GetKeyDown(KeyCode.R)) { SpawnColorBall(0); }
        else if (Input.GetKeyDown(KeyCode.B)) { SpawnColorBall(1); }
        else if (Input.GetKeyDown(KeyCode.G)) { SpawnColorBall(2); }
        else if (Input.GetKeyDown(KeyCode.Y)) { SpawnColorBall(3); }
        else { }


        if (Input.GetKeyDown(KeyCode.Backspace)) { 
            if (ballsStack.Count != 0) {
                Destroy(ballsStack[0]);    
                ballsStack.RemoveAt(0); 
            }
        }
    }


    public void SpawnColorBall(int index)
    {
        // TODO add stuff enum or something?
        ballsStack.Add(Instantiate(colorBallsGameobject[index], transform.position, Quaternion.identity));
        //switch (index)
        //{
        //    case 0:
        //        break;
        //    case 1:
        //        break;
        //    case 2:
        //        break;
        //    default:
        //        break;
        //}

    }
}
