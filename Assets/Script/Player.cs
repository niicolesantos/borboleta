using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   

    public float veloc;
    public GameObject pfCoracao;
    public bool podeDisparar = true;
    public float tempoEntreTiros;
    public int vidaMaxima;
    public int vidaAtual;





    // Start is called before the first frame update
    void Start()
    {
        vidaAtual = vidaMaxima;

    }

    // Update is called once per frame
    void Update()
    {
        float entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * veloc * Time.deltaTime * entradaHorizontal);

        float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * veloc * Time.deltaTime * entradaVertical);

        if (Input.GetKeyDown(KeyCode.Space)&& podeDisparar == true){
            
            podeDisparar = false;
            Instantiate(pfCoracao,transform.position + new Vector3(0,1.1f,0),Quaternion.identity);
            Invoke ("CDTiro", tempoEntreTiros);


        }
            if ( transform.position.y > 0 ) {
            transform.position = new Vector3(transform.position.x,0,0);
        }

        if ( transform.position.y < -3.8f){
            transform.position = new Vector3(transform.position.x,-3.8f,0);
        }

        if ( transform.position.x > 9.65f){
            transform.position = new Vector3(-9.65f,transform.position.y,0);
        }

         if ( transform.position.x < -9.65f){
            transform.position = new Vector3(9.65f,transform.position.y,0);
        } 

    }  
    public void CDTiro(){

        podeDisparar = true;

    }
}
