using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {

    /// <summary>
    /// Almacena el jugador que va a realizar el siguiente
    /// movimiento, se utiliza para saber que ficha
    /// colocar. Cuando el valor es 0 entonces se tira el 
    /// TACHE mientras que si el valor es 1 entonces se
    /// coloca CÍRCULO
    /// </summary>
    private int _playerGame;
    /// <summary>
    /// Prefab del Tache
    /// </summary>
    public GameObject Cross;
    /// <summary>
    /// Prefab del Círculo
    /// </summary>
    public GameObject Circle;

	public BoardPosition[] Positions;
   // public int iVer;
    //public int iHor;

    void OnGUI () {
        string NextPlayer = _playerGame == 0 ? "TACHE" : "CÍRCULO";
        GUILayout.Label("Es el turno del jugador: " + NextPlayer);

        
    }

	// Use this for initialization
	void Start () {
	    _playerGame = 0;
	}
	
	// Update is called once per frame
	void Update () {
        winner(Positions);
	}

    /// <summary>
    /// Coloca la pieza de juego en la posición dada
    /// </summary>
    /// <param name="bp">Objeto BoardPosition que representa la posición
    /// en el tablero</param>
    public void PlaceToken (BoardPosition bp) {
        // Si la posición no está ocupada entonces colocamos
        // la ficha, de lo contrario, no hacemos nada
        if (!bp.Used) {
            // Guardamos la posición a utilizar
            Vector3 pos = bp.gameObject.transform.position;
            // Colocamos la ficha según el tipo de _playerGame que tenemos,
            // recuerda si _playerGame es 0 entonces colocamos un tache
            // de lo contrario colocamos un círculo
            GameObject obj = Instantiate(_playerGame == 0 ? Cross : Circle,
                                                      pos,
                                                      Quaternion.identity) as GameObject;
            // Marcamos la casilla como ocupada
            bp.Used = true;

			bp.Type = _playerGame;
			Debug.Log("Hola mundo");
			            
            // Cambiamos la ficha para el siguiente juego
            _playerGame = _playerGame == 0 ? 1 : 0;    
        }

    }

    public void winner(BoardPosition[] position)
    {

        //Horizontales Circulo
        for (int i = 0; i < 3; i++)
        {
            int iVer = i;
            int iHor = i * 3;
            if (position[iHor].Type == 1 &&
            position[iHor + 1].Type == 1 &&
            position[iHor + 2].Type == 1)
            {
                Debug.Log("Gano Circulo");
            }
        }
        //Horizontales Tache
        for (int i = 0; i < 3; i++)
        {
            int iVer = i;
            int iHor = i * 3;
            if (position[iHor].Type == 0 &&
            position[iHor + 1].Type == 0 &&
            position[iHor + 2].Type == 0)
            {
                Debug.Log("Gano Tache");
            }
        }

        //VERTICAL CIRCULO
        
        if (position[0].Type == 1 &&
            position[5].Type == 1 &&
            position[6].Type == 1)
        {
            Debug.Log("Gano Circulo");
        }
        if (position[1].Type == 1 &&
        position[4].Type == 1 &&
        position[7].Type == 1)
        {
            Debug.Log("Gano Circulo");
        }
        if (position[2].Type == 1 &&
        position[3].Type == 1 &&
        position[8].Type == 1)
        {
            Debug.Log("Gano Circulo");
        }

        //VERTICAL TACHE

        if (position[0].Type == 0 &&
            position[5].Type == 0 &&
            position[6].Type == 0)
        {
            Debug.Log("Gano Tache");
        }
        if (position[1].Type == 0 &&
        position[4].Type == 0 &&
        position[7].Type == 0)
        {
            Debug.Log("Gano Tache");
        }
        if (position[2].Type == 0 &&
        position[4].Type == 0 &&
        position[8].Type == 0)
        {
            Debug.Log("Gano Tache");
        }
    
        //DIAGONAL TACHE
        if (position[0].Type == 0 &&
             position[4].Type == 0 &&
             position[8].Type == 0)
        {
            Debug.Log("Gano Tache");
        }
        if (position[6].Type == 0 &&
             position[4].Type == 0 &&
             position[2].Type == 0)
        {
            Debug.Log("Gano Tache");
        }

        //DIAGONAL CIRCULO 
        if (position[0].Type == 1 &&
             position[4].Type == 1 &&
             position[8].Type == 1)
        {
            Debug.Log("Gano Circulo");
        }
        if (position[6].Type == 1&&
             position[4].Type == 1 &&
             position[2].Type == 1)
        {
            Debug.Log("Gano Circulo");
        }
    }


    
}
