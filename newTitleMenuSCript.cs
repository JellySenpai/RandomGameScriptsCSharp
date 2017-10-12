using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class newTitleMenuSCript : MonoBehaviour {
	public GameObject playButton;
	public GameObject settingsButton;
	public GameObject quitButton;
	public GameObject settingsPanel;
	public GameObject menuPanel;
	public Canvas mainCanvas;
	private LoadSceneMode CharacterSelect;
    public float speed = 1f;
    public bool gameStarted = false;
	public bool animation_play = false;
	public bool pushedPlay = false;
	public bool settingsStart = false;
	// Use this for initialization

	void Start () {
		mainCanvas = mainCanvas.GetComponent<Canvas> ();
		playButton.SetActive (false);
		quitButton.SetActive (false);
		settingsButton.SetActive (false);
		menuPanel.SetActive (false);
		settingsPanel.SetActive (false);
		gameStarted = false;
		settingsStart = false;

	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKey (KeyCode.A)) 
			{
				gameStarted = true;
			}
			
			if (gameStarted == true) 
			{
				transform.position = Vector3.Lerp (this.transform.position, new Vector3 (4.71f, 4.08f, -12.97f), Time.deltaTime * speed);
				transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (90f, 0, 0), Time.deltaTime * speed);
				StartCoroutine (StartMenu (3.0F));
			}
			if (pushedPlay == true) 
			{
				transform.position = Vector3.Lerp (this.transform.position, new Vector3 (0f, -4f, -12.72f), Time.deltaTime * speed);
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(90f, 0,0), Time.deltaTime*speed);
				mainCanvas.enabled = false;
		
			}
			if (settingsStart == true) 
			{
				playButton.SetActive (false);
				quitButton.SetActive (false);
				settingsButton.SetActive (false);
				menuPanel.SetActive (false);
				settingsPanel.SetActive (true);
				gameStarted = false;
			}
			if (Input.GetKey (KeyCode.W)) 
			{
				
			}
			if (settingsStart == true) 
			{
				transform.position = Vector3.Lerp (this.transform.position, new Vector3 (6.1f, .64f, -14.17f), .1f);
				transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 0, 0), .1f);
				playButton.SetActive (false);
				quitButton.SetActive (false);
				settingsButton.SetActive (false);
				menuPanel.SetActive (false);
				settingsPanel.SetActive (true);

			}
			if (Input.GetKey (KeyCode.D)) 
			{
				//StartCoroutine (StartGame (3.0F));
				settingsStart = true;

			}
		}
	public void playGame()
	{
		
		string CharacterSelect = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (CharacterSelect, LoadSceneMode.Single);
	}
	public void playPress()
	{
		StartCoroutine (StartGame (3.0F));
		pushedPlay = true;
	}
	public void settingsPress()
	{
		StartCoroutine (SettingsMenu (1.0F));
		print ("Your settings have been brought up!");
		menuPanel.SetActive (false);
		settingsStart = true;

	}
	public void exitGame()
	{
		Application.Quit ();
	}
	public IEnumerator StartGame(float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		print ("Your game has started!");
		playGame ();
		playButton.SetActive (false);
		quitButton.SetActive (false);
		settingsButton.SetActive (false);
		menuPanel.SetActive (false);
		settingsPanel.SetActive (false);

	}
	public IEnumerator StartMenu (float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		playButton.SetActive (true);
		quitButton.SetActive (true);
		settingsButton.SetActive (true);
		menuPanel.SetActive (true);
		settingsPanel.SetActive (false);

	}
	public IEnumerator SettingsMenu (float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		playButton.SetActive (false);
		quitButton.SetActive (false);
		settingsButton.SetActive (false);
		menuPanel.SetActive (false);
		settingsPanel.SetActive (true);
	}

}
