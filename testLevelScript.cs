using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class testLevelScript : MonoBehaviour {
	private LoadSceneMode wweLevelScene;
	private LoadSceneMode jungleLevelScene;
	private LoadSceneMode mainTitle;
	public Canvas canvasLevel;
	public Button dabut;
	public GameObject junglePreview;
	public GameObject wwePreview;
	public Button randomPreview;
	public Button jungleButton;
	public Button wweButton;
	public Button randomButton;
	// Use this for initialization
	void Start () {
		dabut.Select ();
		canvasLevel = canvasLevel.GetComponent<Canvas> ();
		wweButton = wweButton.GetComponent<Button> ();
		jungleButton = jungleButton.GetComponent<Button> ();
		randomButton = randomButton.GetComponent<Button> ();

	}
	
	// Update is called once per frame
	void Update () {
		//if (jungleButton)
	}

	public void wweLevel()
	{
		string wweLevelScene = SceneManager.GetSceneByName ().name;
		SceneManager.LoadScene (wweLevelScene, LoadSceneMode.Single);
	}
	public void jungleLevel()
	{
		string jungleLevelScene = SceneManager.GetSceneByName ().name;
		SceneManager.LoadScene (jungleLevelScene, LoadSceneMode.Single);
	}
	//public void randomLevel ()
	//{
		
	//}
	public void goBack()
	{
		string mainTitle = SceneManager.GetSceneByName ().name;
		SceneManager.LoadScene (mainTitle, LoadSceneMode.Single);
	}



}
