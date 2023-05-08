using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsCollect : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endScoreText;
    public TextMeshProUGUI livesText;
    public GameObject GameOverMenu;
    public GameObject slowMotionText;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gameOverSfx;
    [SerializeField] private AudioClip collectSfx;
    [SerializeField] private AudioClip collectSfx2;
    [SerializeField] private AudioClip collectSfx3;
    [SerializeField] private AudioClip collectSfx4;
    [SerializeField] private AudioClip collectSfx5;
    [SerializeField] private AudioClip collectSfx6;
    [SerializeField] private AudioClip collectSfx7;
    [SerializeField] private AudioClip collectSfx8;
    [SerializeField] private AudioClip collectSfx9;
    [SerializeField] private AudioClip collectSfx10;
    [SerializeField] private AudioClip collectSfx11;
    public GameManager speedUp;
    public GameObject Asphalt;
    int score = 0;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        livesText.text = Obstacle.lives.ToString();
        if (Obstacle.lives == 0)
        {
        Obstacle.lives = 3;
        audioSource.PlayOneShot(gameOverSfx);
        anim.SetBool("IsDead", true);
        StartCoroutine(Die());
        }
    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Lager")
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = score.ToString();
            endScoreText.text = score.ToString();
            anim.SetBool("IsMoving", true);
            anim.SetBool("IsDrinking", true);
            StartCoroutine(Drink());

            //increase spawn rate
            if (score == 20)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 40)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 70)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 100)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 150)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 200)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 300)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 400)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 500)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 700)
            {
                speedUp.increaseSpawnrate();
            }
            else if (score == 1000)
            {
                speedUp.increaseSpawnrate();
            }
            

           //increase sound pitch
            if (score >= 20 && score <= 40)
            {
                audioSource.PlayOneShot(collectSfx2);
            }
            else if (score >= 40 && score <= 70)
            {
                audioSource.PlayOneShot(collectSfx3);
            }
            else if (score >= 70 && score <= 100)
            {
                audioSource.PlayOneShot(collectSfx4);
            }
            else if (score >= 100 && score <= 150)
            {
                audioSource.PlayOneShot(collectSfx5);
            }
            else if (score >= 150 && score <= 200)
            {
                audioSource.PlayOneShot(collectSfx6);
            }
            else if (score >= 200 && score <= 300)
            {
                audioSource.PlayOneShot(collectSfx7);
            }
            else if (score >= 300 && score <= 400)
            {
                audioSource.PlayOneShot(collectSfx8);
            }
            else if (score >= 400 && score <= 500)
            {
                audioSource.PlayOneShot(collectSfx9);
            }
            else if (score >= 500 && score <= 700)
            {
                audioSource.PlayOneShot(collectSfx10);
            }
            else if (score >= 700)
            {
                audioSource.PlayOneShot(collectSfx11);
            }
            else
            {
                audioSource.PlayOneShot(collectSfx);
            }
            
        }
        else if (collision.gameObject.tag == "Long Drink")
        {
            Destroy(collision.gameObject);
            score = score +5;
            scoreText.text = score.ToString();
            endScoreText.text = score.ToString();
            anim.SetBool("IsDrinking", true);
            StartCoroutine(Drink());
              //increase sound pitch
            if (score >= 20 && score <= 40)
            {
                audioSource.PlayOneShot(collectSfx2);
            }
            else if (score >= 40 && score <= 70)
            {
                audioSource.PlayOneShot(collectSfx3);
            }
            else if (score >= 70 && score <= 100)
            {
                audioSource.PlayOneShot(collectSfx4);
            }
            else if (score >= 100 && score <= 150)
            {
                audioSource.PlayOneShot(collectSfx5);
            }
            else if (score >= 150 && score <= 200)
            {
                audioSource.PlayOneShot(collectSfx6);
            }
            else if (score >= 200 && score <= 300)
            {
                audioSource.PlayOneShot(collectSfx7);
            }
            else if (score >= 300 && score <= 400)
            {
                audioSource.PlayOneShot(collectSfx8);
            }
            else if (score >= 400 && score <= 500)
            {
                audioSource.PlayOneShot(collectSfx9);
            }
            else if (score >= 500 && score <= 700)
            {
                audioSource.PlayOneShot(collectSfx10);
            }
            else if (score >= 700)
            {
                audioSource.PlayOneShot(collectSfx11);
            }
            else
            {
                audioSource.PlayOneShot(collectSfx);
            }
        }
        
        else if (collision.gameObject.tag == "Joint")
        {
            Destroy(collision.gameObject);
            StartCoroutine(PowerUp());
            slowMotionText.SetActive(true);
        }

        else if(collision.gameObject.tag == "Koskenkorva")
        {
       
            Obstacle.lives = 3;
            audioSource.PlayOneShot(gameOverSfx);
            anim.SetBool("IsDead", true);
            StartCoroutine(Die());
        }

    }
    
        IEnumerator PowerUp()
        {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(10);  
        Time.timeScale = 1;
        slowMotionText.SetActive(false);
        }

        IEnumerator Drink()
        {
        yield return new WaitForSeconds(0.1f); 
        anim.SetBool("IsDrinking", false);
        }

        
        IEnumerator Die()
        {
        GetComponent<BoxCollider2D>().enabled = false;
        Asphalt.GetComponent<BoxCollider2D>().enabled = true;
        GameOverMenu.SetActive(true);
        yield return new WaitForSeconds(5);
        PauseMenu.isPaused = true;
        Time.timeScale = 0;
        }
}
