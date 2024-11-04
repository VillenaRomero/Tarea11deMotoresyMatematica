using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creartubodearriba : MonoBehaviour
{
    public GameObject pretubodearriba;
    public float minYposition;
    public float maxYposition;
    public float xPosition;
    private void Start()
    {
        Createenemy();
    }
    void Createenemy()
    {
        float yposition = Random.Range(minYposition, maxYposition);
        Vector2 positioncreate = new Vector3(xPosition, yposition, 0);
        GameObject tubodearriba = Instantiate(pretubodearriba, positioncreate, transform.rotation);
        Invoke("Createenemy", 5.0f);
    }
}
