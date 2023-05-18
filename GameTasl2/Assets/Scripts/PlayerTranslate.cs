using UnityEngine;

public class PlayerTranslate : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float mapWide;
    [SerializeField] float mapLength;
    public float _coin;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(
          Input.GetAxis("Horizontal"), 0f,  
           Input.GetAxis("Vertical")) * 
            Time.deltaTime * speed, Space.Self);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation *= Quaternion.Euler(0f, 2f, 0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation *= Quaternion.Euler(0f,-2f,0f);
        }


        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, -mapWide, mapWide);
        position.z = Mathf.Clamp(position.z, -mapLength, mapLength);
        transform.position = position;

    }
}
