using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[System.Serializable]
public class CheckInput : MonoBehaviour {

	public string possibleValue1;
	public string possibleValue2;
	private InputField userInput;
	public Color newColor;
	Image inputImage;
	public Sprite rightSprite;
	public Sprite wrongSprite;
	DisplayMessage displayMessage;

	void Start ()
		{
		userInput = gameObject.GetComponent<InputField>();
		inputImage = GetComponent<Image> ();
		displayMessage = GameObject.Find("Canvas").GetComponent<DisplayMessage> ();
			
		userInput.onEndEdit.AddListener(EnterText);

		}

		private void EnterText(string EnteredText)
		{
			Debug.Log(EnteredText);

			EnteredText = EnteredText.ToLower();

		if (EnteredText.Equals (possibleValue1) || EnteredText.Equals (possibleValue2)) {
			Debug.Log ("Correct!");
			inputImage.sprite = rightSprite;
			ColorBlock cb = userInput.colors;
			cb.normalColor = newColor;
			userInput.colors = cb;
			displayMessage.counter++;
		} else {
			inputImage.sprite = wrongSprite;
		}
			
		}
	}