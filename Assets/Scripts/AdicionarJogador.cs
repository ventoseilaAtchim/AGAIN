using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class AdicionarJogador : MonoBehaviour
{
    public GameObject NPlayersPanel;
    public GameObject Maxplayers;
    public GameObject ZeroPlayersPanel;

    public Button ConfirmNPlayers;
    public Button Comecar;
    public InputField AdicionarJ;

    public Text player1;
    public Text player2;
    public Text player3;
    public Text player4;
    public Text player5;
    public Text player6;
    public Text NplayerDisplay;


    string playerName1;
    string playerName2;
    string playerName3;
    string playerName4;
    string playerName5;
    string playerName6;


    int playerIndex = 0;
    int MaxPlayers = 0;
    // Start is called before the first frame update
    void Start()
    {
        ConfirmNPlayers.interactable = false;
        Comecar.interactable = false;
        //DontDestroyOnLoad(playerName1);
    }

    // Update is called once per frame
    void Update()
    {
        if (MaxPlayers < 2)
        {
            ConfirmNPlayers.interactable = false;
            Comecar.interactable = false;
        }
        else if (MaxPlayers > 2)
        {
            ConfirmNPlayers.interactable = true;
            

        }
    }

   
    public void add()
    {
        MaxPlayers = PlayerPrefs.GetInt("MaxPlayerV");

        if (playerIndex == 0)
        {
            playerName1 = AdicionarJ.text;
            PlayerPrefs.SetString("Player1NameC", playerName1);
            player1.text = PlayerPrefs.GetString("Player1NameC").ToString();

            PlayerPrefs.SetInt("P1Score", 0);
            PlayerPrefs.SetInt("P2Score", 0);
            PlayerPrefs.SetInt("P3Score", 0);
            PlayerPrefs.SetInt("P4Score", 0);
            PlayerPrefs.SetInt("P5Score", 0);
            PlayerPrefs.SetInt("P6Score", 0);

            
            PlayerPrefs.GetInt("NPlayer", MaxPlayers);
            NplayerDisplay.text = "1";


            playerIndex++;
        }

        else if (playerIndex == 1)
        {
            playerName2 = AdicionarJ.text;
            PlayerPrefs.SetString("Player2NameC", playerName2);
            player2.text = PlayerPrefs.GetString("Player2NameC").ToString();

            playerIndex++;
            Debug.Log("Index Player: " + playerIndex);
            NplayerDisplay.text = "2";

        }

        else if (playerIndex == 2)
        {
            playerName3 = AdicionarJ.text;
            PlayerPrefs.SetString("Player3NameC", playerName3);
            player3.text = PlayerPrefs.GetString("Player3NameC").ToString();

            playerIndex++;
            Debug.Log("Index Player: " + playerIndex);
            
        }

        else if (playerIndex == 3)
        {
            playerName4 = AdicionarJ.text;
            PlayerPrefs.SetString("Player4NameC", playerName4);
            player4.text = PlayerPrefs.GetString("Player4NameC").ToString();

            playerIndex++;
        }

        else if (playerIndex == 4)
        {
            playerName5 = AdicionarJ.text;
            PlayerPrefs.SetString("Player5NameC", playerName5);
            player5.text = PlayerPrefs.GetString("Player5NameC").ToString();

            playerIndex++;
        }

        else if (playerIndex == 5)
        {
            playerName6 = AdicionarJ.text;
            PlayerPrefs.SetString("Player6NameC", playerName6);
            player6.text = PlayerPrefs.GetString("Player6NameC").ToString();

            playerIndex++;
        }

        

        if (playerIndex == MaxPlayers)
        {
            Comecar.interactable = true;
            AdicionarJ.interactable = false;
            
        }


    }

    public void NumeroDeJogadores()
    {

    }

    public void N1Jogadores()
    {
        MaxPlayers = 1;
        PlayerPrefs.SetInt("NPlayer", MaxPlayers);
        PlayerPrefs.SetInt("MaxPlayerV", 1);

        ConfirmNPlayers.interactable = true;
        NplayerDisplay.text = "1";
    }

    public void N2Jogadores()
    {
        MaxPlayers = 2;
        PlayerPrefs.SetInt("NPlayer", MaxPlayers);
        PlayerPrefs.SetInt("MaxPlayerV", 2);

        ConfirmNPlayers.interactable = true;
        NplayerDisplay.text = "2";
    }

    public void N3Jogadores()
    {
        MaxPlayers = 3;
        PlayerPrefs.SetInt("NPlayer", MaxPlayers);
        PlayerPrefs.SetInt("MaxPlayerV", 3);

        ConfirmNPlayers.interactable = true;
        NplayerDisplay.text = "3";
    }

    public void N4Jogadores()
    {
        MaxPlayers = 4;
        PlayerPrefs.SetInt("NPlayer", MaxPlayers);
        PlayerPrefs.SetInt("MaxPlayerV", 4);

        ConfirmNPlayers.interactable = true;
        NplayerDisplay.text = "4";
    }

    public void N5Jogadores()
    {
        MaxPlayers = 5;
        PlayerPrefs.SetInt("NPlayer", MaxPlayers);
        PlayerPrefs.SetInt("MaxPlayerV", 5);

        ConfirmNPlayers.interactable = true;
        NplayerDisplay.text = "5";
    }

    public void N6Jogadores()
    {
        MaxPlayers = 6;
        PlayerPrefs.SetInt("NPlayer", MaxPlayers);
        PlayerPrefs.SetInt("MaxPlayerV", 6);

        ConfirmNPlayers.interactable = true;
        NplayerDisplay.text = "6";
    }

    

    public void BttConfirmNPlayer()
    {
        NPlayersPanel.SetActive(false);

        
        if (MaxPlayers == 1)
        {
            PlayerPrefs.GetInt("1Player", MaxPlayers);
        }
        else if (MaxPlayers == 2)
        {
            PlayerPrefs.GetInt("2Player", MaxPlayers);
        }
        else if (MaxPlayers == 3)
        {
            PlayerPrefs.GetInt("3Player", MaxPlayers);
        }
        else if (MaxPlayers == 4)
        {
            PlayerPrefs.GetInt("4Player", MaxPlayers);
        }
        else if (MaxPlayers == 5)
        {
            PlayerPrefs.GetInt("5Player", MaxPlayers);
        }
        else if (MaxPlayers == 6)
        {
            PlayerPrefs.GetInt("6Player", MaxPlayers);
        }
    }
   
    public void concluirAdd()
    {
        
        SceneManager.LoadScene(1);
        
    }

    public void close()
    {
        Maxplayers.SetActive(false);
    }

    


}
