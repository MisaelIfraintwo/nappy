using UnityEngine;

public class counter : MonoBehaviour
{
    private int enemigos;

    public GameManager gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        enemigos = GameObject.FindGameObjectsWithTag("Enemy").Length;

        
    }
    private void Update()
    {
        enemigos = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if(enemigos == 0) { gameManager.SceneChange(2); }
    }
}
