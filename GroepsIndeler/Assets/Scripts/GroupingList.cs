using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupingList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int amountOfGroups = 0;
        int amountOfExtraPeople = 0;
        int students = 0;

        for( int i = 0; i < 200; i++ )
        {
            if( i > 41 )
            {
                amountOfGroups = 0;
                amountOfExtraPeople = 0;

                students = 0;

                amountOfGroups = i / 8;
                amountOfExtraPeople = i % 8;

                Debug.Log( "BASE 8:     STUDENTS: " + i + "     AMOUNT OF GROUPS: " + amountOfGroups + "    MODULO: " + amountOfExtraPeople );

                if( amountOfExtraPeople == 0 )
                {
                    for( int j = 0; j < amountOfGroups; j++ )
                    {
                        Debug.Log( 8 );
                        students = students + 8;
                    }
                }
                else
                {
                    int amountToDrop = 8 - amountOfExtraPeople;

                    for( int j = 0; j < amountOfGroups + 1; j++ )
                    {
                        if( amountToDrop > 0 )
                        {
                            amountToDrop = amountToDrop - 1;
                            Debug.Log( 7 );
                            students = students + 7;
                        }
                        else
                        {
                            Debug.Log( 8 );
                            students = students + 8;
                        }
                    }
                }

                Debug.Log( "final check: " + students + " / " + i );
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
