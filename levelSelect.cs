using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour {
	private LoadSceneMode wweArena;
	private LoadSceneMode jungleLevel;
	public Canvas levelSelectCanvas;
	public Button wweButton;
	public Button jungleButton;
	public Button menuReturnButton;
	// Use this for initialization
	void Start () {
		levelSelectCanvas = levelSelectCanvas.GetComponent<Canvas> ();
		wweButton = wweButton.GetComponent<Button> ();
		jungleButton = jungleButton.GetComponent<Button> ();
		menuReturnButton = menuReturnButton.GetComponent<Button> ();
		wweButton.Select ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void wweLevel()
	{
		string wweArena = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (wweArena, LoadSceneMode.Single);
	}
	public void junglePress()
	{
		string jungleLevel = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (jungleLevel, LoadSceneMode.Single);
	}
}
