/**
 * Universidad de La Laguna 
 * Escuela Superior de ingeniería y Tecnología
 * Grado en ingeniería informática
 * Curso : 4º
 * Asignatura: Interfaces Inteligentes 
 * 
 * @author Raimon Mejías Hernández (alu0101390161@ull.edu.es)
 * @brief Script introductorio que imprime por pantalla el tipo de objeto en escena
 *  y la cantidad de frames que se ha ejecutado dicho script
 * @date 2023-09-23
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p01_script : MonoBehaviour
{
    private int frame = 0;
    public string type = "Default";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Hola!, soy un: {type}");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Hola, sigo siendo un {type} en el frame: {frame}");
        frame++;
    }
}
