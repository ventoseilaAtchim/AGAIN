using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int escolha = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscolherFilmes()
    {

        PlayerPrefs.SetInt("EscolhaCat", 0);
        SceneManager.LoadScene(2);
        Debug.Log("Player Pref: " + PlayerPrefs.GetInt("EscolhaCat"));
    }

    public void EscolherBoneco()
    {

        PlayerPrefs.SetInt("EscolhaCat", 1);
        SceneManager.LoadScene(2); 
        Debug.Log("Player Pref: " + PlayerPrefs.GetInt("EscolhaCat"));
    }

    public void EscolherAnime()
    {

        PlayerPrefs.SetInt("EscolhaCat", 3);
        SceneManager.LoadScene(2);
        Debug.Log("Player Pref: " + PlayerPrefs.GetInt("EscolhaCat"));
    }

    public void EscolherTudo()
    {

        PlayerPrefs.SetInt("EscolhaCat", 2);
        SceneManager.LoadScene(2);
        Debug.Log("Player Pref: " + PlayerPrefs.GetInt("EscolhaCat"));
    }
}
