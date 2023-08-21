using UnityEngine;

public class CovarianceDelegate : MonoBehaviour
{
    class Bonus { }
    class BadBonus : Bonus { }
   // class GoodBonus : Bonus { }

    delegate Bonus Bonusdelegate();

    static void Main(string[] args)
    {
        // ковариантность
        Bonusdelegate del1 = BonusMethod;
        del1();
       

        Bonusdelegate del2 = BadBonusMethod;
        del2();
    }
    

    static Bonus BonusMethod()
    {
        Debug.Log("Main method");
        return new Bonus();
    }

    static BadBonus BadBonusMethod()
    {
        Debug.Log("Bad bonus method");
        return new BadBonus();
    }

   /* static GoodBonus GoodBonusMethod()
    {
        Debug.Log("Good bonus method");
        return new GoodBonus();
    }    */


}
