using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 6;
    public float rotSpeed = 100;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		transform .position += transform .forward * speed * Time .deltaTime;
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed);
        }
	}
}
