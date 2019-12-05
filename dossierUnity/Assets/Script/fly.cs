using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fly : MonoBehaviour {
    AudioSource audioSource;
    [SerializeField]
    AudioClip jump, getCoin;
    Rigidbody2D rb;
    [SerializeField]
    GameObject gameManager,scoreBoard;
    Text score;
    bool canMove=false;
    int cpt = 0;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(launchGame());
        score = scoreBoard.GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canMove)
        {
            audioSource.PlayOneShot(jump);
            rb.velocity = Vector2.up * 1.4f;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreBoard.SetActive(false);
        gameManager.GetComponent<gameManager>().lose(cpt);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cpt++;
        score.text = cpt.ToString();
        audioSource.PlayOneShot(getCoin);
    }

    IEnumerator launchGame()
    {
        yield return new WaitForSeconds(1f);
        canMove = true;
        rb.gravityScale = 0.5f;
    }
}
