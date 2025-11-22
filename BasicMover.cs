using UnityEngine;

public class BasicMover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;

    public bool doSpin = true;
    public bool doMotion = false;

    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            //Rotate around the up axis of the gameobject
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        
        if (doMotion)
        {
            //move up and down over time
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }

        
    }
}
