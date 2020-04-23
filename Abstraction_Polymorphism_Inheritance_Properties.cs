using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode

{   public abstract class Character
    {
        public abstract void Stats();
    }
    public class Mage : Character
    {
        private double hp,stm,mna;

        public Mage() {}

        public Mage(double health, double stamina, double mana)
        {
            health = hp;
	    stamina = stm;
	    mana = mna;
        }

        public override void Stats()
        {
            hp =110;
	    mna =210;
	    stm =100;
        }

        public double health { get { return hp; } set { hp = value; } }
        public double mana { get { return mna; } set { mna = value; } }
	public double stamina { get { return stm; } set { stm = value; } }
    }
    public class MageAttack : Mage
    {
        public void FireBall()
        {
            Console.WriteLine("\nMage used FireBall.");
        }
    }
	
    public class Warrior : Character
    {
        private double hp,stm,rg;

        public Warrior() {}

        public Warrior(double health, double stamina, double rage)
        {
            health = hp;
	    stamina = stm;
	    rage = rg;
        }

        public override void Stats()
        {
            hp =210;
	    rg =100;
	    stm =300;
        }

        public double health { get { return hp; } set { hp = value; } }
        public double rage { get { return rg; } set { rg = value; } }
	public double stamina { get { return stm; } set { stm = value; } }
    }
    public class WarriorAttack : Warrior
    {
        public void SwordSlash()
        {
            Console.WriteLine("\nWarrior used SwordSlash.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
	    int end=0;

	    Mage mage =new Mage();
	    Warrior warrior =new Warrior();
	    MageAttack mage_attack =new MageAttack();
	    WarriorAttack warrior_attack =new WarriorAttack();

	    do{
	    Console.Write("\nPick a class or exit:"+ "\n1-Mage"+ "\n2-Warrior" +"\n3-Exit" + "\nYour choice:");
	    int sw=Convert.ToInt32(Console.ReadLine());
	    if (sw==1)
	    {
	    mage.Stats();
	    Console.Write("\nClass Mage"+"\nStats: hp="+mage.health+" mana="+mage.mana+" stamina="+mage.stamina);
	    mage_attack.FireBall();
	    }
	    if (sw==2)
	    {
	    warrior.Stats();
	    Console.Write("\nClass Warrior"+"\nStats: hp="+warrior.health+" rage="+warrior.rage+" stm="+warrior.stamina);
	    warrior_attack.SwordSlash();
	    }
	    if (sw==3)
	    {
		end=1;
	    }
	    }while(end!=1);
	
	    Console.WriteLine("end...");
            Console.ReadKey();
        }
    }
}
