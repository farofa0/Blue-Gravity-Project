public class HitPoints
{
	private int maxHP;
	private int currentHP;

    private bool isDead;
    public bool IsDead { get => isDead; }

    public HitPoints(int maxHP)
    {
        this.maxHP = maxHP;
        currentHP = maxHP;
    }

    public void ApplyDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            isDead = true;
        }
    }
}

