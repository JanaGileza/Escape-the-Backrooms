using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class GameWin : MonoBehaviour
{    
    [SerializeField] string mainMenuScene;
    [SerializeField] Sprite[] _storySprites;

    int _currentImageIndex = 0;

    public void MouseClickListener()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ReplaceImage();
        }
    }

    void ReplaceImage(){
        if(_currentImageIndex < _storySprites.Length)
        {
            GetComponent<SpriteRenderer>().sprite = _storySprites[_currentImageIndex];
            _currentImageIndex++;
        }
        else
        {
            SceneManager.LoadScene(mainMenuScene);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = _storySprites[_currentImageIndex];        
    }

    void Update()
    {
        MouseClickListener();
    }

}
