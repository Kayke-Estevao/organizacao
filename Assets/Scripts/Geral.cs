using UnityEngine;
using UnityEngine.UI;

public class Geral : MonoBehaviour
{
    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;

    public GameObject objetoGameOver, personagemPrincipal,ferramenta;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        recordeNum = 0;
        
    }

    public void MarcarPonto()
    {
        placarJogadorNum += 1;
        if (recordeNum < placarJogadorNum)
            recordeNum += 1;
        AtualizarTextoPlacar();

        GetComponent<AudioSource>().Play();
    }

    public void AtualizarTextoPlacar()
    {
        placarJogadorTexto.text = "itens coletados:" + placarJogadorNum;
        recordeTexto.text = " recorde Atual:" + recordeNum;

    }



    public void IniciarPartida()
    {
        placarJogadorNum = 0;
        AtualizarTextoPlacar();
        //reposicionar ferramenta
       
       
        //sumir com game over
        objetoGameOver.SetActive(false);

        //reposicionar luva
        personagemPrincipal.transform.position = new Vector3(887, 250, 0);

       ferramenta.GetComponent<ControladorFerramenta>().posicaoFerramenta = new Vector3(0, 0, 0);

        //voltar a velocidade para o padrão
        ferramenta.GetComponent <ControladorFerramenta>().deslocamentoFerramenta =
        ferramenta.GetComponent<ControladorFerramenta>().deslocamentoIncial;
    }
}
