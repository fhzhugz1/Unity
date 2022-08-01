
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;


public class playerMove : MonoBehaviour
{
    public float speed = 0;// variavel velocidade publica que da pra ver no painel de ediçao do jogo
    public TextMeshProUGUI ContarMoedas;
    public GameObject winTextObject;
    private Rigidbody rb;// variavel do tipo Rigidbody com o nome de rb
    private int count;//variavel para contar as moedas 
    private float movementX;// tipo float com o nome de movimentox
    private float movementY;// mesmo de cima so que para y

    public void Start()
    {
        rb = GetComponent<Rigidbody>();// valor da variavel rb vai ser pega do Rigidbody que add no jogador no inicio
        count = 0;

        SetContarMoedas();
        winTextObject.SetActive(false);
     
    }


    void OnMove(InputValue movementValue) // n faço ideia , mas penso que que nao sei
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    void SetContarMoedas()
    {
        ContarMoedas.text =  count.ToString();
        if(count>=10)
        {
            winTextObject.SetActive(true);
           
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }

    /*void FixedUpdate()// WTF
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed); //velocidade

    }
    */
    
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);

        {
            if (Input.GetKeyDown("space") && GetComponent<Rigidbody>().transform.position.y <= 0.6250001f)
            {
                Vector3 jump = new Vector3(0.0f,300.0f, 0.0f);

                GetComponent<Rigidbody>().AddForce(jump);
            }
        }

    }


    private void OnTriggerEnter(Collider other)//criar uma tag para classificar as moedas com essa tag para depois se o objeto tiver a tag moeda entao desativa a colisao
    {
        if (other.gameObject.CompareTag("Moeda"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetContarMoedas();
        }
       
    }

    
}


