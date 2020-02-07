using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<GameObject> fishesObjects = new List<GameObject>();
    public GameObject currentFishObjectPosition;
    public int difficulty = 0;
    GameObject currentFish;

    // Start is called before the first frame update
    void Start()
    {
        selectFishColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setGameDifficulty(int difficulty){
        this.difficulty = difficulty;
    }

    //Set MainCamera Position for Game1
    void setCameraPosition(){

    }

    void selectFishColor(){
        switch (this.difficulty){
            case 0:{
                int ran = Random.Range(0,2);
                setFishObjectInView(this.fishesObjects[ran]);
                startFishJumping();
                break;
            }
            case 1:{
                break;
            }
            case 2:{
                break;
            }
        }
    }

    void setFishObjectInView(GameObject fish){
        Debug.Log("ok");
        this.currentFish = Instantiate(fish, this.currentFishObjectPosition.transform.position, this.currentFishObjectPosition.transform.rotation);
    }

    void startFishJumping(){
        int ran = Random.Range(0,2);
        
    }
}
