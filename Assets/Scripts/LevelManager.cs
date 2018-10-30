using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public static LevelManager sharedInstance;

    public List<LevelBlock> allTheLevelBlocks = new List<LevelBlock>();

    public List<LevelBlock> currentLevelBlocks = new List<LevelBlock>();

    public Transform levelStartPosition;

    void Awake()
    {
        if(sharedInstance == null){
            sharedInstance = this;
        }
    }
    // Use this for initialization
    void Start () {
        GenerateInitialBlocks();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void AddLevelBlock(){

    }

    public void RemoveLevelBlock(){


    }

    public void RemoveAllLevelBlocks(){

    }

    public void GenerateInitialBlocks(){
        for (int i = 0; i < 2; i++){
            AddLevelBlock();
        }
    }
}
