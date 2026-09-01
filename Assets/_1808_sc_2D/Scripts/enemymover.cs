using UnityEngine;

public class enemymover : MonoBehaviour
{
    [SerializeField] float speed;
    GameObject[] enemyArray;
    public GameObject[] EnemyArray => enemyArray;
    [SerializeField] enemyspawner Enemyspawner;
    
    void MoveEnemies()
    {
        foreach (GameObject enemy in enemyspawner.enemyArray);
        {
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject enemy in enemyArray)
        {
            var position = enemy.transform.position;
            position.y += -(speed * Time.deltaTime);
            enemy.transform.position = position;
                
        }
    }
}
