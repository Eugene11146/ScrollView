using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoldPosition : MonoBehaviour
{

    public GameObject image;
    public GameObject Handler;

    private float _imagePosition;

    public GameObject _doubler;

    public GameObject top;
    public GameObject bottom;

    

    private void Start()
    {
        _imagePosition = transform.position.y;

        
    }


    private void Hold()
    {
        

        if (_imagePosition - transform.position.y < -(Screen.height/2))
        {
            
            _doubler.SetActive(true);
            _doubler.transform.position = new Vector2(transform.position.x, top.transform.position.y);


        }
        else if (_imagePosition - transform.position.y > (Screen.height / 2))
        {
            _doubler.SetActive(true);
            _doubler.transform.position = new Vector2(transform.position.x, bottom.transform.position.y);

        }
        else
        {
            _doubler.SetActive(false);
        }

    }

   


    private void Update()
    {
        Hold();

    }

}
