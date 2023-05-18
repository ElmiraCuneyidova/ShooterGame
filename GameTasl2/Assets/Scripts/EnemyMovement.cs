
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject Player;
    [SerializeField] float EnemySpeed;
    private PlayerTranslate player;

 
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        player= Player.GetComponent<PlayerTranslate>();
    }

    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Player.transform.position,EnemySpeed);
        transform.LookAt(Player.transform.position);

    }
    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "PlayerBullet")
        {
            Destroy(transform.gameObject);
            player._coin += 10;
            Debug.Log(player._coin);
        }
    }
 
}
