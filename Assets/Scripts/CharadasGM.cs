using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;


public class CharadasGM : MonoBehaviour
{
    public GameObject Afazer;
    public GameObject MainAfazer;
    public GameObject aFazerPanel;
    public GameObject ComecarPanel;
    public GameObject FailPanel;

    public GameObject P1Panel;
    public GameObject P2Panel;
    public GameObject P3Panel;
    public GameObject P4Panel;
    public GameObject P5Panel;
    public GameObject P6Panel;

    public Button Vamos;
    public Button Ponto1;
    public Button Ponto2;
    public Button Ponto3;
    public Button Ponto4;
    public Button Ponto5;
    public Button Ponto6;

    public Text player1P;
    public Text player2P;
    public Text player3P;
    public Text player4P;
    public Text player5P;
    public Text player6P;

    public Text pontosP1;
    public Text pontosP2;
    public Text pontosP3;
    public Text pontosP4;
    public Text pontosP5;
    public Text pontosP6;
    public Text TuaVezNome;

    public Text TitleCat;
    public Text Coisa_a_Fazer;
    public Text Coisa_a_Fazer1;
    public Text Timer;


    public Filmes[] FilmesAFazer;
    public bonecos[] BonecosAFazer;
    public Anime[] AnimeAFazer;
    public tudo[] tudoAFazer;

    private static List<Filmes> ListaDeFilmes;
    private static List<bonecos> ListaDeBonecos;
    private static List<Anime> ListaDeAnime;
    private static List<tudo> ListaDeTudo;

    private Filmes FilmeActual;
    private bonecos BonecoActual;
    private tudo TudoActual;
    private Anime AnimeActual;

    //Pontuacao
    int P1Points = 0;
    int P2Points = 0;
    int P3Points = 0;
    int P4Points = 0;
    int P5Points = 0;
    int P6Points = 0;


    int ChooseIndex;
    int MaxP;
    int CurrentPIndex = 1;

    //time
    bool timerCheck = false;
    float timer = 60f;
    bool BeginTimerCheck = false;
    float BeginTimer = 3f;

    public int escolhaCate = 0;
    
    void Start()
    {
        MaxP = PlayerPrefs.GetInt("MaxPlayerV");
        Debug.Log(MaxP);
        escolhaCate = PlayerPrefs.GetInt("EscolhaCat");
        

        CurrentPIndex = Random.Range(0, MaxP);

        if (escolhaCate == 0)
        {

            if (ListaDeFilmes == null || ListaDeFilmes.Count == 0)
            {

                ListaDeFilmes = FilmesAFazer.ToList<Filmes>();

            }

        }
        else if (escolhaCate == 1)
        {
            if (ListaDeBonecos == null || ListaDeBonecos.Count == 0)
            {

                ListaDeBonecos = BonecosAFazer.ToList<bonecos>();

            }

        } 
        else if (escolhaCate == 2)
        {
            if (ListaDeTudo == null || ListaDeTudo.Count == 0)
            {

                ListaDeTudo = tudoAFazer.ToList<tudo>();

            }

        }

        else if (escolhaCate == 3)
        {
            if (ListaDeAnime == null || ListaDeAnime.Count == 0)
            {

                ListaDeAnime = AnimeAFazer.ToList<Anime>();

            }

        }
        else
            Debug.Log("Nao tem categoria");

        //Disable Players
        if (MaxP == 1)
        {
            P2Panel.SetActive(true);
            P3Panel.SetActive(true);
            P4Panel.SetActive(true);
            P5Panel.SetActive(true);
            P6Panel.SetActive(true);
        }

        if (MaxP == 2)
        {

            P3Panel.SetActive(true);
            P4Panel.SetActive(true);
            P5Panel.SetActive(true);
            P6Panel.SetActive(true);
        }
        else if (MaxP == 3)
        {
        
                P3Panel.SetActive(false);
                P4Panel.SetActive(true);
                P5Panel.SetActive(true);
                P6Panel.SetActive(true);
        
        }

        else if (MaxP == 4)
        {

            P3Panel.SetActive(false);
            P4Panel.SetActive(false);
            P5Panel.SetActive(true);
            P6Panel.SetActive(true);
        }

        else if (MaxP == 5)
        {

            P3Panel.SetActive(false);
            P4Panel.SetActive(false);
            P5Panel.SetActive(false);
            P6Panel.SetActive(true);
        }

        else if (MaxP == 6)
        {
         
                P3Panel.SetActive(false);
                P4Panel.SetActive(false);
                P5Panel.SetActive(false);
                P6Panel.SetActive(false);
         
        }



        player1P.text = PlayerPrefs.GetString("Player1NameC").ToString();
        player2P.text = PlayerPrefs.GetString("Player2NameC").ToString();
        player3P.text = PlayerPrefs.GetString("Player3NameC").ToString();
        player4P.text = PlayerPrefs.GetString("Player4NameC").ToString();
        player5P.text = PlayerPrefs.GetString("Player5NameC").ToString();
        player6P.text = PlayerPrefs.GetString("Player5NameC").ToString();

        pontosP1.text = PlayerPrefs.GetInt("P1Score").ToString();
        pontosP2.text = PlayerPrefs.GetInt("P2Score").ToString();
        pontosP3.text = PlayerPrefs.GetInt("P3Score").ToString();
        pontosP4.text = PlayerPrefs.GetInt("P4Score").ToString();
        pontosP5.text = PlayerPrefs.GetInt("P5Score").ToString();
        pontosP6.text = PlayerPrefs.GetInt("P5Score").ToString();

        TitleCat.text = PlayerPrefs.GetString("Cat").ToString();

        //Manbos temporarios


    }

