using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed;
    public float minPosLeft;
    public float maxPosRight;
    public float padding;

    // Use this for initialization
    void Start () {

        minPosLeft = -5.448667f;
        maxPosRight = 5.448667f;
        padding = 1.218f;

        SetupMoveBoundaries();
    }
    //Methode ResetPlayer() Move Player to middle of screen on floor when the game starts)



    // Update is called once per frame
    void Update () {
    Move();
    //Methode Move() move character left right with arrow keys)

}
private void Move()
{
    var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
    var newPosX = Mathf.Clamp(transform.position.x + deltaX, minPosLeft, maxPosRight);

    transform.position = new Vector2(newPosX, transform.position.y);
}

private void SetupMoveBoundaries()
{
    Camera gameCamera = Camera.main;
    minPosLeft = gameCamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x + padding;
    maxPosRight = gameCamera.ViewportToWorldPoint(new Vector3(1f, 0f, 0f)).x - padding;
    Debug.Log("min " + minPosLeft);
    Debug.Log("max " + maxPosRight);
}
}
