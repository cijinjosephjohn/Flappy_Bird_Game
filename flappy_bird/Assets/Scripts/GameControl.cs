using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f; //addded while scrolling bg in scrolling objects page
    private int score = 0;
    public Text scoreText;

    // Start is called before the first frame update

    //void start -> void awake
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver==true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //to reload the scene after death
        }
    }
    public void BirdScored()
    {
	if(gameOver){
		return;
	}
	score++;
	scoreText.text="Score : "+ score.ToString();	
    }
    
    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}