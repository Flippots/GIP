using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy; //Public variabele om de koppeling met de Alien prefab te maken.
                             //Dit doen we via het Inspector venster in Unity.

    float randX; //In deze variabele zullen we telkens opnieuw op een radom waarde initialiserer (in de
                 //update-functie. Deze waarde wordt gebruikt voor de X-coördinaat van de vector waar we 
                 //de alien laten spawnen.

    Vector2 WhereToSpawn; //De vector waar we de alien laten spawnen.
                          //Deze vector krijgt zijn waarde in de Update-functie.

    public float spawnRate = 5f; //Hiermee bepalen we het interval tussen 2 opeenvolgende spawns.
                                 //Gebruik: Zie Update-functie.

    float nextSpawn = 0f; //Hiermee bepalen we het tijdstip wanneer een nieuwe alien moet spawnen.
                          //Gebruik: Zie Update-functie.


    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn) //Time.time bevat het aantal seconden dat de applicatie al aan het
                                   //runnen is. Van zodra dit aantal seconden groter wordt dan nextSpawn, 
                                   //wordt de inhoud van de selectie uitgevoerd.
                                   //Als het programma pas start, is nextSpawn gelijk aan 0  
                                   //(zie initialisatie bij de declaratie hierboven). Er zal dus direct een 
                                   //alien spawnen.
        {
            nextSpawn = Time.time + spawnRate;      //De tijd waarop een nieuwe alien moet spawnen wordt 
                                                    //ingesteld op de tijd dat de applicatie loopt + de 
                                                    //spawnRate.
                                                    //Opmerking: A.h.v. de spawnRate kunnen we dus beïnvloeden 
                                                    //hoe snel of hoe traag er aliens spawnen.

            randX = Random.Range(-11.42f, 11.42f); //De variabele randX wordt geïnitialiseerd op een random waarde 
                                                   //die ligt tussen -11.42 en 11.42.
                                                   //Let op: vervang deze waarden door de waarden die je genoteerd 
                                                   //hebt toen je het object EnemySpawner uiterst links en uiterst 
                                                   //rechts plaatste. Door dit te doen, pas je de functie
                                                   //aan jouw game aan.

            WhereToSpawn = new Vector2(randX, transform.position.y); //De vector waar de alien moet spawnen wordt 
                                                                     //geïnitialiseerd. Deze vector heeft een X- en 
                                                                     //een Y-coördinaat nodig. Als X-coördinaat 
                                                                     //gebruiken we randX, die we net een random waarde  
                                                                     //gaven. Omdat randX telkens een nieuwe random 
                                                                     //waarde krijgt, zal een alien dus steeds 
                                                                     //op een andere positie langs de X-as spawnen.
                                                                     //Als Y-coördinaat gebruiken we de Y-positie van het 
                                                                     //EnemySpawner object. Zoals je reeds weet kan je de 
                                                                     //positie van het object waaraan een script gekoppeld 
                                                                     //is oproepen d.m.v. transform.position. Uit deze 
                                                                     //positie kan je de Y-coördinaat aanspreken
                                                                     //d.m.v. transform.position.y.

            Instantiate(enemy, WhereToSpawn, Quaternion.identity);  //Ook deze functie gebruikten we reeds, namelijk bij het 
                                                                    //spawnen van bullets.
                                                                    //We geven hier aan dat we van het enemy gameObject (public
                                                                    //variabele die we in Unity instellen op de prefab van de 
                                                                    //alien) een instantie maken op de positie WhereToSpawn.
                                                                    //Quaternion.identity geeft aan dat er geen rotatie nodig is. 
                                                                    //Je mag dit steeds zo instellen bij de projecten die je maakt. 
        }
    }
}
