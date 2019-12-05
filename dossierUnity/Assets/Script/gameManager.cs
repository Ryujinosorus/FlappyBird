using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

    [SerializeField]
    GameObject startTuyau,starMenu,bird,gameOver;
	// Use this for initialization
    public void launch()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void lose(int s)
    {
        gameOver.transform.Find("score").GetComponent<Text>().text = s.ToString();
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
