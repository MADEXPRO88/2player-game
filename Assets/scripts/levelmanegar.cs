using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanegar : MonoBehaviour
{
    
    public bool player1indoor;
    public bool player2indoor;
    // Start is called before the first frame update
    void Start()
    {
        bool player1indoor = false;
        bool player2indoor = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player1indoor && player2indoor == true)
        {
            StartCoroutine(wait());
            SceneManager.LoadScene("Level2");
            Debug.Log("scenechange");
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
