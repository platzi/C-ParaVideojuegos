using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
    menu,
    inGame,
    gameOver
}


public class GameManager : MonoBehaviour {

    public GameState currentGameState = GameState.menu;

    public static GameManager sharedInstance;

    void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame(){

    } 

    public void GameOver(){

    }

    public void BackToMenu(){

    }

    private void SetGameState(GameState newGameSate){
        if(newGameSate == GameState.menu){
            //TODO: colocar la lógica del menú
        } else if(newGameSate == GameState.inGame){
            //TODO: hay que preparar la escena para jugar
        }else if(newGameSate == GameState.gameOver){
            //TODO: preparar el juego para el Game Over
        }


        this.currentGameState = newGameSate;
    }


}
