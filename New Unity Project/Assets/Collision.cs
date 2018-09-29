using UnityEngine;

public class Collision : MonoBehaviour
{
    public TutorialEventsController t;
    public movimiento_caballero m;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hemos chocado");
        movimiento_pnj_prueba_1.canwalk = false;
        m.anim.enabled = false;
        t.nextEvent_a();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Estamos chocando");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Nos vamos a la vergota");
        /*if (t.acabado())
        {
            Initiate.Fade(pruebas, Color.white, 1.0f);
        }*/
}
}