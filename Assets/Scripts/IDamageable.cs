using UnityEngine;

public interface IDamageable {
    public int health{get; set;}
    public void TakeDamage(int amount); 
    
}

