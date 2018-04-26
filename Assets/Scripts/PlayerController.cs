using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 5.0f;      // speed of player
    public float padding = 0.5f;    // padding for gamespace

    float xmin;
    float xmax;
    // Use this for initialization
    void Start () {
        float distance = transform.position.z - Camera.main.transform.position.z;
        Debug.Log("Object distance from Main camera: " + distance);
        // Calculate position on basis of camera, it's relative
        Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0,distance));
        Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0,distance));
        xmin = leftmost.x + padding;
        xmax = rightmost.x - padding;
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.RightArrow)) {
            // Vector3.left and Vector3.right are shorthand for -1, 0, 0
            transform.position += Vector3.right * speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        // restrict the player to gamespace
        float newX = Mathf.Clamp(transform.position.x, xmin, xmax);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
