using UnityEngine;
using System.Collections;

public class BoardPosition : MonoBehaviour {
    /// <summary>
    /// Variable del tablero, establecida desde el Inspector
    /// </summary>
    public Board TheBoard;
    /// <summary>
    /// Indicamos si esta posición ya esta ocupado o no
    /// </summary>
    public bool Used;

    public int Type = 2;

    
	// Use this for initialization
	void Start () {
        //int a = pos[0].gameObject.GetComponent(BoardPosition);
	}
	
	// Update is called once per frame
	void Update () {
        //TheBoard.winner();
    }

    void OnMouseDown() {
        TheBoard.PlaceToken(this);
        
    }
}
