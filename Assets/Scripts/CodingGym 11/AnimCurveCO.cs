using System.Collections;
using UnityEngine;

public class AnimCurveCO : MonoBehaviour
{
    public AnimationCurve floatCurve;
    private Coroutine duckMoveCoroutine;

    public float duckMoveProg;
    public float duckMoveRate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        duckMoveCoroutine = StartCoroutine(duckMove());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator duckMove() 
    {
   

        while (duckMoveProg < duckMoveRate)
        {
            duckMoveProg += Time.deltaTime;
          
            transform.position = new Vector3 (floatCurve.Evaluate(duckMoveProg / duckMoveRate), transform.position.y, transform.position.z);
            if (duckMoveProg > duckMoveRate)
            {
                //We are done growing the tree
                duckMoveProg = 0f;
            }
            yield return null;
        }
    }
}
