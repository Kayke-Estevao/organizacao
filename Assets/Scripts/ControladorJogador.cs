using NUnit.Framework.Constraints;
using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    public float velocidadeMaozinha;
    public Geral JuizDoJogo;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // este codigo é para a mãozinha subir

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 465 )
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0); 
            transform.position  += novaPos;
        }
        // este codigo é para a mãozinha descer
        if (Input.GetKey(KeyCode.DownArrow ) && transform.position.y >=39)
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position -= novaPos;
        }
      


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.StartsWith("Ferramenta"))
        {
            float posicaoY = Random.value * 465;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.x = 0;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.y = posicaoY ;

            JuizDoJogo.MarcarPonto();
        }
    }



}
