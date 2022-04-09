using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovementDVD : MonoBehaviour
{
    public Transform startObject;
    public Transform endObject;

    public float slideDuration = 5f;
    
    Vector3 leftPos;
    Vector3 rightPos;
    
    // Start is called before the first frame update
    void Start()
    {
        leftPos = startObject.transform.position;
        rightPos = endObject.transform.position;
        StartCoroutine(GoRight(slideDuration));
    }

    IEnumerator GoRight(float duration) 
    {
        float time = 0;
        while(time < duration) 
        {
            transform.position = Vector3.Lerp(leftPos, rightPos, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        StartCoroutine(GoLeft(duration));
    }

    IEnumerator GoLeft(float duration)
    {
        float time = 0;
        while (time < duration)
        {
            transform.position = Vector3.Lerp(rightPos, leftPos, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        StartCoroutine(GoRight(duration));
    }


}
