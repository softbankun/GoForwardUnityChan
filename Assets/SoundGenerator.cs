using UnityEngine;
using System.Collections;

public class SoundGenerator : MonoBehaviour {

    // アイテムにくっついてる音の定義
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        // くっついてる音を取得
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    //接触したときの処理
    void OnCollisionEnter2D(Collision2D collision)
    {
        //tag:BlockSoundのついたアイテムに接触したとき"くっついてる音"を出す
        if (collision.gameObject.tag == "BlockSound")
        {
            audioSource.Play();
            //Debug.Log("トン");
        }
    }

}