using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{

    //private Animator anim;
    private float animationTime = 0;
    private ScoreManager ScoreManager;
    private bool collected;
    public int points = 1;

    void Start(){
    ScoreManager = GameObject.Find("ScoreManagerobject").GetComponent<ScoreManager>();
    collected = false;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")&& !collected){
            collected = true;   
            ScoreManager.IncrementScore(points);
            //anim.SetTrigger("collected");
            Invoke("CollectCoin", animationTime);
        }
    }

    private void CollectCoin(){
        Destroy (gameObject);
    }
}
