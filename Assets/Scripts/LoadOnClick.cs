using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour
{ 

	public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene); 
            }
}