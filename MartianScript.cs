using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartianScript : MonoBehaviour
{
    public Sprite Exp1;
    public Sprite Exp2;
    [Range(-10.0f,-1.0f)]
    public float speed = -3.0f;
    [SerializeField] private SpriteRenderer sprR;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(speed * Time.deltaTime,0,0);
    }
    void OnCollisionEnter2D(Collision2D mrtin){
      if (mrtin.gameObject.CompareTag("DeathCollider"))
      {
        Invoke("Expl1",0.05f);
      }
      if (mrtin.gameObject.CompareTag("ProtectZone")){
        Destroy(gameObject);
      }
    }
    void Expl1(){
      sprR.sprite = Exp1;
      Invoke("Expl2",0.25f);
    }
    void Expl2(){
      sprR.sprite = Exp2;
      Invoke("Death",0.5f);
    }
    void Death(){
      Destroy(gameObject);
    }
}
