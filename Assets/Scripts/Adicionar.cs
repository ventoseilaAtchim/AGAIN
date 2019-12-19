using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Adicionar : MonoBehaviour
{

    public GameObject NumeroMax;
    public Text Coisa1;
    public Text Coisa2;
    public Text Coisa3;
    public Text Coisa4;
    public Text Coisa5;
    public Text Coisa6;

    public InputField Addicionar;

    int index = 0;

    public void Add()
    {
        if (index == 0 )
        {
            Coisa1.text = Addicionar.text;
            index++;
        }
        else if (index == 1)
        {
            Coisa2.text = Addicionar.text;
            index++;
        }
        else if (index == 2)
        {
            Coisa3.text = Addicionar.text;
            index++;
        }
        else if (index == 3)
        {
            Coisa4.text = Addicionar.text;
            index++;
        }
        else if (index == 4)
        {
            Coisa5.text = Addicionar.text;
            index++;
        }
        else if (index == 5)
        {
            NumeroMax.SetActive(true);
            index = 0;
        }
    }

    public void Close()
    {
        NumeroMax.SetActive(false);
    }

    public void Concluir()
    {
        
        Debug.Log(PlayerPrefs.GetInt("EscolhaCat"));
        SceneManager.LoadScene(1);
    }
}
