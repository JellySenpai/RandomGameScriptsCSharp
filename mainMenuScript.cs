using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour {
    public Canvas mainCanvas;
    public GameObject playButton;
    public GameObject settingsButton;
    public GameObject exitButton;
    public GameObject creditButton;
	public GameObject quitPanel;
    public GameObject settingsPanel;
    public GameObject audioPanel;
    public GameObject videoPanel;
    public GameObject creditPanel;
    private LoadSceneMode firstLevel;
    // Use this for initialization
    void Start () {
		mainCanvas = mainCanvas.GetComponent<Canvas>();
		quitPanel.SetActive (false);
        settingsPanel.SetActive(false);
        creditPanel.SetActive(false);
        audioPanel.SetActive(false);
        videoPanel.SetActive(false);
        mainCanvas.enabled = true;
        playButton.SetActive(true);
        settingsButton.SetActive(true);
        creditButton.SetActive(true);
        exitButton.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void playGame()
	{
        string firstLevel = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(firstLevel, LoadSceneMode.Single);

    }
	public void exitGame()
	{
		Application.Quit ();
	}
	public void exitPress()
	{
        playButton.SetActive(false);
        exitButton.SetActive(false);
        creditButton.SetActive(false);
        settingsButton.SetActive(false);
		quitPanel.SetActive (true);
        settingsPanel.SetActive(false);
	}
	public void noPress()
	{
        playButton.SetActive(true);
        exitButton.SetActive(true);
        settingsButton.SetActive(true);
        creditButton.SetActive(true);
        quitPanel.SetActive (false);
        audioPanel.SetActive(false);
        audioPanel.SetActive(false);
        audioPanel.SetActive(false);
        settingsPanel.SetActive(false);
	}
    public void settingsPress()
    {
        playButton.SetActive(false);
        exitButton.SetActive(false);
        creditButton.SetActive(false);
        settingsButton.SetActive(false);
        quitPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }
    public void audioPress()
    {
        playButton.SetActive(false);
        exitButton.SetActive(false);
        creditButton.SetActive(false);
        settingsButton.SetActive(false);
        quitPanel.SetActive(false);
        settingsPanel.SetActive(false);
        audioPanel.SetActive(true);
    }
    public void videoPress()
    {
        playButton.SetActive(false);
        exitButton.SetActive(false);
        creditButton.SetActive(false);
        settingsButton.SetActive(false);
        quitPanel.SetActive(false);
        settingsPanel.SetActive(true);
        videoPanel.SetActive(true);
    }
}