    // Update is called once per frame
    void Update()
    {
        if (timerCheck == true)
        {
            timer -= 1 * Time.deltaTime;
            Timer.text = Mathf.Round(timer).ToString();

            if (timer <= 0)
            {
                FailPanel.SetActive(true);
                timerCheck = false;
            }

        }
        else if (timerCheck == false)
        {
            timer = 60;

        }

        if (BeginTimerCheck == true) 
        {
            BeginTimer -= 1 * Time.deltaTime;
            if (BeginTimer <= 0f)
            {
                aFazerPanel.SetActive(true);
                Vamos.interactable = false;

                BeginTimerCheck = false;
                BeginTimer = 3f;
            }
        }


        //turno
        if (CurrentPIndex == 0)
        {
            TuaVezNome.text = PlayerPrefs.GetString("Player1NameC").ToString();

        }
        else if (CurrentPIndex == 1)
        {
            TuaVezNome.text = PlayerPrefs.GetString("Player2NameC").ToString();

        }

        else if (CurrentPIndex == 2)
        {
            TuaVezNome.text = PlayerPrefs.GetString("Player3NameC").ToString();

        }

        else if (CurrentPIndex == 3)
        {
            TuaVezNome.text = PlayerPrefs.GetString("Player4NameC").ToString();

        }

        else if (CurrentPIndex == 4)
        {
            TuaVezNome.text = PlayerPrefs.GetString("Player5NameC").ToString();

        }
        else if (CurrentPIndex == 5)
        {
            TuaVezNome.text = PlayerPrefs.GetString("Player6NameC").ToString();

        }

        if (CurrentPIndex >= MaxP)
        {
            CurrentPIndex = 0;
        }

    }



    public void carregarCat()
    {
        BeginTimerCheck = true;
        
        
        Vamos.interactable = false;
        Ponto1.interactable = false;
        Ponto2.interactable = false;
        Ponto3.interactable = false;
        Ponto4.interactable = false;
        Ponto5.interactable = false;
        Ponto6.interactable = false;


        if (escolhaCate == 0) {

            ChooseIndex = Random.Range(0, ListaDeFilmes.Count);
            FilmeActual = ListaDeFilmes[ChooseIndex];

            ListaDeFilmes.RemoveAt(ChooseIndex);
            Coisa_a_Fazer.text = FilmeActual.NovoFilme;
            Coisa_a_Fazer1.text = FilmeActual.NovoFilme;

            
        }

        if (escolhaCate == 1)
        {
            ChooseIndex = Random.Range(0, ListaDeBonecos.Count);
            BonecoActual = ListaDeBonecos[ChooseIndex];

            ListaDeBonecos.RemoveAt(ChooseIndex);
            Coisa_a_Fazer.text = BonecoActual.NovoBoneco;
            Coisa_a_Fazer1.text = BonecoActual.NovoBoneco;


        }
        if (escolhaCate == 2)
        {
            ChooseIndex = Random.Range(0, ListaDeTudo.Count);
            TudoActual = ListaDeTudo[ChooseIndex];

            ListaDeTudo.RemoveAt(ChooseIndex);
            Coisa_a_Fazer.text = TudoActual.NovoTudo;
            Coisa_a_Fazer1.text = TudoActual.NovoTudo;


        }
        if (escolhaCate == 3)
        {
            ChooseIndex = Random.Range(0, ListaDeAnime.Count);
            AnimeActual = ListaDeAnime[ChooseIndex];

            ListaDeAnime.RemoveAt(ChooseIndex);
            Coisa_a_Fazer.text = AnimeActual.NovoAnime;
            Coisa_a_Fazer1.text = AnimeActual.NovoAnime;


        }


    }

