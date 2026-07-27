using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using System.Collections;

public class grow : MonoBehaviour
{
   public AnimationCurve curve;
    public float timer=5f;

    public float sizeMax=15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(grow1());
        
    }
    public IEnumerator grow1()
    {
        float startTimer = 0f;
        while (startTimer < timer) { 
        startTimer += Time.deltaTime;
            transform.localScale = Vector3.one*sizeMax*curve.Evaluate(startTimer/timer);
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
