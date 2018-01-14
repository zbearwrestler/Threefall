using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeyboardGUI : MonoBehaviour {

    public Sprite P;
    public Sprite S;
    public Sprite R;
	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Image>().overrideSprite = R;

	}
	
    public void newgun(int next)
    {
        if (next == 0)
        {
            Debug.Log(P);
            this.gameObject.GetComponent<Image>().overrideSprite = P;
        }
        else if (next == 1)
        {
            Debug.Log(S);
            this.gameObject.GetComponent<Image>().overrideSprite = S;
        }
        else
        {
            Debug.Log(R);
            this.gameObject.GetComponent<Image>().overrideSprite = R;
        }
    }

	
}
