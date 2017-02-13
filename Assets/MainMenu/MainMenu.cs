using UnityEngine;
using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
using System.Collections;
using UnityEngine.SceneManagement; // neded in order to load scenes

public class MainMenu : MonoBehaviour
{
    public Canvas mainMenu;
    public Button startText;
    public Button instructionText;
    public Button creditText;
    public Button exitText;
    private Image credits;
    private Image instructions;

    void Start()

    {
        mainMenu = mainMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        //instructionText = instructionText.GetComponent<Button>();
        //creditText = creditText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        //mainMenu.enabled = true;
        credits = credits.GetComponent<Image>();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject credits = GameObject.Find("credits");
            credits.GetComponent<Image>().enabled = false;
            GameObject instructions = GameObject.Find("instructions");
            instructions.GetComponent<Image>().enabled = false;
        }
        }
    //public void ExitPress() //this function will be used on our Exit button

    //{
    //    mainMenu.enabled = true; //enable the Quit menu when we click the Exit button
    //    startText.enabled = false; //then disable the Play and Exit buttons so they cannot be clicked
    //    exitText.enabled = false;

    //}

    //public void NoPress() //this function will be used for our "NO" button in our Quit Menu

    //{
    //    quitMenu.enabled = false; //we'll disable the quit menu, meaning it won't be visible anymore
    //    startText.enabled = true; //enable the Play and Exit buttons again so they can be clicked
    //    exitText.enabled = true;

    //}

    public void StartLevel() //this function will be used on our Play button

    {
        SceneManager.LoadScene(1); //this will load our first level from our build settings. "1" is the second scene in our game

    }
    public void instructionLevel()

    {
        GameObject instructions = GameObject.Find("instructions");
        instructions.GetComponent<Image>().enabled = true;
    }

    public void CreditLevel()  // loads credits

    {
        GameObject credits = GameObject.Find("credits");
        credits.GetComponent<Image>().enabled = true;
    }



    public void ExitGame() //This function will be used on our "Yes" button in our Quit menu

    {
        Application.Quit(); //this will quit our game. Note this will only work after building the game

    }

}