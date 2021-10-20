using System;
using System.Collections.Generic;
using System.Text;


namespace Metodo_Classe_selada.Entities
{
    class SavingsAccountPlus : SavingsAccount
    {
        
    }
}
/*Poruq Selar--- Segurança:  dependendo das regras do negócio, ás vezes é desejável garantir que uma classe não seja herdada,
 * ou que um métod não seja sobreposto.
 * Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas podem ser uma porta ade entrada para inconsistêncian.*/