    public void Comecar()
    {
        timerCheck = true;
        ComecarPanel.SetActive(false);

        Ponto1.interactable = true;
        Ponto2.interactable = true;
        Ponto3.interactable = true;
        Ponto4.interactable = true;
        Ponto5.interactable = true;
        Ponto6.interactable = true;


    }

    public void bom()
    {


        Afazer.SetActive(false);
        FailPanel.SetActive(false);
        ComecarPanel.SetActive(true);
        timerCheck = false;

        if (CurrentPIndex == 0)
        {
            P1Points = PlayerPrefs.GetInt("P1Score") + 10;
            pontosP1.text = P1Points.ToString();

        }
        else if (CurrentPIndex == 1)
        {
            P2Points = PlayerPrefs.GetInt("P2Score") + 10;
            pontosP2.text = P2Points.ToString();

        }

        else if (CurrentPIndex == 2)
        {
            P3Points = PlayerPrefs.GetInt("P3Score") + 10;
            pontosP3.text = P3Points.ToString();
        }

        else if (CurrentPIndex == 3)
        {
            P4Points = PlayerPrefs.GetInt("P4Score") + 10;
            pontosP4.text = P4Points.ToString();
        }

       



        CurrentPIndex++;

        if (CurrentPIndex >= 5)
        {
            CurrentPIndex = 0;
        }
        aFazerPanel.SetActive(false);
    }
    public void mal()
    {
        Afazer.SetActive(false);
        FailPanel.SetActive(false);
        ComecarPanel.SetActive(true);
        timerCheck = false;

        aFazerPanel.SetActive(false);
        CurrentPIndex++;

        if (CurrentPIndex > MaxP)
        {
            CurrentPIndex = 0;
        }
    }

    public void P1Ponto ()  
    {
        P1Points += 10;
        pontosP1.text = P1Points.ToString();

        Ponto1.interactable = false;
        Ponto2.interactable = false;
        Ponto3.interactable = false;
        Ponto4.interactable = false;
        Ponto5.interactable = false;
        Ponto6.interactable = false;


        timerCheck = false;
    }

    public void P2Ponto()
    {
        P2Points += 10;
        pontosP2.text = P2Points.ToString();

        Ponto1.interactable = false;
        Ponto2.interactable = false;
        Ponto3.interactable = false;
        Ponto4.interactable = false;
        Ponto5.interactable = false;
        Ponto6.interactable = false;


        timerCheck = false;
    }

    public void P3Ponto()
    {
        P3Points += 10;
        pontosP3.text = P3Points.ToString();

        Ponto1.interactable = false;
        Ponto2.interactable = false;
        Ponto3.interactable = false;
        Ponto4.interactable = false;
        Ponto5.interactable = false;
        Ponto6.interactable = false;


        timerCheck = false;
    }

    public void P4Ponto()
    {
        P4Points += 10;
        pontosP4.text = P4Points.ToString();

        Ponto1.interactable = false;
        Ponto2.interactable = false;
        Ponto3.interactable = false;
        Ponto4.interactable = false;
        Ponto5.interactable = false;
        Ponto6.interactable = false;


        timerCheck = false;
    }

    public void P5Ponto()
    {
        P5Points += 10;
        pontosP5.text = P5Points.ToString();

        Ponto1.interactable = false;
        Ponto2.interactable = false;
        Ponto3.interactable = false;
        Ponto4.interactable = false;
        Ponto5.interactable = false;
        Ponto6.interactable = false;


        timerCheck = false;
    }
    public void P6Ponto()
    {
        P6Points += 10;
        pontosP6.text = P6Points.ToString();

        Ponto1.interactable = false;
        Ponto2.interactable = false;
        Ponto3.interactable = false;
        Ponto4.interactable = false;
        Ponto5.interactable = false;
        Ponto6.interactable = false;


        timerCheck = false;
    }
    public void test()
    {
        aFazerPanel.SetActive(true);
    }
    public void okDone()
    {
        MainAfazer.SetActive(false);
        FailPanel.SetActive(false);
        ComecarPanel.SetActive(true);

        
        timerCheck = false;
        Vamos.interactable = true;

        if (CurrentPIndex > MaxP)
        {
            CurrentPIndex = 0;
        }
        else
        {
            CurrentPIndex++;
        }
        

    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
}
