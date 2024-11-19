using UnityEngine;

public class ControladorFerramenta : MonoBehaviour
{
    public Vector3 posicaoFerramenta;
    public float deslocamentoFerramenta;
    public float incrementoVelocidade;
    internal float deslocamentoIncial;

    internal int sentidoV;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deslocamentoIncial = deslocamentoFerramenta;
        sentidoV = 1;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoFerramenta.x +=  deslocamentoFerramenta* Time.deltaTime;
        posicaoFerramenta.y +=  deslocamentoFerramenta* Time.deltaTime * sentidoV;
       
        transform.position = posicaoFerramenta;

        //arrumar sentido vertical:
        if (transform.position.y >= 465 && sentidoV == 1)
            sentidoV = -1;
        if (transform.position.y <= 39 && sentidoV == -1)
            sentidoV = 1;

        deslocamentoFerramenta += incrementoVelocidade * Time.deltaTime;


    }
}
