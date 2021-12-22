namespace WpfApp1
{
    class Unit
    {
        private double hp = 100;
        protected string name = "Unit";
        protected double strength = 20;
        protected double dexterity = 20; // ловкость
        protected double intelegence = 20;
        protected double constitution = 20; //телосложение
        private double extra = 20;
        private double attackSpeed;
        protected double pAttack;
        protected double mAttack;

        public double AttackSpeed { get => attackSpeed; set => attackSpeed = value; }

        public Unit()
        {
            pAttack = strength * 5 > 20 ? strength * 5 : extra;
            mAttack = intelegence * 10;
        }

        public void PhysAttack()
        {
            hp -= pAttack;
        }

        public void MagicAttack()
        {
            hp -= mAttack;
        }

        public void Defence()
        {

        }
    }

    class Warrior : Unit
    {
        private double hp;

        public Warrior()
        {
            hp += strength * 5;
            name = "Warrior";
        }
    }

    class Sorcerer : Unit
    {
        private double hp;
    }

    class Rogue : Unit
    {
        private double hp;
    }
}
