using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlNivel : MonoBehaviour
{
    public GameObject pelotaActiva;
    public GameObject ReiniciaBoton;
    public GameObject pelota;
    public Transform inicioPelota;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void OnTriggerEnter(Collider other)
    {
        print("ganaste");
    }

    // Update is called once per frame
    void Update()
    {
        if (pelotaActiva == null)
            perdio();
    }
    public void reinicia(){
        pelotaActiva = Instantiate(pelota, inicioPelota);

        ReiniciaBoton.SetActive(false);
    }

    public void perdio()
    {
        ReiniciaBoton.SetActive(true);
    }
}
