using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObjectTest : MonoBehaviour
{

    public delegate void ObjectEvent();
    public ObjectEvent OnObjectDeath;

    [SerializeField] float tToDestroy;
    SpawnerTest m_spawner;

    public void RegisterDelegateTo(SpawnerTest spawner)
    {
        //Register you method to the event
        m_spawner = spawner;
        OnObjectDeath += m_spawner.OnSpawnedObjectDeath;
        Invoke("DestroySpawnedObject", tToDestroy);
    }


    void DestroySpawnedObject()
    {
        if (OnObjectDeath != null)
        { //Check delegates for null, running 
          //null delegates causes errors.
            OnObjectDeath();
            OnObjectDeath -= m_spawner.OnSpawnedObjectDeath;
        }
        Destroy(this.gameObject);
    }
}