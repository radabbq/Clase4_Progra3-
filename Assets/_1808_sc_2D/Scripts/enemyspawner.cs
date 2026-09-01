using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class enemyspawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Transform enemyParent;
    
    [SerializeField] int width;
    [SerializeField] int length;
    [SerializeField] float spacing;
    [SerializeField] private Color enemyColor;
   
    public static GameObject[] enemyArray;
    
    //Property

    public GameObject[] EnemyArray
    {
        get => enemyArray;
        set => enemyArray = value;
    }


    void Start()
    {
        CreateEnemyGrid();
    }


    void update()
    {
        MoveEnemies();

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Destroy(enemyArray[0].gameObject);
        }
        
    }
    








    void CreateEnemyGrid()
    {
        var size = width * length;
        enemyArray = new GameObject[size];
        
        for (int i = 0; i < size; i++)
        {
            float x = (i % width)*spacing;
            float y = (i / length)*spacing;

            var position = new Vector3(x, y, 0.0f);

            GameObject enemy = Instantiate(enemyPrefab, enemyParent);
            enemy.transform.localPosition = position;

            enemyArray[i] = enemy;
        }
    }

    void MoveEnemies()
    {
        
    }    













}
